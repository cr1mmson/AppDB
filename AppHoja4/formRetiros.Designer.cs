namespace AppHoja4
{
    partial class formRetiros
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
            this.txtBuscarUserDelRet = new System.Windows.Forms.TextBox();
            this.lblBuscarCódigoDelRet = new System.Windows.Forms.Label();
            this.lblRetiros = new System.Windows.Forms.Label();
            this.lblCantidadRet = new System.Windows.Forms.Label();
            this.txtCantidadRet = new System.Windows.Forms.TextBox();
            this.btnRetiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBuscarUserDelRet
            // 
            this.txtBuscarUserDelRet.Location = new System.Drawing.Point(167, 193);
            this.txtBuscarUserDelRet.Name = "txtBuscarUserDelRet";
            this.txtBuscarUserDelRet.Size = new System.Drawing.Size(213, 20);
            this.txtBuscarUserDelRet.TabIndex = 9;
            // 
            // lblBuscarCódigoDelRet
            // 
            this.lblBuscarCódigoDelRet.AutoSize = true;
            this.lblBuscarCódigoDelRet.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCódigoDelRet.Location = new System.Drawing.Point(163, 131);
            this.lblBuscarCódigoDelRet.Name = "lblBuscarCódigoDelRet";
            this.lblBuscarCódigoDelRet.Size = new System.Drawing.Size(259, 23);
            this.lblBuscarCódigoDelRet.TabIndex = 8;
            this.lblBuscarCódigoDelRet.Text = "Ingrese Código de Usuario";
            // 
            // lblRetiros
            // 
            this.lblRetiros.AutoSize = true;
            this.lblRetiros.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetiros.Location = new System.Drawing.Point(307, 38);
            this.lblRetiros.Name = "lblRetiros";
            this.lblRetiros.Size = new System.Drawing.Size(248, 32);
            this.lblRetiros.TabIndex = 7;
            this.lblRetiros.Text = "Realizar un retiro";
            // 
            // lblCantidadRet
            // 
            this.lblCantidadRet.AutoSize = true;
            this.lblCantidadRet.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadRet.Location = new System.Drawing.Point(163, 242);
            this.lblCantidadRet.Name = "lblCantidadRet";
            this.lblCantidadRet.Size = new System.Drawing.Size(94, 23);
            this.lblCantidadRet.TabIndex = 10;
            this.lblCantidadRet.Text = "Cantidad";
            // 
            // txtCantidadRet
            // 
            this.txtCantidadRet.Location = new System.Drawing.Point(167, 277);
            this.txtCantidadRet.Name = "txtCantidadRet";
            this.txtCantidadRet.Size = new System.Drawing.Size(213, 20);
            this.txtCantidadRet.TabIndex = 13;
            // 
            // btnRetiro
            // 
            this.btnRetiro.Location = new System.Drawing.Point(167, 333);
            this.btnRetiro.Name = "btnRetiro";
            this.btnRetiro.Size = new System.Drawing.Size(75, 23);
            this.btnRetiro.TabIndex = 14;
            this.btnRetiro.Text = "Retiro";
            this.btnRetiro.UseVisualStyleBackColor = true;
            this.btnRetiro.Click += new System.EventHandler(this.btnRetiro_Click);
            // 
            // formRetiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetiro);
            this.Controls.Add(this.txtCantidadRet);
            this.Controls.Add(this.lblCantidadRet);
            this.Controls.Add(this.txtBuscarUserDelRet);
            this.Controls.Add(this.lblBuscarCódigoDelRet);
            this.Controls.Add(this.lblRetiros);
            this.Name = "formRetiros";
            this.Text = "formRetiros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscarUserDelRet;
        private System.Windows.Forms.Label lblBuscarCódigoDelRet;
        private System.Windows.Forms.Label lblRetiros;
        private System.Windows.Forms.Label lblCantidadRet;
        private System.Windows.Forms.TextBox txtCantidadRet;
        private System.Windows.Forms.Button btnRetiro;
    }
}