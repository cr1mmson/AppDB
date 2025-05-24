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

namespace AppHoja4
{
    public partial class formLeer : Form
    {
        public formLeer()
        {
            InitializeComponent();
        }

        private void txtBuscarUser_TextChanged(object sender, EventArgs e)
        {
            string userToFind = txtBuscarUser.Text;
        }

        private void btnBuscarUser_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtBuscarUser.Text))
            {
                MessageBox.Show("Por favor, ingrese un numero de cuenta para buscar.");
                return;
            }

            if (!long.TryParse(txtBuscarUser.Text, out long nCuenta))
            {
                MessageBox.Show("El numero de cuenta es invalido.");
                return;
            }

            try
            {
                DataTable table = Services.SearchUser(nCuenta);

                dataUser.DataSource = table;

                dataUser.Columns["Numero de Cuenta"].HeaderText = "Numero de Cuenta";
                dataUser.Columns["Nombre"].HeaderText = "Nombre";
                dataUser.Columns["Telefono"].HeaderText = "Telefono";
                dataUser.Columns["E-mail"].HeaderText = "E-mail";

                dataUser.Columns[0].ReadOnly = true;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
