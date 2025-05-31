using System.Drawing;

namespace AppHoja4
{
    partial class formAgregar
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
            this.lblAgregar = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.lblFechaN = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.pFechaN = new System.Windows.Forms.DateTimePicker();
            this.txtNombreUser = new System.Windows.Forms.TextBox();
            this.btnAgregarUser = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAgregar
            // 
            this.lblAgregar.AutoSize = true;
            this.lblAgregar.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar.Location = new System.Drawing.Point(292, 35);
            this.lblAgregar.Name = "lblAgregar";
            this.lblAgregar.Size = new System.Drawing.Size(234, 32);
            this.lblAgregar.TabIndex = 0;
            this.lblAgregar.Text = "Agregar Usuario";
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.Location = new System.Drawing.Point(83, 151);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(192, 23);
            this.lblNombreUser.TabIndex = 1;
            this.lblNombreUser.Text = "Nombre de Usuario";
            // 
            // lblFechaN
            // 
            this.lblFechaN.AutoSize = true;
            this.lblFechaN.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaN.Location = new System.Drawing.Point(83, 210);
            this.lblFechaN.Name = "lblFechaN";
            this.lblFechaN.Size = new System.Drawing.Size(206, 23);
            this.lblFechaN.TabIndex = 2;
            this.lblFechaN.Text = "Fecha de Nacimiento";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(83, 266);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(40, 23);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "DPI";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(83, 318);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(203, 23);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Número de Teléfono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(83, 374);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(184, 23);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(328, 271);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(256, 20);
            this.txtID.TabIndex = 7;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(328, 323);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(256, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(328, 379);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(256, 20);
            this.txtCorreo.TabIndex = 9;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // pFechaN
            // 
            this.pFechaN.Location = new System.Drawing.Point(328, 213);
            this.pFechaN.Name = "pFechaN";
            this.pFechaN.Size = new System.Drawing.Size(200, 20);
            this.pFechaN.TabIndex = 10;
            this.pFechaN.ValueChanged += new System.EventHandler(this.pFechaN_ValueChanged);
            // 
            // txtNombreUser
            // 
            this.txtNombreUser.Location = new System.Drawing.Point(328, 151);
            this.txtNombreUser.Name = "txtNombreUser";
            this.txtNombreUser.Size = new System.Drawing.Size(371, 20);
            this.txtNombreUser.TabIndex = 11;
            this.txtNombreUser.TextChanged += new System.EventHandler(this.txtNombreUser_TextChanged);
            // 
            // btnAgregarUser
            // 
            this.btnAgregarUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarUser.Location = new System.Drawing.Point(400, 441);
            this.btnAgregarUser.Name = "btnAgregarUser";
            this.btnAgregarUser.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUser.TabIndex = 12;
            this.btnAgregarUser.Text = "Agregar";
            this.btnAgregarUser.UseVisualStyleBackColor = false;
            this.btnAgregarUser.Click += new System.EventHandler(this.btnAgregarUser_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHistorial.Location = new System.Drawing.Point(692, 441);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(75, 23);
            this.btnHistorial.TabIndex = 13;
            this.btnHistorial.Text = "Recientes";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // formAgregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(829, 544);
            this.ControlBox = false;
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.btnAgregarUser);
            this.Controls.Add(this.txtNombreUser);
            this.Controls.Add(this.pFechaN);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblFechaN);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.lblAgregar);
            this.Name = "formAgregar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "formAgregar";
            this.TransparencyKey = this.BackColor;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formAgregar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAgregar;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Label lblFechaN;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker pFechaN;
        private System.Windows.Forms.TextBox txtNombreUser;
        private System.Windows.Forms.Button btnAgregarUser;
        private System.Windows.Forms.Button btnHistorial;
    }
}