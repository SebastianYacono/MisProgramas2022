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
            this.Btn_deleteClient = new System.Windows.Forms.Button();
            this.Btn_editClient = new System.Windows.Forms.Button();
            this.Btn_newClient = new System.Windows.Forms.Button();
            this.dgv_Client = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teléfono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabLibros = new System.Windows.Forms.TabPage();
            this.btn_InfoLibro = new System.Windows.Forms.Button();
            this.Btn_deleteLibro = new System.Windows.Forms.Button();
            this.Btn_editLibro = new System.Windows.Forms.Button();
            this.Btn_newLibro = new System.Windows.Forms.Button();
            this.dgv_Libros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Ubicación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabAutor = new System.Windows.Forms.TabPage();
            this.Btn_deleteAut = new System.Windows.Forms.Button();
            this.Btn_editAut = new System.Windows.Forms.Button();
            this.Btn_newAut = new System.Windows.Forms.Button();
            this.dgv_Autor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabProveed = new System.Windows.Forms.TabPage();
            this.Btn_deleteProv = new System.Windows.Forms.Button();
            this.Btn_editProv = new System.Windows.Forms.Button();
            this.Btn_newProv = new System.Windows.Forms.Button();
            this.dgv_prov = new System.Windows.Forms.DataGridView();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notificaciones = new System.Windows.Forms.GroupBox();
            this.lbl_LastBook = new System.Windows.Forms.Label();
            this.lbl_FecHor = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Control1.SuspendLayout();
            this.TabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).BeginInit();
            this.TabLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Libros)).BeginInit();
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
            this.TabClientes.Controls.Add(this.Btn_deleteClient);
            this.TabClientes.Controls.Add(this.Btn_editClient);
            this.TabClientes.Controls.Add(this.Btn_newClient);
            this.TabClientes.Controls.Add(this.dgv_Client);
            this.TabClientes.Location = new System.Drawing.Point(4, 22);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.Size = new System.Drawing.Size(575, 233);
            this.TabClientes.TabIndex = 4;
            this.TabClientes.Text = "Clientes";
            this.TabClientes.UseVisualStyleBackColor = true;
            // 
            // Btn_deleteClient
            // 
            this.Btn_deleteClient.Location = new System.Drawing.Point(177, 201);
            this.Btn_deleteClient.Name = "Btn_deleteClient";
            this.Btn_deleteClient.Size = new System.Drawing.Size(75, 23);
            this.Btn_deleteClient.TabIndex = 7;
            this.Btn_deleteClient.Text = "Eliminar";
            this.Btn_deleteClient.UseVisualStyleBackColor = true;
            this.Btn_deleteClient.Click += new System.EventHandler(this.Btn_deleteClient_Click);
            // 
            // Btn_editClient
            // 
            this.Btn_editClient.Location = new System.Drawing.Point(96, 201);
            this.Btn_editClient.Name = "Btn_editClient";
            this.Btn_editClient.Size = new System.Drawing.Size(75, 23);
            this.Btn_editClient.TabIndex = 6;
            this.Btn_editClient.Text = "Editar";
            this.Btn_editClient.UseVisualStyleBackColor = true;
            this.Btn_editClient.Click += new System.EventHandler(this.Btn_editClient_Click);
            // 
            // Btn_newClient
            // 
            this.Btn_newClient.Location = new System.Drawing.Point(15, 201);
            this.Btn_newClient.Name = "Btn_newClient";
            this.Btn_newClient.Size = new System.Drawing.Size(75, 23);
            this.Btn_newClient.TabIndex = 5;
            this.Btn_newClient.Text = "Agregar";
            this.Btn_newClient.UseVisualStyleBackColor = true;
            this.Btn_newClient.Click += new System.EventHandler(this.Btn_newClient_Click);
            // 
            // dgv_Client
            // 
            this.dgv_Client.AllowUserToAddRows = false;
            this.dgv_Client.AllowUserToDeleteRows = false;
            this.dgv_Client.AllowUserToResizeColumns = false;
            this.dgv_Client.AllowUserToResizeRows = false;
            this.dgv_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.Barrio,
            this.Teléfono,
            this.MEmail});
            this.dgv_Client.Location = new System.Drawing.Point(6, 9);
            this.dgv_Client.Name = "dgv_Client";
            this.dgv_Client.ReadOnly = true;
            this.dgv_Client.Size = new System.Drawing.Size(563, 186);
            this.dgv_Client.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "id";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.FillWeight = 70F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 70F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Dirección";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 220;
            // 
            // Barrio
            // 
            this.Barrio.FillWeight = 5F;
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            this.Barrio.Width = 140;
            // 
            // Teléfono
            // 
            this.Teléfono.FillWeight = 6F;
            this.Teléfono.HeaderText = "Teléfono";
            this.Teléfono.Name = "Teléfono";
            this.Teléfono.ReadOnly = true;
            // 
            // MEmail
            // 
            this.MEmail.HeaderText = "E-Mail";
            this.MEmail.Name = "MEmail";
            this.MEmail.ReadOnly = true;
            this.MEmail.Width = 200;
            // 
            // TabLibros
            // 
            this.TabLibros.Controls.Add(this.btn_InfoLibro);
            this.TabLibros.Controls.Add(this.Btn_deleteLibro);
            this.TabLibros.Controls.Add(this.Btn_editLibro);
            this.TabLibros.Controls.Add(this.Btn_newLibro);
            this.TabLibros.Controls.Add(this.dgv_Libros);
            this.TabLibros.Location = new System.Drawing.Point(4, 22);
            this.TabLibros.Name = "TabLibros";
            this.TabLibros.Padding = new System.Windows.Forms.Padding(3);
            this.TabLibros.Size = new System.Drawing.Size(575, 233);
            this.TabLibros.TabIndex = 1;
            this.TabLibros.Text = "Libros";
            this.TabLibros.UseVisualStyleBackColor = true;
            // 
            // btn_InfoLibro
            // 
            this.btn_InfoLibro.Location = new System.Drawing.Point(258, 201);
            this.btn_InfoLibro.Name = "btn_InfoLibro";
            this.btn_InfoLibro.Size = new System.Drawing.Size(75, 23);
            this.btn_InfoLibro.TabIndex = 8;
            this.btn_InfoLibro.Text = "+ Info";
            this.btn_InfoLibro.UseVisualStyleBackColor = true;
            this.btn_InfoLibro.Click += new System.EventHandler(this.btn_InfoLibro_Click);
            // 
            // Btn_deleteLibro
            // 
            this.Btn_deleteLibro.Location = new System.Drawing.Point(177, 201);
            this.Btn_deleteLibro.Name = "Btn_deleteLibro";
            this.Btn_deleteLibro.Size = new System.Drawing.Size(75, 23);
            this.Btn_deleteLibro.TabIndex = 7;
            this.Btn_deleteLibro.Text = "Eliminar";
            this.Btn_deleteLibro.UseVisualStyleBackColor = true;
            this.Btn_deleteLibro.Click += new System.EventHandler(this.Btn_deleteLibro_Click);
            // 
            // Btn_editLibro
            // 
            this.Btn_editLibro.Location = new System.Drawing.Point(96, 201);
            this.Btn_editLibro.Name = "Btn_editLibro";
            this.Btn_editLibro.Size = new System.Drawing.Size(75, 23);
            this.Btn_editLibro.TabIndex = 6;
            this.Btn_editLibro.Text = "Editar";
            this.Btn_editLibro.UseVisualStyleBackColor = true;
            this.Btn_editLibro.Click += new System.EventHandler(this.Btn_editLibro_Click);
            // 
            // Btn_newLibro
            // 
            this.Btn_newLibro.Location = new System.Drawing.Point(15, 201);
            this.Btn_newLibro.Name = "Btn_newLibro";
            this.Btn_newLibro.Size = new System.Drawing.Size(75, 23);
            this.Btn_newLibro.TabIndex = 5;
            this.Btn_newLibro.Text = "Agregar";
            this.Btn_newLibro.UseVisualStyleBackColor = true;
            this.Btn_newLibro.Click += new System.EventHandler(this.Btn_newLibro_Click);
            // 
            // dgv_Libros
            // 
            this.dgv_Libros.AllowUserToAddRows = false;
            this.dgv_Libros.AllowUserToDeleteRows = false;
            this.dgv_Libros.AllowUserToResizeColumns = false;
            this.dgv_Libros.AllowUserToResizeRows = false;
            this.dgv_Libros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Libros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Descripción,
            this.Idioma,
            this.Proveedor,
            this.FechaIngreso,
            this.Disponible,
            this.Ubicación,
            this.Estado});
            this.dgv_Libros.Location = new System.Drawing.Point(6, 9);
            this.dgv_Libros.Name = "dgv_Libros";
            this.dgv_Libros.ReadOnly = true;
            this.dgv_Libros.Size = new System.Drawing.Size(563, 186);
            this.dgv_Libros.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "id";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Título";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Género";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 70;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            this.Descripción.Visible = false;
            // 
            // Idioma
            // 
            this.Idioma.HeaderText = "Idioma";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            this.Idioma.Visible = false;
            // 
            // Proveedor
            // 
            this.Proveedor.HeaderText = "Proveedor";
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.ReadOnly = true;
            this.Proveedor.Visible = false;
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha Ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.ReadOnly = true;
            this.FechaIngreso.Visible = false;
            // 
            // Disponible
            // 
            this.Disponible.HeaderText = "Disp.";
            this.Disponible.Name = "Disponible";
            this.Disponible.ReadOnly = true;
            this.Disponible.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Disponible.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Disponible.Width = 40;
            // 
            // Ubicación
            // 
            this.Ubicación.HeaderText = "Ubicación";
            this.Ubicación.Name = "Ubicación";
            this.Ubicación.ReadOnly = true;
            this.Ubicación.Width = 60;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
            // 
            // TabAutor
            // 
            this.TabAutor.Controls.Add(this.Btn_deleteAut);
            this.TabAutor.Controls.Add(this.Btn_editAut);
            this.TabAutor.Controls.Add(this.Btn_newAut);
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
            // Btn_newAut
            // 
            this.Btn_newAut.Location = new System.Drawing.Point(15, 201);
            this.Btn_newAut.Name = "Btn_newAut";
            this.Btn_newAut.Size = new System.Drawing.Size(75, 23);
            this.Btn_newAut.TabIndex = 5;
            this.Btn_newAut.Text = "Agregar";
            this.Btn_newAut.UseVisualStyleBackColor = true;
            this.Btn_newAut.Click += new System.EventHandler(this.Btn_NewAut_Click);
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
            this.dataGridViewTextBoxColumn4,
            this.Genero,
            this.Alias});
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
            this.dataGridViewTextBoxColumn2.Width = 180;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 180;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "País";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Género";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            this.Genero.Width = 60;
            // 
            // Alias
            // 
            this.Alias.HeaderText = "Alias";
            this.Alias.Name = "Alias";
            this.Alias.ReadOnly = true;
            this.Alias.Visible = false;
            // 
            // TabProveed
            // 
            this.TabProveed.Controls.Add(this.Btn_deleteProv);
            this.TabProveed.Controls.Add(this.Btn_editProv);
            this.TabProveed.Controls.Add(this.Btn_newProv);
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
            // Btn_newProv
            // 
            this.Btn_newProv.Location = new System.Drawing.Point(15, 201);
            this.Btn_newProv.Name = "Btn_newProv";
            this.Btn_newProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_newProv.TabIndex = 1;
            this.Btn_newProv.Text = "Agregar";
            this.Btn_newProv.UseVisualStyleBackColor = true;
            this.Btn_newProv.Click += new System.EventHandler(this.Btn_NewProv_Click);
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
            this.Notificaciones.Controls.Add(this.lbl_LastBook);
            this.Notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notificaciones.Location = new System.Drawing.Point(16, 277);
            this.Notificaciones.Name = "Notificaciones";
            this.Notificaciones.Size = new System.Drawing.Size(486, 43);
            this.Notificaciones.TabIndex = 3;
            this.Notificaciones.TabStop = false;
            this.Notificaciones.Text = "Último libro ingresado";
            // 
            // lbl_LastBook
            // 
            this.lbl_LastBook.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_LastBook.Location = new System.Drawing.Point(12, 16);
            this.lbl_LastBook.Name = "lbl_LastBook";
            this.lbl_LastBook.Size = new System.Drawing.Size(465, 18);
            this.lbl_LastBook.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Client)).EndInit();
            this.TabLibros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Libros)).EndInit();
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
        private System.Windows.Forms.Label lbl_LastBook;
        private System.Windows.Forms.Button Btn_deleteProv;
        private System.Windows.Forms.Button Btn_editProv;
        private System.Windows.Forms.Button Btn_newProv;
        private System.Windows.Forms.DataGridView dgv_prov;
        private System.Windows.Forms.TabPage TabClientes;
        private System.Windows.Forms.Label lbl_FecHor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage TabAutor;
        private System.Windows.Forms.Button Btn_deleteClient;
        private System.Windows.Forms.Button Btn_editClient;
        private System.Windows.Forms.Button Btn_newClient;
        private System.Windows.Forms.DataGridView dgv_Client;
        private System.Windows.Forms.Button Btn_deleteLibro;
        private System.Windows.Forms.Button Btn_editLibro;
        private System.Windows.Forms.Button Btn_newLibro;
        private System.Windows.Forms.DataGridView dgv_Libros;
        private System.Windows.Forms.Button Btn_deleteAut;
        private System.Windows.Forms.Button Btn_editAut;
        private System.Windows.Forms.Button Btn_newAut;
        private System.Windows.Forms.DataGridView dgv_Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teléfono;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Disponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicación;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button btn_InfoLibro;
    }
}