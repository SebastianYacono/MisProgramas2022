namespace BiblioCaxial
{
    partial class AlqPrincipal
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
            this.dgv_AlqP = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AlqClose = new System.Windows.Forms.Button();
            this.btn_AlqAdd = new System.Windows.Forms.Button();
            this.btn_AlqInf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlqP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AlqP
            // 
            this.dgv_AlqP.AllowUserToAddRows = false;
            this.dgv_AlqP.AllowUserToDeleteRows = false;
            this.dgv_AlqP.AllowUserToResizeColumns = false;
            this.dgv_AlqP.AllowUserToResizeRows = false;
            this.dgv_AlqP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AlqP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Cliente,
            this.Fecha,
            this.Monto});
            this.dgv_AlqP.Location = new System.Drawing.Point(12, 12);
            this.dgv_AlqP.Name = "dgv_AlqP";
            this.dgv_AlqP.RowHeadersVisible = false;
            this.dgv_AlqP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AlqP.Size = new System.Drawing.Size(404, 381);
            this.dgv_AlqP.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 40;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
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
            // btn_AlqClose
            // 
            this.btn_AlqClose.Location = new System.Drawing.Point(423, 351);
            this.btn_AlqClose.Name = "btn_AlqClose";
            this.btn_AlqClose.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqClose.TabIndex = 1;
            this.btn_AlqClose.Text = "Cerrar";
            this.btn_AlqClose.UseVisualStyleBackColor = true;
            this.btn_AlqClose.Click += new System.EventHandler(this.btn_AlqClose_Click);
            // 
            // btn_AlqAdd
            // 
            this.btn_AlqAdd.Location = new System.Drawing.Point(423, 303);
            this.btn_AlqAdd.Name = "btn_AlqAdd";
            this.btn_AlqAdd.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqAdd.TabIndex = 2;
            this.btn_AlqAdd.Text = "Agregar";
            this.btn_AlqAdd.UseVisualStyleBackColor = true;
            this.btn_AlqAdd.Click += new System.EventHandler(this.btn_AlqAdd_Click);
            // 
            // btn_AlqInf
            // 
            this.btn_AlqInf.Location = new System.Drawing.Point(423, 256);
            this.btn_AlqInf.Name = "btn_AlqInf";
            this.btn_AlqInf.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqInf.TabIndex = 4;
            this.btn_AlqInf.Text = "Ver detalle";
            this.btn_AlqInf.UseVisualStyleBackColor = true;
            this.btn_AlqInf.Click += new System.EventHandler(this.btn_AlqInf_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioCaxial.Properties.Resources.AlqPr;
            this.pictureBox1.Location = new System.Drawing.Point(423, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // AlqPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AlqInf);
            this.Controls.Add(this.btn_AlqAdd);
            this.Controls.Add(this.btn_AlqClose);
            this.Controls.Add(this.dgv_AlqP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlqPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Alquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AlqP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AlqP;
        private System.Windows.Forms.Button btn_AlqClose;
        private System.Windows.Forms.Button btn_AlqAdd;
        private System.Windows.Forms.Button btn_AlqInf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
    }
}