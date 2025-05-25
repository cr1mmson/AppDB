using System;

using System.Windows.Forms;
using AppHoja4.Classes;

namespace AppHoja4
{
    public partial class formDeposito : Form
    {
        public formDeposito()
        {
            InitializeComponent();
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
           txtBuscarUserDelDep.Text = txtBuscarUserDelDep.Text.Trim();

            if (txtBuscarUserDelDep.Text.Length > 0)
            {
                try
                {
                    long DPICliente = long.Parse(txtBuscarUserDelDep.Text);
                    int monto = int.Parse(txtCantidadDep.Text);
                    Services.Deposito(DPICliente, monto, listBoxMoneda.SelectedIndex + 1);
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
