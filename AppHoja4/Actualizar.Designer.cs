namespace AppHoja4
{
    partial class Actualizar
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
            this.lblActualizar = new System.Windows.Forms.Label();
            this.lblBuscarCódigoAct = new System.Windows.Forms.Label();
            this.txtBuscarUserAct = new System.Windows.Forms.TextBox();
            this.listUserData = new System.Windows.Forms.ListBox();
            this.lblUserAct = new System.Windows.Forms.Label();
            this.btnActualizarUser = new System.Windows.Forms.Button();
            this.txtField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblActualizar
            // 
            this.lblActualizar.AutoSize = true;
            this.lblActualizar.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActualizar.Location = new System.Drawing.Point(268, 37);
            this.lblActualizar.Name = "lblActualizar";
            this.lblActualizar.Size = new System.Drawing.Size(258, 32);
            this.lblActualizar.TabIndex = 2;
            this.lblActualizar.Text = "Actualizar Usuario";
            // 
            // lblBuscarCódigoAct
            // 
            this.lblBuscarCódigoAct.AutoSize = true;
            this.lblBuscarCódigoAct.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCódigoAct.Location = new System.Drawing.Point(113, 122);
            this.lblBuscarCódigoAct.Name = "lblBuscarCódigoAct";
            this.lblBuscarCódigoAct.Size = new System.Drawing.Size(259, 23);
            this.lblBuscarCódigoAct.TabIndex = 4;
            this.lblBuscarCódigoAct.Text = "Ingrese Código de Usuario";
            // 
            // txtBuscarUserAct
            // 
            this.txtBuscarUserAct.Location = new System.Drawing.Point(117, 170);
            this.txtBuscarUserAct.Name = "txtBuscarUserAct";
            this.txtBuscarUserAct.Size = new System.Drawing.Size(213, 20);
            this.txtBuscarUserAct.TabIndex = 5;
            this.txtBuscarUserAct.TextChanged += new System.EventHandler(this.txtBuscarUserAct_TextChanged);
            // 
            // listUserData
            // 
            this.listUserData.FormattingEnabled = true;
            this.listUserData.Items.AddRange(new object[] {
            "Nombre",
            "Fecha de Nacimiento",
            "Telefono",
            "Correo"});
            this.listUserData.Location = new System.Drawing.Point(117, 246);
            this.listUserData.Name = "listUserData";
            this.listUserData.Size = new System.Drawing.Size(117, 56);
            this.listUserData.TabIndex = 6;
            this.listUserData.SelectedIndexChanged += new System.EventHandler(this.listUserData_SelectedIndexChanged);
            // 
            // lblUserAct
            // 
            this.lblUserAct.AutoSize = true;
            this.lblUserAct.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserAct.Location = new System.Drawing.Point(113, 204);
            this.lblUserAct.Name = "lblUserAct";
            this.lblUserAct.Size = new System.Drawing.Size(251, 23);
            this.lblUserAct.TabIndex = 7;
            this.lblUserAct.Text = "Elija un elemento a editar";
            // 
            // btnActualizarUser
            // 
            this.btnActualizarUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarUser.Location = new System.Drawing.Point(117, 325);
            this.btnActualizarUser.Name = "btnActualizarUser";
            this.btnActualizarUser.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarUser.TabIndex = 14;
            this.btnActualizarUser.Text = "Actualizar";
            this.btnActualizarUser.UseVisualStyleBackColor = false;
            this.btnActualizarUser.Click += new System.EventHandler(this.btnActualizarUser_Click);
            // 
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(313, 246);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(213, 20);
            this.txtField.TabIndex = 15;
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(829, 544);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.btnActualizarUser);
            this.Controls.Add(this.lblUserAct);
            this.Controls.Add(this.listUserData);
            this.Controls.Add(this.txtBuscarUserAct);
            this.Controls.Add(this.lblBuscarCódigoAct);
            this.Controls.Add(this.lblActualizar);
            this.Name = "Actualizar";
            this.Text = "Actualizar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActualizar;
        private System.Windows.Forms.Label lblBuscarCódigoAct;
        private System.Windows.Forms.TextBox txtBuscarUserAct;
        private System.Windows.Forms.ListBox listUserData;
        private System.Windows.Forms.Label lblUserAct;
        private System.Windows.Forms.Button btnActualizarUser;
        private System.Windows.Forms.TextBox txtField;
    }
}