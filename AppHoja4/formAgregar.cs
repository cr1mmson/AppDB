using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtNombreUser.Text) || string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtTelefono.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            // Validar que el ID sea un número
            if (!long.TryParse(txtID.Text, out long dpi))
            {
                MessageBox.Show("El ID debe ser un número.");
                return;
            }
            // Validar que el teléfono sea un número
            if (!long.TryParse(txtTelefono.Text, out long telefono))
            {
                MessageBox.Show("El teléfono debe ser un número.");
                return;
            }
            // Validar que el correo tenga un formato válido
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCorreo.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return;
            }
            dpi = Convert.ToInt64(txtID.Text);
            string fecha = pFechaN.Value.ToString("yyyy-MM-dd");
            long telef= Convert.ToInt64(txtTelefono.Text);


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

                MessageBox.Show("Usuario agregado correctamente con el código." + Services.nCuentaGlobal.numero_cuenta);
            }
            catch (Exception ex) { 
                
                MessageBox.Show(ex.Message);
            
            }
        }
    }
}
