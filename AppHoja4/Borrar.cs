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
        }
    }
}
