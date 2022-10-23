namespace BiblioCaxial
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.SalirApp = new System.Windows.Forms.Button();
            this.Control1 = new System.Windows.Forms.TabControl();
            this.TabWelc = new System.Windows.Forms.TabPage();
            this.TabClientes = new System.Windows.Forms.TabPage();
            this.TabLibros = new System.Windows.Forms.TabPage();
            this.TabProveed = new System.Windows.Forms.TabPage();
            this.Btn_deleteProv = new System.Windows.Forms.Button();
            this.Btn_editProv = new System.Windows.Forms.Button();
            this.Btn_NewProv = new System.Windows.Forms.Button();
            this.dgv_prov = new System.Windows.Forms.DataGridView();
            this.Notificaciones = new System.Windows.Forms.GroupBox();
            this.LastBook = new System.Windows.Forms.Label();
            this.lbl_FecHor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Control1.SuspendLayout();
            this.TabProveed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prov)).BeginInit();
            this.Notificaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalirApp
            // 
            this.SalirApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalirApp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.SalirApp.Location = new System.Drawing.Point(517, 281);
            this.SalirApp.Name = "SalirApp";
            this.SalirApp.Size = new System.Drawing.Size(75, 40);
            this.SalirApp.TabIndex = 1;
            this.SalirApp.Text = "Salir";
            this.SalirApp.UseVisualStyleBackColor = true;
            this.SalirApp.Click += new System.EventHandler(this.SalirApp_Click);
            // 
            // Control1
            // 
            this.Control1.Controls.Add(this.TabWelc);
            this.Control1.Controls.Add(this.TabClientes);
            this.Control1.Controls.Add(this.TabLibros);
            this.Control1.Controls.Add(this.TabProveed);
            this.Control1.Location = new System.Drawing.Point(12, 12);
            this.Control1.Name = "Control1";
            this.Control1.SelectedIndex = 0;
            this.Control1.Size = new System.Drawing.Size(583, 259);
            this.Control1.TabIndex = 2;
            // 
            // TabWelc
            // 
            this.TabWelc.Location = new System.Drawing.Point(4, 22);
            this.TabWelc.Name = "TabWelc";
            this.TabWelc.Size = new System.Drawing.Size(575, 233);
            this.TabWelc.TabIndex = 3;
            this.TabWelc.Text = "Bienvenidos";
            this.TabWelc.UseVisualStyleBackColor = true;
            // 
            // TabClientes
            // 
            this.TabClientes.Location = new System.Drawing.Point(4, 22);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.Size = new System.Drawing.Size(575, 233);
            this.TabClientes.TabIndex = 4;
            this.TabClientes.Text = "Clientes";
            this.TabClientes.UseVisualStyleBackColor = true;
            // 
            // TabLibros
            // 
            this.TabLibros.Location = new System.Drawing.Point(4, 22);
            this.TabLibros.Name = "TabLibros";
            this.TabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.TabLibros.Size = new System.Drawing.Size(575, 233);
            this.TabLibros.TabIndex = 1;
            this.TabLibros.Text = "Libros";
            this.TabLibros.UseVisualStyleBackColor = true;
            // 
            // TabProveed
            // 
            this.TabProveed.Controls.Add(this.Btn_deleteProv);
            this.TabProveed.Controls.Add(this.Btn_editProv);
            this.TabProveed.Controls.Add(this.Btn_NewProv);
            this.TabProveed.Controls.Add(this.dgv_prov);
            this.TabProveed.Location = new System.Drawing.Point(4, 22);
            this.TabProveed.Name = "TabProveed";
            this.TabProveed.Padding = new System.Windows.Forms.Padding(3);
            this.TabProveed.Size = new System.Drawing.Size(575, 233);
            this.TabProveed.TabIndex = 0;
            this.TabProveed.Text = "Proveedores";
            this.TabProveed.UseVisualStyleBackColor = true;
            // 
            // Btn_deleteProv
            // 
            this.Btn_deleteProv.Location = new System.Drawing.Point(177, 198);
            this.Btn_deleteProv.Name = "Btn_deleteProv";
            this.Btn_deleteProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_deleteProv.TabIndex = 3;
            this.Btn_deleteProv.Text = "Eliminar";
            this.Btn_deleteProv.UseVisualStyleBackColor = true;
            this.Btn_deleteProv.Click += new System.EventHandler(this.Btn_deleteProv_Click);
            // 
            // Btn_editProv
            // 
            this.Btn_editProv.Location = new System.Drawing.Point(96, 198);
            this.Btn_editProv.Name = "Btn_editProv";
            this.Btn_editProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_editProv.TabIndex = 2;
            this.Btn_editProv.Text = "Editar";
            this.Btn_editProv.UseVisualStyleBackColor = true;
            this.Btn_editProv.Click += new System.EventHandler(this.Btn_editProv_Click);
            // 
            // Btn_NewProv
            // 
            this.Btn_NewProv.Location = new System.Drawing.Point(15, 198);
            this.Btn_NewProv.Name = "Btn_NewProv";
            this.Btn_NewProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_NewProv.TabIndex = 1;
            this.Btn_NewProv.Text = "Agregar";
            this.Btn_NewProv.UseVisualStyleBackColor = true;
            this.Btn_NewProv.Click += new System.EventHandler(this.Btn_NewProv_Click);
            // 
            // dgv_prov
            // 
            this.dgv_prov.AllowUserToAddRows = false;
            this.dgv_prov.AllowUserToDeleteRows = false;
            this.dgv_prov.AllowUserToResizeColumns = false;
            this.dgv_prov.AllowUserToResizeRows = false;
            this.dgv_prov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_prov.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProveedor,
            this.NombreProv,
            this.Telefono,
            this.Email});
            this.dgv_prov.Location = new System.Drawing.Point(6, 6);
            this.dgv_prov.Name = "dgv_prov";
            this.dgv_prov.ReadOnly = true;
            this.dgv_prov.Size = new System.Drawing.Size(563, 186);
            this.dgv_prov.TabIndex = 0;
            // 
            // Notificaciones
            // 
            this.Notificaciones.Controls.Add(this.LastBook);
            this.Notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notificaciones.Location = new System.Drawing.Point(16, 277);
            this.Notificaciones.Name = "Notificaciones";
            this.Notificaciones.Size = new System.Drawing.Size(486, 43);
            this.Notificaciones.TabIndex = 3;
            this.Notificaciones.TabStop = false;
            this.Notificaciones.Text = "Último libro ingresado";
            // 
            // LastBook
            // 
            this.LastBook.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LastBook.Location = new System.Drawing.Point(12, 16);
            this.LastBook.Name = "LastBook";
            this.LastBook.Size = new System.Drawing.Size(465, 18);
            this.LastBook.TabIndex = 0;
            // 
            // lbl_FecHor
            // 
            this.lbl_FecHor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FecHor.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_FecHor.Location = new System.Drawing.Point(396, 8);
            this.lbl_FecHor.Name = "lbl_FecHor";
            this.lbl_FecHor.Size = new System.Drawing.Size(199, 23);
            this.lbl_FecHor.TabIndex = 4;
            this.lbl_FecHor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // idProveedor
            // 
            this.idProveedor.HeaderText = "id";
            this.idProveedor.Name = "idProveedor";
            this.idProveedor.ReadOnly = true;
            this.idProveedor.Visible = false;
            // 
            // NombreProv
            // 
            this.NombreProv.HeaderText = "Nombre del Proveedor";
            this.NombreProv.Name = "NombreProv";
            this.NombreProv.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "E-Mail";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 334);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_FecHor);
            this.Controls.Add(this.Notificaciones);
            this.Controls.Add(this.Control1);
            this.Controls.Add(this.SalirApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Control1.ResumeLayout(false);
            this.TabProveed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_prov)).EndInit();
            this.Notificaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SalirApp;
        private System.Windows.Forms.TabControl Control1;
        private System.Windows.Forms.TabPage TabProveed;
        private System.Windows.Forms.TabPage TabLibros;
        private System.Windows.Forms.TabPage TabWelc;
        private System.Windows.Forms.GroupBox Notificaciones;
        private System.Windows.Forms.Label LastBook;
        private System.Windows.Forms.Button Btn_deleteProv;
        private System.Windows.Forms.Button Btn_editProv;
        private System.Windows.Forms.Button Btn_NewProv;
        private System.Windows.Forms.DataGridView dgv_prov;
        private System.Windows.Forms.TabPage TabClientes;
        private System.Windows.Forms.Label lbl_FecHor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}