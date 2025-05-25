using System;
using System.Windows.Forms;
using AppHoja4.Classes;

namespace AppHoja4
{
    public partial class Actualizar : Form
    {
        private DateTimePicker updateDTP;

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
            if (listUserData.SelectedIndex == 1)
            {
                txtField.Visible = false;

                if (updateDTP == null)
                {
                    updateDTP = new DateTimePicker();
                    updateDTP.Format = DateTimePickerFormat.Custom;
                    updateDTP.CustomFormat = "yyyy-MM-dd";
                    updateDTP.Location = new System.Drawing.Point(320, 250);
                    updateDTP.Size = new System.Drawing.Size(200, 20);
                    this.Controls.Add(updateDTP);
                }

                updateDTP.Visible = true;
            }
            else
            {
                if (updateDTP != null)
                    updateDTP.Visible = false;

                txtField.Visible = true;
            }
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
            int selectedIndex = listUserData.SelectedIndex + 1;

            switch(selectedIndex){

                case 1: { Services.UpdateUser(nCuenta, selectedIndex, txtField.Text); } break;
                case 2: {

                        if (updateDTP == null)
                        {
                            MessageBox.Show("Por favor, seleccione una fecha.");
                            return;
                        }

                        string fechaSeleccionada = updateDTP.Value.ToString("yyyy-MM-dd");
                         Services.UpdateUser(nCuenta, selectedIndex, fechaSeleccionada);

                    } break;

                case 3: {
                        
                         if (!int.TryParse(txtField.Text, out int tel)){
                                MessageBox.Show("El teléfono debe ser un número.");
                             return;
                          }
                        
                        Services.UpdateUser(nCuenta, selectedIndex, tel.ToString()); 
                    } break;

                case 4: {
                        if (!System.Text.RegularExpressions.Regex.IsMatch(txtField.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                        {
                            MessageBox.Show("El correo electrónico no es válido.");
                            return;
                        }
                        Services.UpdateUser(nCuenta, selectedIndex, txtField.Text);
                    }
                    break;

            }


                

        }
    }
}
