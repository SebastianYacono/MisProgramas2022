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
            this.SalirApp = new System.Windows.Forms.Button();
            this.Control1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Notificaciones = new System.Windows.Forms.GroupBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.LastBook = new System.Windows.Forms.Label();
            this.Control1.SuspendLayout();
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
            this.Control1.Controls.Add(this.tabPage1);
            this.Control1.Controls.Add(this.tabPage2);
            this.Control1.Controls.Add(this.tabPage3);
            this.Control1.Controls.Add(this.tabPage4);
            this.Control1.Location = new System.Drawing.Point(12, 12);
            this.Control1.Name = "Control1";
            this.Control1.SelectedIndex = 0;
            this.Control1.Size = new System.Drawing.Size(583, 259);
            this.Control1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 233);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(575, 361);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Libros";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(575, 233);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Alquiler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Notificaciones
            // 
            this.Notificaciones.Controls.Add(this.LastBook);
            this.Notificaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notificaciones.Location = new System.Drawing.Point(16, 277);
            this.Notificaciones.Name = "Notificaciones";
            this.Notificaciones.Size = new System.Drawing.Size(486, 43);
            this.Notificaciones.TabIndex = 3;
            this.Notificaciones.TabStop = false;
            this.Notificaciones.Text = "Último libro ingresado";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(575, 233);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Devolución";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // LastBook
            // 
            this.LastBook.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LastBook.Location = new System.Drawing.Point(12, 16);
            this.LastBook.Name = "LastBook";
            this.LastBook.Size = new System.Drawing.Size(465, 18);
            this.LastBook.TabIndex = 0;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 334);
            this.ControlBox = false;
            this.Controls.Add(this.Notificaciones);
            this.Controls.Add(this.Control1);
            this.Controls.Add(this.SalirApp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Control1.ResumeLayout(false);
            this.Notificaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SalirApp;
        private System.Windows.Forms.TabControl Control1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox Notificaciones;
        private System.Windows.Forms.Label LastBook;
    }
}