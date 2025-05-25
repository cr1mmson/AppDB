namespace AppHoja4
{
    partial class Borrar
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
            this.lblBorrar = new System.Windows.Forms.Label();
            this.lblBuscarCódigoDel = new System.Windows.Forms.Label();
            this.txtBuscarUserDel = new System.Windows.Forms.TextBox();
            this.btnBorrarUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBorrar
            // 
            this.lblBorrar.AutoSize = true;
            this.lblBorrar.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrar.Location = new System.Drawing.Point(282, 32);
            this.lblBorrar.Name = "lblBorrar";
            this.lblBorrar.Size = new System.Drawing.Size(213, 32);
            this.lblBorrar.TabIndex = 3;
            this.lblBorrar.Text = "Borrar Usuario";
            // 
            // lblBuscarCódigoDel
            // 
            this.lblBuscarCódigoDel.AutoSize = true;
            this.lblBuscarCódigoDel.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCódigoDel.Location = new System.Drawing.Point(138, 125);
            this.lblBuscarCódigoDel.Name = "lblBuscarCódigoDel";
            this.lblBuscarCódigoDel.Size = new System.Drawing.Size(245, 23);
            this.lblBuscarCódigoDel.TabIndex = 5;
            this.lblBuscarCódigoDel.Text = "Ingrese le DPI de Usuario";
            // 
            // txtBuscarUserDel
            // 
            this.txtBuscarUserDel.Location = new System.Drawing.Point(142, 187);
            this.txtBuscarUserDel.Name = "txtBuscarUserDel";
            this.txtBuscarUserDel.Size = new System.Drawing.Size(213, 20);
            this.txtBuscarUserDel.TabIndex = 6;
            this.txtBuscarUserDel.TextChanged += new System.EventHandler(this.txtBuscarUserDel_TextChanged);
            // 
            // btnBorrarUser
            // 
            this.btnBorrarUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBorrarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrarUser.Location = new System.Drawing.Point(142, 243);
            this.btnBorrarUser.Name = "btnBorrarUser";
            this.btnBorrarUser.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarUser.TabIndex = 13;
            this.btnBorrarUser.Text = "Borrar";
            this.btnBorrarUser.UseVisualStyleBackColor = false;
            this.btnBorrarUser.Click += new System.EventHandler(this.btnBorrarUser_Click);
            // 
            // Borrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(829, 544);
            this.Controls.Add(this.btnBorrarUser);
            this.Controls.Add(this.txtBuscarUserDel);
            this.Controls.Add(this.lblBuscarCódigoDel);
            this.Controls.Add(this.lblBorrar);
            this.Name = "Borrar";
            this.Text = "Borrar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorrar;
        private System.Windows.Forms.Label lblBuscarCódigoDel;
        private System.Windows.Forms.TextBox txtBuscarUserDel;
        private System.Windows.Forms.Button btnBorrarUser;
    }
}