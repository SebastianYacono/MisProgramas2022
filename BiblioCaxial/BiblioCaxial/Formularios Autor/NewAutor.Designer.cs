namespace BiblioCaxial
{
    partial class NewAutor
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_paisAutor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_CleanAutor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_CloseAutor = new System.Windows.Forms.Button();
            this.Btn_AddAutor = new System.Windows.Forms.Button();
            this.tb_ApellAutor = new System.Windows.Forms.TextBox();
            this.tb_NombAutor = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(48, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "CARGA DE AUTOR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_paisAutor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Btn_CleanAutor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_CloseAutor);
            this.groupBox1.Controls.Add(this.Btn_AddAutor);
            this.groupBox1.Controls.Add(this.tb_ApellAutor);
            this.groupBox1.Controls.Add(this.tb_NombAutor);
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 244);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cbx_paisAutor
            // 
            this.cbx_paisAutor.FormattingEnabled = true;
            this.cbx_paisAutor.Location = new System.Drawing.Point(19, 158);
            this.cbx_paisAutor.Name = "cbx_paisAutor";
            this.cbx_paisAutor.Size = new System.Drawing.Size(236, 21);
            this.cbx_paisAutor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "País de origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del autor";
            // 
            // Btn_CleanAutor
            // 
            this.Btn_CleanAutor.Location = new System.Drawing.Point(18, 208);
            this.Btn_CleanAutor.Name = "Btn_CleanAutor";
            this.Btn_CleanAutor.Size = new System.Drawing.Size(75, 23);
            this.Btn_CleanAutor.TabIndex = 4;
            this.Btn_CleanAutor.Text = "Limpiar";
            this.Btn_CleanAutor.UseVisualStyleBackColor = true;
            this.Btn_CleanAutor.Click += new System.EventHandler(this.Btn_CleanAutor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido del autor:";
            // 
            // Btn_CloseAutor
            // 
            this.Btn_CloseAutor.Location = new System.Drawing.Point(180, 208);
            this.Btn_CloseAutor.Name = "Btn_CloseAutor";
            this.Btn_CloseAutor.Size = new System.Drawing.Size(75, 23);
            this.Btn_CloseAutor.TabIndex = 5;
            this.Btn_CloseAutor.Text = "Cerrar";
            this.Btn_CloseAutor.UseVisualStyleBackColor = true;
            this.Btn_CloseAutor.Click += new System.EventHandler(this.Btn_CloseAutor_Click);
            // 
            // Btn_AddAutor
            // 
            this.Btn_AddAutor.Location = new System.Drawing.Point(99, 208);
            this.Btn_AddAutor.Name = "Btn_AddAutor";
            this.Btn_AddAutor.Size = new System.Drawing.Size(75, 23);
            this.Btn_AddAutor.TabIndex = 3;
            this.Btn_AddAutor.Text = "Agregar";
            this.Btn_AddAutor.UseVisualStyleBackColor = true;
            this.Btn_AddAutor.Click += new System.EventHandler(this.Btn_AddAutor_Click);
            // 
            // tb_ApellAutor
            // 
            this.tb_ApellAutor.Location = new System.Drawing.Point(19, 41);
            this.tb_ApellAutor.Name = "tb_ApellAutor";
            this.tb_ApellAutor.Size = new System.Drawing.Size(236, 20);
            this.tb_ApellAutor.TabIndex = 0;
            // 
            // tb_NombAutor
            // 
            this.tb_NombAutor.Location = new System.Drawing.Point(19, 101);
            this.tb_NombAutor.Name = "tb_NombAutor";
            this.tb_NombAutor.Size = new System.Drawing.Size(236, 20);
            this.tb_NombAutor.TabIndex = 1;
            // 
            // NewAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 322);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAutor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAutor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_CleanAutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_CloseAutor;
        private System.Windows.Forms.Button Btn_AddAutor;
        private System.Windows.Forms.TextBox tb_ApellAutor;
        private System.Windows.Forms.TextBox tb_NombAutor;
        private System.Windows.Forms.ComboBox cbx_paisAutor;
    }
}