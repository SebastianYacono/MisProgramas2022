namespace BiblioCaxial
{
    partial class AlqInfo
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
            this.tb_Cerrar = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FecDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Fecha = new System.Windows.Forms.TextBox();
            this.tb_Mont = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_client = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Comp = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Cerrar
            // 
            this.tb_Cerrar.Location = new System.Drawing.Point(12, 263);
            this.tb_Cerrar.Name = "tb_Cerrar";
            this.tb_Cerrar.Size = new System.Drawing.Size(393, 23);
            this.tb_Cerrar.TabIndex = 0;
            this.tb_Cerrar.Text = "Cerrar";
            this.tb_Cerrar.UseVisualStyleBackColor = true;
            this.tb_Cerrar.Click += new System.EventHandler(this.tb_Cerrar_Click);
            // 
            // dgvLibros
            // 
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.AllowUserToResizeColumns = false;
            this.dgvLibros.AllowUserToResizeRows = false;
            this.dgvLibros.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Autor,
            this.FecDev,
            this.Devolucion});
            this.dgvLibros.Location = new System.Drawing.Point(12, 164);
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(393, 89);
            this.dgvLibros.TabIndex = 1;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Título";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 180;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.Name = "Autor";
            this.Autor.Width = 130;
            // 
            // FecDev
            // 
            this.FecDev.HeaderText = "Vence";
            this.FecDev.Name = "FecDev";
            this.FecDev.Width = 50;
            // 
            // Devolucion
            // 
            this.Devolucion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Devolucion.HeaderText = "Dev.";
            this.Devolucion.Name = "Devolucion";
            this.Devolucion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Devolucion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Devolucion.Width = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número de comprobante:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_Fecha);
            this.groupBox1.Controls.Add(this.tb_Mont);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_client);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_Comp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tb_Fecha
            // 
            this.tb_Fecha.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Fecha.Enabled = false;
            this.tb_Fecha.Location = new System.Drawing.Point(243, 58);
            this.tb_Fecha.Name = "tb_Fecha";
            this.tb_Fecha.Size = new System.Drawing.Size(144, 20);
            this.tb_Fecha.TabIndex = 9;
            this.tb_Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tb_Mont
            // 
            this.tb_Mont.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Mont.Enabled = false;
            this.tb_Mont.Location = new System.Drawing.Point(62, 58);
            this.tb_Mont.Name = "tb_Mont";
            this.tb_Mont.Size = new System.Drawing.Size(119, 20);
            this.tb_Mont.TabIndex = 8;
            this.tb_Mont.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Monto:";
            // 
            // tb_client
            // 
            this.tb_client.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_client.Enabled = false;
            this.tb_client.Location = new System.Drawing.Point(62, 35);
            this.tb_client.Name = "tb_client";
            this.tb_client.Size = new System.Drawing.Size(325, 20);
            this.tb_client.TabIndex = 5;
            this.tb_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cliente:";
            // 
            // tb_Comp
            // 
            this.tb_Comp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_Comp.Enabled = false;
            this.tb_Comp.Location = new System.Drawing.Point(161, 13);
            this.tb_Comp.Name = "tb_Comp";
            this.tb_Comp.Size = new System.Drawing.Size(226, 20);
            this.tb_Comp.TabIndex = 3;
            this.tb_Comp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioCaxial.Properties.Resources.AlqInfo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // AlqInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.tb_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlqInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Info del Comprobante";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tb_Cerrar;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Comp;
        private System.Windows.Forms.TextBox tb_Fecha;
        private System.Windows.Forms.TextBox tb_Mont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_client;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FecDev;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Devolucion;
    }
}