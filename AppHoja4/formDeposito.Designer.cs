namespace AppHoja4
{
    partial class formDeposito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscarUserDelDep = new System.Windows.Forms.TextBox();
            this.lblIngresarCD = new System.Windows.Forms.Label();
            this.lblDeposito = new System.Windows.Forms.Label();
            this.lblCantidadDep = new System.Windows.Forms.Label();
            this.txtCantidadDep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBuscarUserDelDep
            // 
            this.txtBuscarUserDelDep.Location = new System.Drawing.Point(162, 195);
            this.txtBuscarUserDelDep.Name = "txtBuscarUserDelDep";
            this.txtBuscarUserDelDep.Size = new System.Drawing.Size(213, 20);
            this.txtBuscarUserDelDep.TabIndex = 9;
            // 
            // lblIngresarCD
            // 
            this.lblIngresarCD.AutoSize = true;
            this.lblIngresarCD.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresarCD.Location = new System.Drawing.Point(158, 133);
            this.lblIngresarCD.Name = "lblIngresarCD";
            this.lblIngresarCD.Size = new System.Drawing.Size(259, 23);
            this.lblIngresarCD.TabIndex = 8;
            this.lblIngresarCD.Text = "Ingrese Código de Usuario";
            // 
            // lblDeposito
            // 
            this.lblDeposito.AutoSize = true;
            this.lblDeposito.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposito.Location = new System.Drawing.Point(302, 40);
            this.lblDeposito.Name = "lblDeposito";
            this.lblDeposito.Size = new System.Drawing.Size(288, 32);
            this.lblDeposito.TabIndex = 7;
            this.lblDeposito.Text = "Realizar un deposito";
            // 
            // lblCantidadDep
            // 
            this.lblCantidadDep.AutoSize = true;
            this.lblCantidadDep.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDep.Location = new System.Drawing.Point(158, 250);
            this.lblCantidadDep.Name = "lblCantidadDep";
            this.lblCantidadDep.Size = new System.Drawing.Size(94, 23);
            this.lblCantidadDep.TabIndex = 11;
            this.lblCantidadDep.Text = "Cantidad";
            // 
            // txtCantidadDep
            // 
            this.txtCantidadDep.Location = new System.Drawing.Point(162, 296);
            this.txtCantidadDep.Name = "txtCantidadDep";
            this.txtCantidadDep.Size = new System.Drawing.Size(213, 20);
            this.txtCantidadDep.TabIndex = 12;
            // 
            // formDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCantidadDep);
            this.Controls.Add(this.lblCantidadDep);
            this.Controls.Add(this.txtBuscarUserDelDep);
            this.Controls.Add(this.lblIngresarCD);
            this.Controls.Add(this.lblDeposito);
            this.Name = "formDeposito";
            this.Text = "formDeposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarUserDelDep;
        private System.Windows.Forms.Label lblIngresarCD;
        private System.Windows.Forms.Label lblDeposito;
        private System.Windows.Forms.Label lblCantidadDep;
        private System.Windows.Forms.TextBox txtCantidadDep;
    }
}