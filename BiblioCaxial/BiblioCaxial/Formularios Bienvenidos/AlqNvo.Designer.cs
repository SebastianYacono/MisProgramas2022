namespace BiblioCaxial
{
    partial class AlqNvo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_clientAlq = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbx_Buscar = new System.Windows.Forms.ComboBox();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.dgv_LibAlq = new System.Windows.Forms.DataGridView();
            this.idLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.tb_id3 = new System.Windows.Forms.TextBox();
            this.tb_id2 = new System.Windows.Forms.TextBox();
            this.tb_id1 = new System.Windows.Forms.TextBox();
            this.dtp_fec3 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fec2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fec1 = new System.Windows.Forms.DateTimePicker();
            this.tb_lib3 = new System.Windows.Forms.TextBox();
            this.tb_lib2 = new System.Windows.Forms.TextBox();
            this.tb_lib1 = new System.Windows.Forms.TextBox();
            this.rb_lib3 = new System.Windows.Forms.RadioButton();
            this.rb_lib2 = new System.Windows.Forms.RadioButton();
            this.rb_lib1 = new System.Windows.Forms.RadioButton();
            this.bt_mas3 = new System.Windows.Forms.Button();
            this.bt_mas2 = new System.Windows.Forms.Button();
            this.bt_mas1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tb_compr = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tb_fecHoy = new System.Windows.Forms.TextBox();
            this.btn_Alquilar = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tb_Monto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LibAlq)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_clientAlq);
            this.groupBox1.Location = new System.Drawing.Point(12, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 52);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // cbx_clientAlq
            // 
            this.cbx_clientAlq.FormattingEnabled = true;
            this.cbx_clientAlq.Location = new System.Drawing.Point(8, 19);
            this.cbx_clientAlq.Name = "cbx_clientAlq";
            this.cbx_clientAlq.Size = new System.Drawing.Size(444, 21);
            this.cbx_clientAlq.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbx_Buscar);
            this.groupBox2.Controls.Add(this.btn_Borrar);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.tb_Buscar);
            this.groupBox2.Controls.Add(this.dgv_LibAlq);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Libro:";
            // 
            // cbx_Buscar
            // 
            this.cbx_Buscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_Buscar.FormattingEnabled = true;
            this.cbx_Buscar.Items.AddRange(new object[] {
            "Autor",
            "Título"});
            this.cbx_Buscar.Location = new System.Drawing.Point(202, 19);
            this.cbx_Buscar.Name = "cbx_Buscar";
            this.cbx_Buscar.Size = new System.Drawing.Size(96, 21);
            this.cbx_Buscar.TabIndex = 4;
            this.cbx_Buscar.TabStop = false;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(377, 18);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrar.TabIndex = 3;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(302, 18);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_Buscar.TabIndex = 2;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Location = new System.Drawing.Point(8, 19);
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(189, 20);
            this.tb_Buscar.TabIndex = 1;
            // 
            // dgv_LibAlq
            // 
            this.dgv_LibAlq.AllowUserToAddRows = false;
            this.dgv_LibAlq.AllowUserToDeleteRows = false;
            this.dgv_LibAlq.AllowUserToResizeColumns = false;
            this.dgv_LibAlq.AllowUserToResizeRows = false;
            this.dgv_LibAlq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LibAlq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLibro,
            this.Titulo,
            this.Autor});
            this.dgv_LibAlq.Location = new System.Drawing.Point(8, 47);
            this.dgv_LibAlq.Name = "dgv_LibAlq";
            this.dgv_LibAlq.ReadOnly = true;
            this.dgv_LibAlq.RowHeadersVisible = false;
            this.dgv_LibAlq.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LibAlq.Size = new System.Drawing.Size(444, 94);
            this.dgv_LibAlq.TabIndex = 0;
            // 
            // idLibro
            // 
            this.idLibro.HeaderText = "Id";
            this.idLibro.Name = "idLibro";
            this.idLibro.ReadOnly = true;
            this.idLibro.Visible = false;
            this.idLibro.Width = 10;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            this.Titulo.Width = 290;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            this.Autor.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cant. de libros:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_limpiar);
            this.groupBox3.Controls.Add(this.tb_id3);
            this.groupBox3.Controls.Add(this.tb_id2);
            this.groupBox3.Controls.Add(this.tb_id1);
            this.groupBox3.Controls.Add(this.dtp_fec3);
            this.groupBox3.Controls.Add(this.dtp_fec2);
            this.groupBox3.Controls.Add(this.dtp_fec1);
            this.groupBox3.Controls.Add(this.tb_lib3);
            this.groupBox3.Controls.Add(this.tb_lib2);
            this.groupBox3.Controls.Add(this.tb_lib1);
            this.groupBox3.Controls.Add(this.rb_lib3);
            this.groupBox3.Controls.Add(this.rb_lib2);
            this.groupBox3.Controls.Add(this.rb_lib1);
            this.groupBox3.Controls.Add(this.bt_mas3);
            this.groupBox3.Controls.Add(this.bt_mas2);
            this.groupBox3.Controls.Add(this.bt_mas1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 338);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 134);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Libro:";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(217, 15);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(97, 23);
            this.btn_limpiar.TabIndex = 20;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // tb_id3
            // 
            this.tb_id3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_id3.Enabled = false;
            this.tb_id3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id3.Location = new System.Drawing.Point(3, 103);
            this.tb_id3.Name = "tb_id3";
            this.tb_id3.ReadOnly = true;
            this.tb_id3.Size = new System.Drawing.Size(40, 20);
            this.tb_id3.TabIndex = 19;
            this.tb_id3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_id2
            // 
            this.tb_id2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_id2.Enabled = false;
            this.tb_id2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id2.Location = new System.Drawing.Point(3, 74);
            this.tb_id2.Name = "tb_id2";
            this.tb_id2.ReadOnly = true;
            this.tb_id2.Size = new System.Drawing.Size(40, 20);
            this.tb_id2.TabIndex = 18;
            this.tb_id2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_id1
            // 
            this.tb_id1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_id1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id1.Location = new System.Drawing.Point(3, 45);
            this.tb_id1.Name = "tb_id1";
            this.tb_id1.ReadOnly = true;
            this.tb_id1.Size = new System.Drawing.Size(40, 20);
            this.tb_id1.TabIndex = 17;
            this.tb_id1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtp_fec3
            // 
            this.dtp_fec3.Enabled = false;
            this.dtp_fec3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fec3.Location = new System.Drawing.Point(179, 103);
            this.dtp_fec3.Name = "dtp_fec3";
            this.dtp_fec3.Size = new System.Drawing.Size(83, 20);
            this.dtp_fec3.TabIndex = 16;
            // 
            // dtp_fec2
            // 
            this.dtp_fec2.Enabled = false;
            this.dtp_fec2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fec2.Location = new System.Drawing.Point(179, 75);
            this.dtp_fec2.Name = "dtp_fec2";
            this.dtp_fec2.Size = new System.Drawing.Size(83, 20);
            this.dtp_fec2.TabIndex = 15;
            // 
            // dtp_fec1
            // 
            this.dtp_fec1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fec1.Location = new System.Drawing.Point(179, 46);
            this.dtp_fec1.Name = "dtp_fec1";
            this.dtp_fec1.Size = new System.Drawing.Size(83, 20);
            this.dtp_fec1.TabIndex = 14;
            // 
            // tb_lib3
            // 
            this.tb_lib3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_lib3.Enabled = false;
            this.tb_lib3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lib3.Location = new System.Drawing.Point(44, 103);
            this.tb_lib3.Name = "tb_lib3";
            this.tb_lib3.ReadOnly = true;
            this.tb_lib3.Size = new System.Drawing.Size(129, 20);
            this.tb_lib3.TabIndex = 12;
            this.tb_lib3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_lib2
            // 
            this.tb_lib2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_lib2.Enabled = false;
            this.tb_lib2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lib2.Location = new System.Drawing.Point(44, 74);
            this.tb_lib2.Name = "tb_lib2";
            this.tb_lib2.ReadOnly = true;
            this.tb_lib2.Size = new System.Drawing.Size(129, 20);
            this.tb_lib2.TabIndex = 11;
            this.tb_lib2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_lib1
            // 
            this.tb_lib1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_lib1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_lib1.Location = new System.Drawing.Point(44, 45);
            this.tb_lib1.Name = "tb_lib1";
            this.tb_lib1.ReadOnly = true;
            this.tb_lib1.Size = new System.Drawing.Size(129, 20);
            this.tb_lib1.TabIndex = 1;
            this.tb_lib1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rb_lib3
            // 
            this.rb_lib3.AutoSize = true;
            this.rb_lib3.Location = new System.Drawing.Point(180, 19);
            this.rb_lib3.Name = "rb_lib3";
            this.rb_lib3.Size = new System.Drawing.Size(31, 17);
            this.rb_lib3.TabIndex = 10;
            this.rb_lib3.Text = "3";
            this.rb_lib3.UseVisualStyleBackColor = true;
            this.rb_lib3.CheckedChanged += new System.EventHandler(this.rb_lib3_CheckedChanged);
            // 
            // rb_lib2
            // 
            this.rb_lib2.AutoSize = true;
            this.rb_lib2.Location = new System.Drawing.Point(136, 19);
            this.rb_lib2.Name = "rb_lib2";
            this.rb_lib2.Size = new System.Drawing.Size(31, 17);
            this.rb_lib2.TabIndex = 9;
            this.rb_lib2.Text = "2";
            this.rb_lib2.UseVisualStyleBackColor = true;
            this.rb_lib2.CheckedChanged += new System.EventHandler(this.rb_lib2_CheckedChanged);
            // 
            // rb_lib1
            // 
            this.rb_lib1.AutoSize = true;
            this.rb_lib1.Checked = true;
            this.rb_lib1.Location = new System.Drawing.Point(92, 19);
            this.rb_lib1.Name = "rb_lib1";
            this.rb_lib1.Size = new System.Drawing.Size(31, 17);
            this.rb_lib1.TabIndex = 5;
            this.rb_lib1.TabStop = true;
            this.rb_lib1.Text = "1";
            this.rb_lib1.UseVisualStyleBackColor = true;
            this.rb_lib1.CheckedChanged += new System.EventHandler(this.rb_lib1_CheckedChanged);
            // 
            // bt_mas3
            // 
            this.bt_mas3.Enabled = false;
            this.bt_mas3.Location = new System.Drawing.Point(268, 102);
            this.bt_mas3.Name = "bt_mas3";
            this.bt_mas3.Size = new System.Drawing.Size(46, 23);
            this.bt_mas3.TabIndex = 8;
            this.bt_mas3.Text = "Añadir";
            this.bt_mas3.UseVisualStyleBackColor = true;
            this.bt_mas3.Click += new System.EventHandler(this.bt_mas3_Click);
            // 
            // bt_mas2
            // 
            this.bt_mas2.Enabled = false;
            this.bt_mas2.Location = new System.Drawing.Point(268, 73);
            this.bt_mas2.Name = "bt_mas2";
            this.bt_mas2.Size = new System.Drawing.Size(46, 23);
            this.bt_mas2.TabIndex = 7;
            this.bt_mas2.Text = "Añadir";
            this.bt_mas2.UseVisualStyleBackColor = true;
            this.bt_mas2.Click += new System.EventHandler(this.bt_mas2_Click);
            // 
            // bt_mas1
            // 
            this.bt_mas1.Location = new System.Drawing.Point(268, 44);
            this.bt_mas1.Name = "bt_mas1";
            this.bt_mas1.Size = new System.Drawing.Size(46, 23);
            this.bt_mas1.TabIndex = 5;
            this.bt_mas1.Text = "Añadir";
            this.bt_mas1.UseVisualStyleBackColor = true;
            this.bt_mas1.Click += new System.EventHandler(this.bt_mas1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tb_compr);
            this.groupBox4.Location = new System.Drawing.Point(12, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 52);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Nro de comprobante";
            // 
            // tb_compr
            // 
            this.tb_compr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_compr.Enabled = false;
            this.tb_compr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_compr.Location = new System.Drawing.Point(8, 19);
            this.tb_compr.Name = "tb_compr";
            this.tb_compr.Size = new System.Drawing.Size(208, 20);
            this.tb_compr.TabIndex = 0;
            this.tb_compr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tb_fecHoy);
            this.groupBox5.Location = new System.Drawing.Point(251, 75);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(222, 52);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fecha:";
            // 
            // tb_fecHoy
            // 
            this.tb_fecHoy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_fecHoy.Enabled = false;
            this.tb_fecHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_fecHoy.Location = new System.Drawing.Point(6, 19);
            this.tb_fecHoy.Name = "tb_fecHoy";
            this.tb_fecHoy.Size = new System.Drawing.Size(207, 20);
            this.tb_fecHoy.TabIndex = 0;
            this.tb_fecHoy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_Alquilar
            // 
            this.btn_Alquilar.Enabled = false;
            this.btn_Alquilar.Location = new System.Drawing.Point(339, 396);
            this.btn_Alquilar.Name = "btn_Alquilar";
            this.btn_Alquilar.Size = new System.Drawing.Size(134, 49);
            this.btn_Alquilar.TabIndex = 5;
            this.btn_Alquilar.Text = "Alquilar";
            this.btn_Alquilar.UseVisualStyleBackColor = true;
            this.btn_Alquilar.Click += new System.EventHandler(this.btn_Alquilar_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(339, 448);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(134, 23);
            this.btn_Close.TabIndex = 13;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tb_Monto);
            this.groupBox6.Location = new System.Drawing.Point(339, 338);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(134, 55);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Monto:";
            // 
            // tb_Monto
            // 
            this.tb_Monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Monto.Location = new System.Drawing.Point(4, 18);
            this.tb_Monto.Name = "tb_Monto";
            this.tb_Monto.Size = new System.Drawing.Size(126, 29);
            this.tb_Monto.TabIndex = 0;
            this.tb_Monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioCaxial.Properties.Resources.AlqNvo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // AlqNvo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 480);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_Alquilar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlqNvo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo alquiler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LibAlq)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_clientAlq;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_mas1;
        private System.Windows.Forms.DataGridView dgv_LibAlq;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tb_compr;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tb_fecHoy;
        private System.Windows.Forms.TextBox tb_lib2;
        private System.Windows.Forms.TextBox tb_lib1;
        private System.Windows.Forms.RadioButton rb_lib3;
        private System.Windows.Forms.RadioButton rb_lib2;
        private System.Windows.Forms.RadioButton rb_lib1;
        private System.Windows.Forms.Button bt_mas3;
        private System.Windows.Forms.Button bt_mas2;
        private System.Windows.Forms.TextBox tb_lib3;
        private System.Windows.Forms.Button btn_Alquilar;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.ComboBox cbx_Buscar;
        private System.Windows.Forms.DateTimePicker dtp_fec3;
        private System.Windows.Forms.DateTimePicker dtp_fec2;
        private System.Windows.Forms.DateTimePicker dtp_fec1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tb_Monto;
        private System.Windows.Forms.TextBox tb_id3;
        private System.Windows.Forms.TextBox tb_id2;
        private System.Windows.Forms.TextBox tb_id1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}