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
            this.btnDepositar = new System.Windows.Forms.Button();
            this.listBoxMoneda = new System.Windows.Forms.ListBox();
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
            this.lblIngresarCD.Size = new System.Drawing.Size(374, 23);
            this.lblIngresarCD.TabIndex = 8;
            this.lblIngresarCD.Text = "Ingrese Numero de Cuenta del Usuario";
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
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(162, 352);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDepositar.Size = new System.Drawing.Size(75, 23);
            this.btnDepositar.TabIndex = 13;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // listBoxMoneda
            // 
            this.listBoxMoneda.FormattingEnabled = true;
            this.listBoxMoneda.Items.AddRange(new object[] {
            "USD",
            "EUR",
            "GTQ"});
            this.listBoxMoneda.Location = new System.Drawing.Point(439, 293);
            this.listBoxMoneda.Name = "listBoxMoneda";
            this.listBoxMoneda.Size = new System.Drawing.Size(33, 43);
            this.listBoxMoneda.TabIndex = 14;
            // 
            // formDeposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxMoneda);
            this.Controls.Add(this.btnDepositar);
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
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.ListBox listBoxMoneda;
    }
}