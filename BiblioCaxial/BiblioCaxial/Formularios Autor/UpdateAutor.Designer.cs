namespace BiblioCaxial
{
    partial class UpdateAutor
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
            this.cbx_paisUAut = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_idAu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_CloseAut = new System.Windows.Forms.Button();
            this.Btn_EditAut = new System.Windows.Forms.Button();
            this.tb_apellUAut = new System.Windows.Forms.TextBox();
            this.tb_nombUAut = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(66, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "EDITAR AUTOR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_paisUAut);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbl_idAu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Btn_CloseAut);
            this.groupBox1.Controls.Add(this.Btn_EditAut);
            this.groupBox1.Controls.Add(this.tb_apellUAut);
            this.groupBox1.Controls.Add(this.tb_nombUAut);
            this.groupBox1.Location = new System.Drawing.Point(12, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 283);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cbx_paisUAut
            // 
            this.cbx_paisUAut.FormattingEnabled = true;
            this.cbx_paisUAut.Location = new System.Drawing.Point(19, 201);
            this.cbx_paisUAut.Name = "cbx_paisUAut";
            this.cbx_paisUAut.Size = new System.Drawing.Size(236, 21);
            this.cbx_paisUAut.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Id del autor:";
            // 
            // lbl_idAu
            // 
            this.lbl_idAu.AutoSize = true;
            this.lbl_idAu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idAu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_idAu.Location = new System.Drawing.Point(220, 22);
            this.lbl_idAu.Name = "lbl_idAu";
            this.lbl_idAu.Size = new System.Drawing.Size(0, 25);
            this.lbl_idAu.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "País de origen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre del autor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Apellido del autor:";
            // 
            // Btn_CloseAut
            // 
            this.Btn_CloseAut.Location = new System.Drawing.Point(180, 251);
            this.Btn_CloseAut.Name = "Btn_CloseAut";
            this.Btn_CloseAut.Size = new System.Drawing.Size(75, 23);
            this.Btn_CloseAut.TabIndex = 5;
            this.Btn_CloseAut.Text = "Cerrar";
            this.Btn_CloseAut.UseVisualStyleBackColor = true;
            this.Btn_CloseAut.Click += new System.EventHandler(this.Btn_CloseAut_Click);
            // 
            // Btn_EditAut
            // 
            this.Btn_EditAut.Location = new System.Drawing.Point(99, 251);
            this.Btn_EditAut.Name = "Btn_EditAut";
            this.Btn_EditAut.Size = new System.Drawing.Size(75, 23);
            this.Btn_EditAut.TabIndex = 3;
            this.Btn_EditAut.Text = "Editar";
            this.Btn_EditAut.UseVisualStyleBackColor = true;
            this.Btn_EditAut.Click += new System.EventHandler(this.Btn_EditAut_Click);
            // 
            // tb_apellUAut
            // 
            this.tb_apellUAut.Location = new System.Drawing.Point(19, 84);
            this.tb_apellUAut.Name = "tb_apellUAut";
            this.tb_apellUAut.Size = new System.Drawing.Size(236, 20);
            this.tb_apellUAut.TabIndex = 0;
            // 
            // tb_nombUAut
            // 
            this.tb_nombUAut.Location = new System.Drawing.Point(19, 144);
            this.tb_nombUAut.Name = "tb_nombUAut";
            this.tb_nombUAut.Size = new System.Drawing.Size(236, 20);
            this.tb_nombUAut.TabIndex = 1;
            // 
            // UpdateAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 356);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateAutor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAutor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_idAu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_CloseAut;
        private System.Windows.Forms.Button Btn_EditAut;
        private System.Windows.Forms.TextBox tb_apellUAut;
        private System.Windows.Forms.TextBox tb_nombUAut;
        private System.Windows.Forms.ComboBox cbx_paisUAut;
    }
}