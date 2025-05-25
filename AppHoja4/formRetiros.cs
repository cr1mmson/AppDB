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
    public partial class formRetiros : Form
    {
        public formRetiros()
        {
            InitializeComponent();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            txtBuscarUserDelRet.Text = txtBuscarUserDelRet.Text.Trim();

            if (txtBuscarUserDelRet.Text.Length > 0)
            {
                try
                {
                    long DPICliente = long.Parse(txtBuscarUserDelRet.Text);
                    int monto = int.Parse(txtCantidadRet.Text);
                    Services.Retiro(DPICliente, monto);
                    MessageBox.Show("Deposito realizado con exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al realizar el deposito: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DPI valido.");
            }
        }
    }
}
