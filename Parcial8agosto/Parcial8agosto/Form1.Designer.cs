
namespace Parcial8agosto
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lbl_Edad = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.TextBox();
            this.Txt_Dni = new System.Windows.Forms.TextBox();
            this.Txt_FechaNac = new System.Windows.Forms.TextBox();
            this.Btn_Persona = new System.Windows.Forms.Button();
            this.Btn_Edad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "D.N.I.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Edad:";
            // 
            // Lbl_Edad
            // 
            this.Lbl_Edad.AutoSize = true;
            this.Lbl_Edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Edad.Location = new System.Drawing.Point(151, 178);
            this.Lbl_Edad.Name = "Lbl_Edad";
            this.Lbl_Edad.Size = new System.Drawing.Size(0, 31);
            this.Lbl_Edad.TabIndex = 4;
            this.Lbl_Edad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(141, 34);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(200, 20);
            this.Txt_Nombre.TabIndex = 5;
            // 
            // Txt_Dni
            // 
            this.Txt_Dni.Location = new System.Drawing.Point(141, 74);
            this.Txt_Dni.Name = "Txt_Dni";
            this.Txt_Dni.Size = new System.Drawing.Size(200, 20);
            this.Txt_Dni.TabIndex = 6;
            // 
            // Txt_FechaNac
            // 
            this.Txt_FechaNac.Location = new System.Drawing.Point(141, 115);
            this.Txt_FechaNac.Name = "Txt_FechaNac";
            this.Txt_FechaNac.Size = new System.Drawing.Size(200, 20);
            this.Txt_FechaNac.TabIndex = 7;
            // 
            // Btn_Persona
            // 
            this.Btn_Persona.Location = new System.Drawing.Point(410, 24);
            this.Btn_Persona.Name = "Btn_Persona";
            this.Btn_Persona.Size = new System.Drawing.Size(132, 38);
            this.Btn_Persona.TabIndex = 8;
            this.Btn_Persona.Text = "Btn_Persona";
            this.Btn_Persona.UseVisualStyleBackColor = true;
            this.Btn_Persona.Click += new System.EventHandler(this.Btn_Persona_Click);
            // 
            // Btn_Edad
            // 
            this.Btn_Edad.Enabled = false;
            this.Btn_Edad.Location = new System.Drawing.Point(410, 74);
            this.Btn_Edad.Name = "Btn_Edad";
            this.Btn_Edad.Size = new System.Drawing.Size(132, 38);
            this.Btn_Edad.TabIndex = 9;
            this.Btn_Edad.Text = "Btn_Edad";
            this.Btn_Edad.UseVisualStyleBackColor = true;
            this.Btn_Edad.Click += new System.EventHandler(this.Btn_Edad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 246);
            this.Controls.Add(this.Btn_Edad);
            this.Controls.Add(this.Btn_Persona);
            this.Controls.Add(this.Txt_FechaNac);
            this.Controls.Add(this.Txt_Dni);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.Lbl_Edad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lbl_Edad;
        private System.Windows.Forms.TextBox Txt_Nombre;
        private System.Windows.Forms.TextBox Txt_Dni;
        private System.Windows.Forms.TextBox Txt_FechaNac;
        private System.Windows.Forms.Button Btn_Persona;
        private System.Windows.Forms.Button Btn_Edad;
    }
}

