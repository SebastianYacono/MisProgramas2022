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
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabLibros = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabAutor = new System.Windows.Forms.TabPage();
            this.Btn_deleteAut = new System.Windows.Forms.Button();
            this.Btn_editAut = new System.Windows.Forms.Button();
            this.Btn_NewAut = new System.Windows.Forms.Button();
            this.dgv_Autor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabProveed = new System.Windows.Forms.TabPage();
            this.Btn_deleteProv = new System.Windows.Forms.Button();
            this.Btn_editProv = new System.Windows.Forms.Button();
            this.Btn_NewProv = new System.Windows.Forms.Button();
            this.dgv_prov = new System.Windows.Forms.DataGridView();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notificaciones = new System.Windows.Forms.GroupBox();
            this.LastBook = new System.Windows.Forms.Label();
            this.lbl_FecHor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Control1.SuspendLayout();
            this.TabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.TabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TabAutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autor)).BeginInit();
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
            this.Control1.Controls.Add(this.TabAutor);
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
            this.TabClientes.Controls.Add(this.button7);
            this.TabClientes.Controls.Add(this.button8);
            this.TabClientes.Controls.Add(this.button9);
            this.TabClientes.Controls.Add(this.dataGridView3);
            this.TabClientes.Location = new System.Drawing.Point(4, 22);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.Size = new System.Drawing.Size(575, 233);
            this.TabClientes.TabIndex = 4;
            this.TabClientes.Text = "Clientes";
            this.TabClientes.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(177, 201);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Eliminar";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(96, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Editar";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(15, 201);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 5;
            this.button9.Text = "Agregar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dataGridView3.Location = new System.Drawing.Point(6, 9);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(563, 186);
            this.dataGridView3.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Nombre del Proveedor";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // TabLibros
            // 
            this.TabLibros.Controls.Add(this.button4);
            this.TabLibros.Controls.Add(this.button5);
            this.TabLibros.Controls.Add(this.button6);
            this.TabLibros.Controls.Add(this.dataGridView2);
            this.TabLibros.Location = new System.Drawing.Point(4, 22);
            this.TabLibros.Name = "TabLibros";
            this.TabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.TabLibros.Size = new System.Drawing.Size(575, 233);
            this.TabLibros.TabIndex = 1;
            this.TabLibros.Text = "Libros";
            this.TabLibros.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(177, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(96, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Editar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Agregar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView2.Location = new System.Drawing.Point(6, 9);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(563, 186);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Nombre del Proveedor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Teléfono";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "E-Mail";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // TabAutor
            // 
            this.TabAutor.Controls.Add(this.Btn_deleteAut);
            this.TabAutor.Controls.Add(this.Btn_editAut);
            this.TabAutor.Controls.Add(this.Btn_NewAut);
            this.TabAutor.Controls.Add(this.dgv_Autor);
            this.TabAutor.Location = new System.Drawing.Point(4, 22);
            this.TabAutor.Name = "TabAutor";
            this.TabAutor.Padding = new System.Windows.Forms.Padding(3);
            this.TabAutor.Size = new System.Drawing.Size(575, 233);
            this.TabAutor.TabIndex = 5;
            this.TabAutor.Text = "Autores";
            this.TabAutor.UseVisualStyleBackColor = true;
            // 
            // Btn_deleteAut
            // 
            this.Btn_deleteAut.Location = new System.Drawing.Point(177, 201);
            this.Btn_deleteAut.Name = "Btn_deleteAut";
            this.Btn_deleteAut.Size = new System.Drawing.Size(75, 23);
            this.Btn_deleteAut.TabIndex = 7;
            this.Btn_deleteAut.Text = "Eliminar";
            this.Btn_deleteAut.UseVisualStyleBackColor = true;
            this.Btn_deleteAut.Click += new System.EventHandler(this.Btn_deleteAut_Click);
            // 
            // Btn_editAut
            // 
            this.Btn_editAut.Location = new System.Drawing.Point(96, 201);
            this.Btn_editAut.Name = "Btn_editAut";
            this.Btn_editAut.Size = new System.Drawing.Size(75, 23);
            this.Btn_editAut.TabIndex = 6;
            this.Btn_editAut.Text = "Editar";
            this.Btn_editAut.UseVisualStyleBackColor = true;
            this.Btn_editAut.Click += new System.EventHandler(this.Btn_editAut_Click);
            // 
            // Btn_NewAut
            // 
            this.Btn_NewAut.Location = new System.Drawing.Point(15, 201);
            this.Btn_NewAut.Name = "Btn_NewAut";
            this.Btn_NewAut.Size = new System.Drawing.Size(75, 23);
            this.Btn_NewAut.TabIndex = 5;
            this.Btn_NewAut.Text = "Agregar";
            this.Btn_NewAut.UseVisualStyleBackColor = true;
            this.Btn_NewAut.Click += new System.EventHandler(this.Btn_NewAut_Click);
            // 
            // dgv_Autor
            // 
            this.dgv_Autor.AllowUserToAddRows = false;
            this.dgv_Autor.AllowUserToDeleteRows = false;
            this.dgv_Autor.AllowUserToResizeColumns = false;
            this.dgv_Autor.AllowUserToResizeRows = false;
            this.dgv_Autor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Autor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_Autor.Location = new System.Drawing.Point(6, 9);
            this.dgv_Autor.Name = "dgv_Autor";
            this.dgv_Autor.ReadOnly = true;
            this.dgv_Autor.Size = new System.Drawing.Size(563, 186);
            this.dgv_Autor.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 210;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 210;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "País";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.Btn_deleteProv.Location = new System.Drawing.Point(177, 201);
            this.Btn_deleteProv.Name = "Btn_deleteProv";
            this.Btn_deleteProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_deleteProv.TabIndex = 3;
            this.Btn_deleteProv.Text = "Eliminar";
            this.Btn_deleteProv.UseVisualStyleBackColor = true;
            this.Btn_deleteProv.Click += new System.EventHandler(this.Btn_deleteProv_Click);
            // 
            // Btn_editProv
            // 
            this.Btn_editProv.Location = new System.Drawing.Point(96, 201);
            this.Btn_editProv.Name = "Btn_editProv";
            this.Btn_editProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_editProv.TabIndex = 2;
            this.Btn_editProv.Text = "Editar";
            this.Btn_editProv.UseVisualStyleBackColor = true;
            this.Btn_editProv.Click += new System.EventHandler(this.Btn_editProv_Click);
            // 
            // Btn_NewProv
            // 
            this.Btn_NewProv.Location = new System.Drawing.Point(15, 201);
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
            this.dgv_prov.Location = new System.Drawing.Point(6, 9);
            this.dgv_prov.Name = "dgv_prov";
            this.dgv_prov.ReadOnly = true;
            this.dgv_prov.Size = new System.Drawing.Size(563, 186);
            this.dgv_prov.TabIndex = 0;
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
            this.NombreProv.Width = 200;
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
            this.Email.Width = 220;
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 334);
            this.Controls.Add(this.lbl_FecHor);
            this.Controls.Add(this.Notificaciones);
            this.Controls.Add(this.Control1);
            this.Controls.Add(this.SalirApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            this.Control1.ResumeLayout(false);
            this.TabClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.TabLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TabAutor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Autor)).EndInit();
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
        private System.Windows.Forms.TabPage TabAutor;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button Btn_deleteAut;
        private System.Windows.Forms.Button Btn_editAut;
        private System.Windows.Forms.Button Btn_NewAut;
        private System.Windows.Forms.DataGridView dgv_Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}