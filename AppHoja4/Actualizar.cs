using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppHoja4
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private void txtBuscarUserAct_TextChanged(object sender, EventArgs e)
        {
            string userToFind = txtBuscarUserAct.Text;
        }

        private void listUserData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listUserData.SelectedIndex;
        }

        private void btnActualizarUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarUserAct.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!long.TryParse(txtBuscarUserAct.Text, out long nCuenta))
            {
                MessageBox.Show("El numero de cuenta es invalido.");
                return;
            }

        }
    }
}
