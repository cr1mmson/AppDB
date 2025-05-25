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
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }

        void openForm(Form form) {

            while (panelApp.Controls.Count > 0) { 
                panelApp.Controls.RemoveAt(0);  
            }
            Form childForm = form;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelApp.Controls.Add(childForm);   
            childForm.Show();

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            openForm(new formAgregar());
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            openForm(new formLeer());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            openForm(new Actualizar());
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            openForm(new Borrar());
        }

        private void btnDepositos_Click(object sender, EventArgs e)
        {
            openForm(new formDeposito());
        }

        private void btnRetiros_Click(object sender, EventArgs e)
        {
            openForm(new formRetiros());
        }
    }
}
