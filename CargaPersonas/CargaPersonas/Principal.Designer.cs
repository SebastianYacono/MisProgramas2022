namespace CargaPersonas
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabProfes = new System.Windows.Forms.TabPage();
            this.Btn_deleteProf = new System.Windows.Forms.Button();
            this.Btn_editProf = new System.Windows.Forms.Button();
            this.Btn_addProf = new System.Windows.Forms.Button();
            this.dgv_Prof = new System.Windows.Forms.DataGridView();
            this.tabAlumnos = new System.Windows.Forms.TabPage();
            this.Btn_deleteAlumn = new System.Windows.Forms.Button();
            this.Btn_editAlumn = new System.Windows.Forms.Button();
            this.Btn_addAlumn = new System.Windows.Forms.Button();
            this.dgv_Alumn = new System.Windows.Forms.DataGridView();
            this.Control1 = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TabProfes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prof)).BeginInit();
            this.tabAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumn)).BeginInit();
            this.Control1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabProfes
            // 
            this.TabProfes.Controls.Add(this.Btn_deleteProf);
            this.TabProfes.Controls.Add(this.Btn_editProf);
            this.TabProfes.Controls.Add(this.Btn_addProf);
            this.TabProfes.Controls.Add(this.dgv_Prof);
            this.TabProfes.Location = new System.Drawing.Point(4, 22);
            this.TabProfes.Name = "TabProfes";
            this.TabProfes.Padding = new System.Windows.Forms.Padding(3);
            this.TabProfes.Size = new System.Drawing.Size(575, 233);
            this.TabProfes.TabIndex = 0;
            this.TabProfes.Text = "Profesores";
            this.TabProfes.UseVisualStyleBackColor = true;
            // 
            // Btn_deleteProf
            // 
            this.Btn_deleteProf.Location = new System.Drawing.Point(177, 201);
            this.Btn_deleteProf.Name = "Btn_deleteProf";
            this.Btn_deleteProf.Size = new System.Drawing.Size(75, 23);
            this.Btn_deleteProf.TabIndex = 3;
            this.Btn_deleteProf.Text = "Eliminar";
            this.Btn_deleteProf.UseVisualStyleBackColor = true;
            this.Btn_deleteProf.Click += new System.EventHandler(this.Btn_deleteProf_Click);
            // 
            // Btn_editProf
            // 
            this.Btn_editProf.Location = new System.Drawing.Point(96, 201);
            this.Btn_editProf.Name = "Btn_editProf";
            this.Btn_editProf.Size = new System.Drawing.Size(75, 23);
            this.Btn_editProf.TabIndex = 2;
            this.Btn_editProf.Text = "Editar";
            this.Btn_editProf.UseVisualStyleBackColor = true;
            this.Btn_editProf.Click += new System.EventHandler(this.Btn_editProf_Click);
            // 
            // Btn_addProf
            // 
            this.Btn_addProf.Location = new System.Drawing.Point(15, 201);
            this.Btn_addProf.Name = "Btn_addProf";
            this.Btn_addProf.Size = new System.Drawing.Size(75, 23);
            this.Btn_addProf.TabIndex = 1;
            this.Btn_addProf.Text = "Agregar";
            this.Btn_addProf.UseVisualStyleBackColor = true;
            this.Btn_addProf.Click += new System.EventHandler(this.Btn_addProf_Click);
            // 
            // dgv_Prof
            // 
            this.dgv_Prof.AllowUserToAddRows = false;
            this.dgv_Prof.AllowUserToDeleteRows = false;
            this.dgv_Prof.AllowUserToResizeColumns = false;
            this.dgv_Prof.AllowUserToResizeRows = false;
            this.dgv_Prof.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Prof.Location = new System.Drawing.Point(6, 9);
            this.dgv_Prof.Name = "dgv_Prof";
            this.dgv_Prof.ReadOnly = true;
            this.dgv_Prof.RowHeadersVisible = false;
            this.dgv_Prof.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Prof.Size = new System.Drawing.Size(563, 186);
            this.dgv_Prof.TabIndex = 0;
            // 
            // tabAlumnos
            // 
            this.tabAlumnos.Controls.Add(this.Btn_deleteAlumn);
            this.tabAlumnos.Controls.Add(this.Btn_editAlumn);
            this.tabAlumnos.Controls.Add(this.Btn_addAlumn);
            this.tabAlumnos.Controls.Add(this.dgv_Alumn);
            this.tabAlumnos.Location = new System.Drawing.Point(4, 22);
            this.tabAlumnos.Name = "tabAlumnos";
            this.tabAlumnos.Size = new System.Drawing.Size(575, 233);
            this.tabAlumnos.TabIndex = 4;
            this.tabAlumnos.Text = "Alumnos";
            this.tabAlumnos.UseVisualStyleBackColor = true;
            // 
            // Btn_deleteAlumn
            // 
            this.Btn_deleteAlumn.Location = new System.Drawing.Point(177, 201);
            this.Btn_deleteAlumn.Name = "Btn_deleteAlumn";
            this.Btn_deleteAlumn.Size = new System.Drawing.Size(75, 23);
            this.Btn_deleteAlumn.TabIndex = 7;
            this.Btn_deleteAlumn.Text = "Eliminar";
            this.Btn_deleteAlumn.UseVisualStyleBackColor = true;
            this.Btn_deleteAlumn.Click += new System.EventHandler(this.Btn_deleteAlumn_Click);
            // 
            // Btn_editAlumn
            // 
            this.Btn_editAlumn.Location = new System.Drawing.Point(96, 201);
            this.Btn_editAlumn.Name = "Btn_editAlumn";
            this.Btn_editAlumn.Size = new System.Drawing.Size(75, 23);
            this.Btn_editAlumn.TabIndex = 6;
            this.Btn_editAlumn.Text = "Editar";
            this.Btn_editAlumn.UseVisualStyleBackColor = true;
            this.Btn_editAlumn.Click += new System.EventHandler(this.Btn_editAlumn_Click);
            // 
            // Btn_addAlumn
            // 
            this.Btn_addAlumn.Location = new System.Drawing.Point(15, 201);
            this.Btn_addAlumn.Name = "Btn_addAlumn";
            this.Btn_addAlumn.Size = new System.Drawing.Size(75, 23);
            this.Btn_addAlumn.TabIndex = 5;
            this.Btn_addAlumn.Text = "Agregar";
            this.Btn_addAlumn.UseVisualStyleBackColor = true;
            this.Btn_addAlumn.Click += new System.EventHandler(this.Btn_addAlumn_Click);
            // 
            // dgv_Alumn
            // 
            this.dgv_Alumn.AllowUserToAddRows = false;
            this.dgv_Alumn.AllowUserToDeleteRows = false;
            this.dgv_Alumn.AllowUserToResizeColumns = false;
            this.dgv_Alumn.AllowUserToResizeRows = false;
            this.dgv_Alumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Alumn.Location = new System.Drawing.Point(6, 9);
            this.dgv_Alumn.MultiSelect = false;
            this.dgv_Alumn.Name = "dgv_Alumn";
            this.dgv_Alumn.ReadOnly = true;
            this.dgv_Alumn.RowHeadersVisible = false;
            this.dgv_Alumn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Alumn.Size = new System.Drawing.Size(563, 186);
            this.dgv_Alumn.TabIndex = 4;
            // 
            // Control1
            // 
            this.Control1.Controls.Add(this.tabAlumnos);
            this.Control1.Controls.Add(this.TabProfes);
            this.Control1.Location = new System.Drawing.Point(12, 119);
            this.Control1.Name = "Control1";
            this.Control1.SelectedIndex = 0;
            this.Control1.Size = new System.Drawing.Size(583, 259);
            this.Control1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.Title;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(579, 101);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 390);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pantalla Principal";
            this.TabProfes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prof)).EndInit();
            this.tabAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumn)).EndInit();
            this.Control1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabProfes;
        private System.Windows.Forms.Button Btn_deleteProf;
        private System.Windows.Forms.Button Btn_editProf;
        private System.Windows.Forms.Button Btn_addProf;
        private System.Windows.Forms.DataGridView dgv_Prof;
        private System.Windows.Forms.TabPage tabAlumnos;
        private System.Windows.Forms.Button Btn_deleteAlumn;
        private System.Windows.Forms.Button Btn_editAlumn;
        private System.Windows.Forms.Button Btn_addAlumn;
        private System.Windows.Forms.DataGridView dgv_Alumn;
        private System.Windows.Forms.TabControl Control1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

