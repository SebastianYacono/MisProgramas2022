namespace BiblioCaxial
{
    partial class DevPrincipal
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbx_Buscar = new System.Windows.Forms.ComboBox();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.btn_AlqDev = new System.Windows.Forms.Button();
            this.btn_AlqClose = new System.Windows.Forms.Button();
            this.dgv_DevP = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LimDev = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.tb_demora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_fecDev = new System.Windows.Forms.DateTimePicker();
            this.btn_Llam = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.dtp_fec = new System.Windows.Forms.DateTimePicker();
            this.lbl_idCom = new System.Windows.Forms.Label();
            this.lbl_monto = new System.Windows.Forms.Label();
            this.lbl_idLibro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DevP)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Limpiar);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.cbx_Buscar);
            this.groupBox2.Controls.Add(this.tb_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 378);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 72);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar";
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(314, 44);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(84, 23);
            this.Btn_Limpiar.TabIndex = 19;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Location = new System.Drawing.Point(182, 44);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(130, 23);
            this.btn_Buscar.TabIndex = 18;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = true;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // cbx_Buscar
            // 
            this.cbx_Buscar.FormattingEnabled = true;
            this.cbx_Buscar.Items.AddRange(new object[] {
            "Comprobante",
            "Libro"});
            this.cbx_Buscar.Location = new System.Drawing.Point(6, 45);
            this.cbx_Buscar.Name = "cbx_Buscar";
            this.cbx_Buscar.Size = new System.Drawing.Size(174, 21);
            this.cbx_Buscar.TabIndex = 17;
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Location = new System.Drawing.Point(6, 17);
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(392, 20);
            this.tb_Buscar.TabIndex = 16;
            // 
            // btn_AlqDev
            // 
            this.btn_AlqDev.Location = new System.Drawing.Point(423, 361);
            this.btn_AlqDev.Name = "btn_AlqDev";
            this.btn_AlqDev.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqDev.TabIndex = 18;
            this.btn_AlqDev.Text = "Devolver";
            this.btn_AlqDev.UseVisualStyleBackColor = true;
            this.btn_AlqDev.Click += new System.EventHandler(this.btn_AlqDev_Click);
            // 
            // btn_AlqClose
            // 
            this.btn_AlqClose.Location = new System.Drawing.Point(423, 409);
            this.btn_AlqClose.Name = "btn_AlqClose";
            this.btn_AlqClose.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqClose.TabIndex = 17;
            this.btn_AlqClose.Text = "Cerrar";
            this.btn_AlqClose.UseVisualStyleBackColor = true;
            this.btn_AlqClose.Click += new System.EventHandler(this.btn_AlqClose_Click);
            // 
            // dgv_DevP
            // 
            this.dgv_DevP.AllowUserToAddRows = false;
            this.dgv_DevP.AllowUserToDeleteRows = false;
            this.dgv_DevP.AllowUserToResizeColumns = false;
            this.dgv_DevP.AllowUserToResizeRows = false;
            this.dgv_DevP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DevP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Comprobante,
            this.Cliente,
            this.Fecha,
            this.Monto,
            this.idLibro});
            this.dgv_DevP.Location = new System.Drawing.Point(12, 12);
            this.dgv_DevP.Name = "dgv_DevP";
            this.dgv_DevP.RowHeadersVisible = false;
            this.dgv_DevP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DevP.Size = new System.Drawing.Size(404, 360);
            this.dgv_DevP.TabIndex = 16;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 40;
            // 
            // Comprobante
            // 
            this.Comprobante.HeaderText = "Comp.";
            this.Comprobante.Name = "Comprobante";
            this.Comprobante.Width = 40;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Título";
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 270;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Devolver el";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 90;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Visible = false;
            this.Monto.Width = 50;
            // 
            // idLibro
            // 
            this.idLibro.HeaderText = "idLibro";
            this.idLibro.Name = "idLibro";
            this.idLibro.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LimDev);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.tb_demora);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtp_fecDev);
            this.groupBox1.Controls.Add(this.btn_Llam);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_titulo);
            this.groupBox1.Controls.Add(this.tb_monto);
            this.groupBox1.Controls.Add(this.dtp_fec);
            this.groupBox1.Location = new System.Drawing.Point(423, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 118);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devolución";
            // 
            // btn_LimDev
            // 
            this.btn_LimDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimDev.Location = new System.Drawing.Point(190, 14);
            this.btn_LimDev.Name = "btn_LimDev";
            this.btn_LimDev.Size = new System.Drawing.Size(25, 23);
            this.btn_LimDev.TabIndex = 22;
            this.btn_LimDev.Text = "-";
            this.btn_LimDev.UseVisualStyleBackColor = true;
            this.btn_LimDev.Click += new System.EventHandler(this.btn_LimDev_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(5, 77);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(60, 13);
            this.lbl.TabIndex = 21;
            this.lbl.Text = "Días tarde:";
            // 
            // tb_demora
            // 
            this.tb_demora.Enabled = false;
            this.tb_demora.Location = new System.Drawing.Point(6, 91);
            this.tb_demora.Name = "tb_demora";
            this.tb_demora.Size = new System.Drawing.Size(104, 20);
            this.tb_demora.TabIndex = 20;
            this.tb_demora.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Se devuelve el:";
            // 
            // dtp_fecDev
            // 
            this.dtp_fecDev.Enabled = false;
            this.dtp_fecDev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecDev.Location = new System.Drawing.Point(113, 54);
            this.dtp_fecDev.Name = "dtp_fecDev";
            this.dtp_fecDev.Size = new System.Drawing.Size(100, 20);
            this.dtp_fecDev.TabIndex = 18;
            // 
            // btn_Llam
            // 
            this.btn_Llam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Llam.Location = new System.Drawing.Point(166, 14);
            this.btn_Llam.Name = "btn_Llam";
            this.btn_Llam.Size = new System.Drawing.Size(25, 23);
            this.btn_Llam.TabIndex = 17;
            this.btn_Llam.Text = "+";
            this.btn_Llam.UseVisualStyleBackColor = true;
            this.btn_Llam.Click += new System.EventHandler(this.btn_Llam_Click);
            // 
            // tb_id
            // 
            this.tb_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(6, 16);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(29, 20);
            this.tb_id.TabIndex = 16;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Monto a agregar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Finaliza el:";
            // 
            // tb_titulo
            // 
            this.tb_titulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_titulo.Enabled = false;
            this.tb_titulo.Location = new System.Drawing.Point(37, 16);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.ReadOnly = true;
            this.tb_titulo.Size = new System.Drawing.Size(127, 20);
            this.tb_titulo.TabIndex = 11;
            // 
            // tb_monto
            // 
            this.tb_monto.Enabled = false;
            this.tb_monto.Location = new System.Drawing.Point(111, 91);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(104, 20);
            this.tb_monto.TabIndex = 13;
            this.tb_monto.Text = "0";
            this.tb_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtp_fec
            // 
            this.dtp_fec.Enabled = false;
            this.dtp_fec.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fec.Location = new System.Drawing.Point(6, 54);
            this.dtp_fec.Name = "dtp_fec";
            this.dtp_fec.Size = new System.Drawing.Size(100, 20);
            this.dtp_fec.TabIndex = 12;
            // 
            // lbl_idCom
            // 
            this.lbl_idCom.AutoSize = true;
            this.lbl_idCom.Location = new System.Drawing.Point(651, 224);
            this.lbl_idCom.Name = "lbl_idCom";
            this.lbl_idCom.Size = new System.Drawing.Size(0, 13);
            this.lbl_idCom.TabIndex = 22;
            this.lbl_idCom.Visible = false;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Location = new System.Drawing.Point(637, 224);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(0, 13);
            this.lbl_monto.TabIndex = 23;
            this.lbl_monto.Visible = false;
            // 
            // lbl_idLibro
            // 
            this.lbl_idLibro.AutoSize = true;
            this.lbl_idLibro.Location = new System.Drawing.Point(651, 172);
            this.lbl_idLibro.Name = "lbl_idLibro";
            this.lbl_idLibro.Size = new System.Drawing.Size(0, 13);
            this.lbl_idLibro.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioCaxial.Properties.Resources.AlqDe;
            this.pictureBox1.Location = new System.Drawing.Point(423, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // DevPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 460);
            this.Controls.Add(this.lbl_idLibro);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.lbl_idCom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AlqDev);
            this.Controls.Add(this.btn_AlqClose);
            this.Controls.Add(this.dgv_DevP);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolver Alquiler";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DevP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbx_Buscar;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AlqDev;
        private System.Windows.Forms.Button btn_AlqClose;
        private System.Windows.Forms.DataGridView dgv_DevP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Llam;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.DateTimePicker dtp_fec;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox tb_demora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_fecDev;
        private System.Windows.Forms.Label lbl_idCom;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLibro;
        private System.Windows.Forms.Label lbl_idLibro;
        private System.Windows.Forms.Button btn_LimDev;
    }
}