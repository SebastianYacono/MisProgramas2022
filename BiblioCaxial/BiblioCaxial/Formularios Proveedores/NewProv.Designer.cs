namespace BiblioCaxial
{
    partial class NewProv
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
            this.Btn_AddProv = new System.Windows.Forms.Button();
            this.Btn_CloseProv = new System.Windows.Forms.Button();
            this.Btn_CleanProv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nombProv = new System.Windows.Forms.TextBox();
            this.tb_telProv = new System.Windows.Forms.TextBox();
            this.tb_emailProv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_AddProv
            // 
            this.Btn_AddProv.Location = new System.Drawing.Point(99, 208);
            this.Btn_AddProv.Name = "Btn_AddProv";
            this.Btn_AddProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddProv.TabIndex = 3;
            this.Btn_AddProv.Text = "Agregar";
            this.Btn_AddProv.UseVisualStyleBackColor = true;
            this.Btn_AddProv.Click += new System.EventHandler(this.Btn_AddProv_Click);
            // 
            // Btn_CloseProv
            // 
            this.Btn_CloseProv.Location = new System.Drawing.Point(180, 208);
            this.Btn_CloseProv.Name = "Btn_CloseProv";
            this.Btn_CloseProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_CloseProv.TabIndex = 5;
            this.Btn_CloseProv.Text = "Cerrar";
            this.Btn_CloseProv.UseVisualStyleBackColor = true;
            this.Btn_CloseProv.Click += new System.EventHandler(this.Btn_CloseProv_Click);
            // 
            // Btn_CleanProv
            // 
            this.Btn_CleanProv.Location = new System.Drawing.Point(18, 208);
            this.Btn_CleanProv.Name = "Btn_CleanProv";
            this.Btn_CleanProv.Size = new System.Drawing.Size(75, 23);
            this.Btn_CleanProv.TabIndex = 4;
            this.Btn_CleanProv.Text = "Limpiar";
            this.Btn_CleanProv.UseVisualStyleBackColor = true;
            this.Btn_CleanProv.Click += new System.EventHandler(this.Btn_CleanProv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_CleanProv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_CloseProv);
            this.groupBox1.Controls.Add(this.Btn_AddProv);
            this.groupBox1.Controls.Add(this.tb_nombProv);
            this.groupBox1.Controls.Add(this.tb_telProv);
            this.groupBox1.Controls.Add(this.tb_emailProv);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 244);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Correo electrónico:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de teléfono:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del proveedor:";
            // 
            // tb_nombProv
            // 
            this.tb_nombProv.Location = new System.Drawing.Point(19, 41);
            this.tb_nombProv.Name = "tb_nombProv";
            this.tb_nombProv.Size = new System.Drawing.Size(236, 20);
            this.tb_nombProv.TabIndex = 0;
            // 
            // tb_telProv
            // 
            this.tb_telProv.Location = new System.Drawing.Point(19, 101);
            this.tb_telProv.Name = "tb_telProv";
            this.tb_telProv.Size = new System.Drawing.Size(236, 20);
            this.tb_telProv.TabIndex = 1;
            // 
            // tb_emailProv
            // 
            this.tb_emailProv.Location = new System.Drawing.Point(19, 158);
            this.tb_emailProv.Name = "tb_emailProv";
            this.tb_emailProv.Size = new System.Drawing.Size(236, 20);
            this.tb_emailProv.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(12, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "CARGA DE PROVEEDORES";
            // 
            // NewProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 322);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProv";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Nuevo Proveedor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_AddProv;
        private System.Windows.Forms.Button Btn_CloseProv;
        private System.Windows.Forms.Button Btn_CleanProv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nombProv;
        private System.Windows.Forms.TextBox tb_telProv;
        private System.Windows.Forms.TextBox tb_emailProv;
        private System.Windows.Forms.Label label5;
    }
}