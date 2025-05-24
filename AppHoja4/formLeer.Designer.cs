namespace AppHoja4
{
    partial class formLeer
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
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarUser = new System.Windows.Forms.TextBox();
            this.lblBuscarCódigo = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.btnBuscarUser = new System.Windows.Forms.Button();
            this.dataUser = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(302, 37);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(218, 32);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar Usuario";
            // 
            // txtBuscarUser
            // 
            this.txtBuscarUser.Location = new System.Drawing.Point(142, 169);
            this.txtBuscarUser.Name = "txtBuscarUser";
            this.txtBuscarUser.Size = new System.Drawing.Size(213, 20);
            this.txtBuscarUser.TabIndex = 2;
            this.txtBuscarUser.TextChanged += new System.EventHandler(this.txtBuscarUser_TextChanged);
            // 
            // lblBuscarCódigo
            // 
            this.lblBuscarCódigo.AutoSize = true;
            this.lblBuscarCódigo.Font = new System.Drawing.Font("Lucida Sans Unicode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCódigo.Location = new System.Drawing.Point(138, 113);
            this.lblBuscarCódigo.Name = "lblBuscarCódigo";
            this.lblBuscarCódigo.Size = new System.Drawing.Size(259, 23);
            this.lblBuscarCódigo.TabIndex = 3;
            this.lblBuscarCódigo.Text = "Ingrese Código de Usuario";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // btnBuscarUser
            // 
            this.btnBuscarUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscarUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarUser.Location = new System.Drawing.Point(142, 218);
            this.btnBuscarUser.Name = "btnBuscarUser";
            this.btnBuscarUser.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarUser.TabIndex = 14;
            this.btnBuscarUser.Text = "Buscar";
            this.btnBuscarUser.UseVisualStyleBackColor = false;
            this.btnBuscarUser.Click += new System.EventHandler(this.btnBuscarUser_Click);
            // 
            // dataUser
            // 
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Location = new System.Drawing.Point(430, 169);
            this.dataUser.Name = "dataUser";
            this.dataUser.Size = new System.Drawing.Size(291, 182);
            this.dataUser.TabIndex = 15;
            this.dataUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // formLeer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(829, 544);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.btnBuscarUser);
            this.Controls.Add(this.lblBuscarCódigo);
            this.Controls.Add(this.txtBuscarUser);
            this.Controls.Add(this.lblBuscar);
            this.Name = "formLeer";
            this.Text = "formLeer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarUser;
        private System.Windows.Forms.Label lblBuscarCódigo;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button btnBuscarUser;
        private System.Windows.Forms.DataGridView dataUser;
    }
}