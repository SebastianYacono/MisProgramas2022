namespace BiblioCaxial
{
    partial class RenPrincipal
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
            this.btn_AlqRen = new System.Windows.Forms.Button();
            this.btn_AlqClose = new System.Windows.Forms.Button();
            this.dgv_RenP = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comprobante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_titulo = new System.Windows.Forms.TextBox();
            this.dtp_fec = new System.Windows.Forms.DateTimePicker();
            this.tb_monto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LimRen = new System.Windows.Forms.Button();
            this.btn_Llam = new System.Windows.Forms.Button();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.cbx_Buscar = new System.Windows.Forms.ComboBox();
            this.tb_Buscar = new System.Windows.Forms.TextBox();
            this.lbl_idCom = new System.Windows.Forms.Label();
            this.lbl_monto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RenP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AlqRen
            // 
            this.btn_AlqRen.Location = new System.Drawing.Point(423, 323);
            this.btn_AlqRen.Name = "btn_AlqRen";
            this.btn_AlqRen.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqRen.TabIndex = 8;
            this.btn_AlqRen.Text = "Renovar";
            this.btn_AlqRen.UseVisualStyleBackColor = true;
            this.btn_AlqRen.Click += new System.EventHandler(this.btn_AlqRen_Click);
            // 
            // btn_AlqClose
            // 
            this.btn_AlqClose.Location = new System.Drawing.Point(423, 371);
            this.btn_AlqClose.Name = "btn_AlqClose";
            this.btn_AlqClose.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqClose.TabIndex = 7;
            this.btn_AlqClose.Text = "Cerrar";
            this.btn_AlqClose.UseVisualStyleBackColor = true;
            this.btn_AlqClose.Click += new System.EventHandler(this.btn_AlqClose_Click);
            // 
            // dgv_RenP
            // 
            this.dgv_RenP.AllowUserToAddRows = false;
            this.dgv_RenP.AllowUserToDeleteRows = false;
            this.dgv_RenP.AllowUserToResizeColumns = false;
            this.dgv_RenP.AllowUserToResizeRows = false;
            this.dgv_RenP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RenP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Comprobante,
            this.Cliente,
            this.Fecha,
            this.Monto});
            this.dgv_RenP.Location = new System.Drawing.Point(12, 12);
            this.dgv_RenP.Name = "dgv_RenP";
            this.dgv_RenP.RowHeadersVisible = false;
            this.dgv_RenP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RenP.Size = new System.Drawing.Size(404, 323);
            this.dgv_RenP.TabIndex = 6;
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
            this.Cliente.Width = 220;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 90;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.Width = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioCaxial.Properties.Resources.AlqRe;
            this.pictureBox1.Location = new System.Drawing.Point(423, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // tb_titulo
            // 
            this.tb_titulo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tb_titulo.Enabled = false;
            this.tb_titulo.Location = new System.Drawing.Point(33, 16);
            this.tb_titulo.Name = "tb_titulo";
            this.tb_titulo.ReadOnly = true;
            this.tb_titulo.Size = new System.Drawing.Size(133, 20);
            this.tb_titulo.TabIndex = 11;
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
            // tb_monto
            // 
            this.tb_monto.Enabled = false;
            this.tb_monto.Location = new System.Drawing.Point(111, 54);
            this.tb_monto.Name = "tb_monto";
            this.tb_monto.Size = new System.Drawing.Size(104, 20);
            this.tb_monto.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LimRen);
            this.groupBox1.Controls.Add(this.btn_Llam);
            this.groupBox1.Controls.Add(this.tb_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_titulo);
            this.groupBox1.Controls.Add(this.tb_monto);
            this.groupBox1.Controls.Add(this.dtp_fec);
            this.groupBox1.Location = new System.Drawing.Point(423, 241);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 79);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Renovación";
            // 
            // btn_LimRen
            // 
            this.btn_LimRen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LimRen.Location = new System.Drawing.Point(191, 14);
            this.btn_LimRen.Name = "btn_LimRen";
            this.btn_LimRen.Size = new System.Drawing.Size(25, 23);
            this.btn_LimRen.TabIndex = 23;
            this.btn_LimRen.Text = "-";
            this.btn_LimRen.UseVisualStyleBackColor = true;
            this.btn_LimRen.Click += new System.EventHandler(this.btn_LimRen_Click);
            // 
            // btn_Llam
            // 
            this.btn_Llam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Llam.Location = new System.Drawing.Point(167, 14);
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
            this.tb_id.Location = new System.Drawing.Point(7, 16);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(24, 20);
            this.tb_id.TabIndex = 16;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 39);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Limpiar);
            this.groupBox2.Controls.Add(this.btn_Buscar);
            this.groupBox2.Controls.Add(this.cbx_Buscar);
            this.groupBox2.Controls.Add(this.tb_Buscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 341);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 72);
            this.groupBox2.TabIndex = 15;
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
            // lbl_idCom
            // 
            this.lbl_idCom.AutoSize = true;
            this.lbl_idCom.Location = new System.Drawing.Point(621, 225);
            this.lbl_idCom.Name = "lbl_idCom";
            this.lbl_idCom.Size = new System.Drawing.Size(0, 13);
            this.lbl_idCom.TabIndex = 16;
            this.lbl_idCom.Visible = false;
            // 
            // lbl_monto
            // 
            this.lbl_monto.AutoSize = true;
            this.lbl_monto.Location = new System.Drawing.Point(621, 212);
            this.lbl_monto.Name = "lbl_monto";
            this.lbl_monto.Size = new System.Drawing.Size(0, 13);
            this.lbl_monto.TabIndex = 17;
            this.lbl_monto.Visible = false;
            // 
            // RenPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 422);
            this.Controls.Add(this.lbl_monto);
            this.Controls.Add(this.lbl_idCom);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AlqRen);
            this.Controls.Add(this.btn_AlqClose);
            this.Controls.Add(this.dgv_RenP);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RenPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Renovar Alquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RenP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_AlqRen;
        private System.Windows.Forms.Button btn_AlqClose;
        private System.Windows.Forms.DataGridView dgv_RenP;
        private System.Windows.Forms.TextBox tb_titulo;
        private System.Windows.Forms.DateTimePicker dtp_fec;
        private System.Windows.Forms.TextBox tb_monto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_Buscar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.ComboBox cbx_Buscar;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comprobante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btn_Llam;
        private System.Windows.Forms.Label lbl_idCom;
        private System.Windows.Forms.Label lbl_monto;
        private System.Windows.Forms.Button btn_LimRen;
    }
}