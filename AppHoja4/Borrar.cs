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
    public partial class Borrar : Form
    {
        public Borrar()
        {
            InitializeComponent();
        }

        private void txtBuscarUserDel_TextChanged(object sender, EventArgs e)
        {
           string userToFind = txtBuscarUserDel.Text;
        }

        private void btnBorrarUser_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Usuario eliminado");
            if (string.IsNullOrWhiteSpace(txtBuscarUserDel.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            if (!long.TryParse(txtBuscarUserDel.Text, out long DPI))
            {
                MessageBox.Show("El numero de DPI es invalido.");
                return;
            }
            if (DPI == 0)
            {
                MessageBox.Show("El numero de DPI no puede ser cero.");
                return;
            }
            if (DPI < 0)
            {
                MessageBox.Show("El numero de DPI no puede ser negativo.");
                return;
            }
            Services.DeleteUser(DPI);
        }
    }
}
