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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_AlqClose = new System.Windows.Forms.Button();
            this.btn_AlqAdd = new System.Windows.Forms.Button();
            this.btn_AlqEdit = new System.Windows.Forms.Button();
            this.btn_AlqInf = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(404, 429);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_AlqClose
            // 
            this.btn_AlqClose.Location = new System.Drawing.Point(423, 400);
            this.btn_AlqClose.Name = "btn_AlqClose";
            this.btn_AlqClose.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqClose.TabIndex = 1;
            this.btn_AlqClose.Text = "Cerrar";
            this.btn_AlqClose.UseVisualStyleBackColor = true;
            this.btn_AlqClose.Click += new System.EventHandler(this.btn_AlqClose_Click);
            // 
            // btn_AlqAdd
            // 
            this.btn_AlqAdd.Location = new System.Drawing.Point(423, 352);
            this.btn_AlqAdd.Name = "btn_AlqAdd";
            this.btn_AlqAdd.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqAdd.TabIndex = 2;
            this.btn_AlqAdd.Text = "Agregar";
            this.btn_AlqAdd.UseVisualStyleBackColor = true;
            this.btn_AlqAdd.Click += new System.EventHandler(this.btn_AlqAdd_Click);
            // 
            // btn_AlqEdit
            // 
            this.btn_AlqEdit.Location = new System.Drawing.Point(422, 304);
            this.btn_AlqEdit.Name = "btn_AlqEdit";
            this.btn_AlqEdit.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqEdit.TabIndex = 3;
            this.btn_AlqEdit.Text = "Modificar";
            this.btn_AlqEdit.UseVisualStyleBackColor = true;
            // 
            // btn_AlqInf
            // 
            this.btn_AlqInf.Location = new System.Drawing.Point(423, 256);
            this.btn_AlqInf.Name = "btn_AlqInf";
            this.btn_AlqInf.Size = new System.Drawing.Size(222, 42);
            this.btn_AlqInf.TabIndex = 4;
            this.btn_AlqInf.Text = "Ver detalle";
            this.btn_AlqInf.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BiblioCaxial.Properties.Resources.IconAlq;
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
            this.ClientSize = new System.Drawing.Size(656, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AlqInf);
            this.Controls.Add(this.btn_AlqEdit);
            this.Controls.Add(this.btn_AlqAdd);
            this.Controls.Add(this.btn_AlqClose);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlqPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Alquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AlqClose;
        private System.Windows.Forms.Button btn_AlqAdd;
        private System.Windows.Forms.Button btn_AlqEdit;
        private System.Windows.Forms.Button btn_AlqInf;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}