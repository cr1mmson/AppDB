using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppHoja4.Classes;
using Mysqlx.Cursor;

namespace AppHoja4
{
    public partial class formAgregar : Form
    {
        private sst sst = new sst(); // Add an instance of sst

        public formAgregar()
        {
            InitializeComponent();
        }

        private void pFechaN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void formAgregar_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUser.Text) || string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if (!long.TryParse(txtID.Text, out long dpi))
            {
                MessageBox.Show("El ID debe ser un número.");
                return;
            }
            if (!long.TryParse(txtTelefono.Text, out long telefono))
            {
                MessageBox.Show("El teléfono debe ser un número.");
                return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return;
            }
            dpi = Convert.ToInt64(txtID.Text);
            string fecha = pFechaN.Value.ToString("yyyy-MM-dd");
            long telef = Convert.ToInt64(txtTelefono.Text);


            try
            {
                Services.SaveUser(
                        dpi,
                        txtNombreUser.Text,
                        fecha,
                        telef,
                        txtCorreo.Text
                );

                Services.LinkAccount(dpi);
                
                sst.push(new Node(dpi, txtNombreUser.Text, fecha, telef, txtCorreo.Text));


                MessageBox.Show("Usuario agregado correctamente con el código." + Services.nCuentaGlobal.numero_cuenta);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Node[] usuarios = sst.ObtenerTodos();
            if (usuarios.Length == 0)
            {
                MessageBox.Show("No hay usuarios agregados.");
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Historial de Usuarios Agregados:");
            foreach (Node usuario in usuarios)
            {
                sb.AppendLine($"DPI: {usuario.DPI}, Nombre: {usuario.Nombre}, Fecha de Nacimiento: {usuario.Fecha}, Teléfono: {usuario.Telefono}, Correo: {usuario.correoElectronico}");
            }

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("DPI", typeof(long));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Fecha de Nacimiento", typeof(string));
            dataTable.Columns.Add("Teléfono", typeof(long));
            dataTable.Columns.Add("Correo Electrónico", typeof(string));
            foreach (Node usuario in usuarios)
            {
                dataTable.Rows.Add(usuario.DPI, usuario.Nombre, usuario.Fecha, usuario.Telefono, usuario.correoElectronico);
            }
            Form historialForm = new Form();
            historialForm.Text = "Historial de Usuarios";
            DataGridView dataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                DataSource = dataTable,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            historialForm.Controls.Add(dataGridView);
            historialForm.Size = new Size(800, 600);
            historialForm.ShowDialog();


        }
    }
}
