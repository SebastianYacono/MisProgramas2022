namespace Manana
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
            this.Bt_fecha = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.BT_cargarAnio = new System.Windows.Forms.Button();
            this.BT_cargarMes = new System.Windows.Forms.Button();
            this.BT_cargarDia = new System.Windows.Forms.Button();
            this.TB_anio = new System.Windows.Forms.NumericUpDown();
            this.TB_mes = new System.Windows.Forms.NumericUpDown();
            this.TB_dia = new System.Windows.Forms.NumericUpDown();
            this.BT_reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TB_anio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_mes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_dia)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Día";
            // 
            // Bt_fecha
            // 
            this.Bt_fecha.Enabled = false;
            this.Bt_fecha.Location = new System.Drawing.Point(12, 138);
            this.Bt_fecha.Name = "Bt_fecha";
            this.Bt_fecha.Size = new System.Drawing.Size(234, 23);
            this.Bt_fecha.TabIndex = 6;
            this.Bt_fecha.Text = "¿Qué día sigue?";
            this.Bt_fecha.UseVisualStyleBackColor = true;
            this.Bt_fecha.Click += new System.EventHandler(this.Bt_fecha_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_resultado);
            this.groupBox1.Location = new System.Drawing.Point(12, 173);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 90);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(6, 20);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(220, 60);
            this.lbl_resultado.TabIndex = 8;
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_cargarAnio
            // 
            this.BT_cargarAnio.Location = new System.Drawing.Point(171, 25);
            this.BT_cargarAnio.Name = "BT_cargarAnio";
            this.BT_cargarAnio.Size = new System.Drawing.Size(75, 23);
            this.BT_cargarAnio.TabIndex = 8;
            this.BT_cargarAnio.Text = "Cargar";
            this.BT_cargarAnio.UseVisualStyleBackColor = true;
            this.BT_cargarAnio.Click += new System.EventHandler(this.BT_cargarAnio_Click);
            // 
            // BT_cargarMes
            // 
            this.BT_cargarMes.Enabled = false;
            this.BT_cargarMes.Location = new System.Drawing.Point(171, 64);
            this.BT_cargarMes.Name = "BT_cargarMes";
            this.BT_cargarMes.Size = new System.Drawing.Size(75, 23);
            this.BT_cargarMes.TabIndex = 9;
            this.BT_cargarMes.Text = "Cargar";
            this.BT_cargarMes.UseVisualStyleBackColor = true;
            this.BT_cargarMes.Click += new System.EventHandler(this.BT_cargarMes_Click);
            // 
            // BT_cargarDia
            // 
            this.BT_cargarDia.Enabled = false;
            this.BT_cargarDia.Location = new System.Drawing.Point(171, 103);
            this.BT_cargarDia.Name = "BT_cargarDia";
            this.BT_cargarDia.Size = new System.Drawing.Size(75, 23);
            this.BT_cargarDia.TabIndex = 10;
            this.BT_cargarDia.Text = "Cargar";
            this.BT_cargarDia.UseVisualStyleBackColor = true;
            this.BT_cargarDia.Click += new System.EventHandler(this.BT_cargarDia_Click);
            // 
            // TB_anio
            // 
            this.TB_anio.Location = new System.Drawing.Point(12, 27);
            this.TB_anio.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.TB_anio.Name = "TB_anio";
            this.TB_anio.Size = new System.Drawing.Size(153, 20);
            this.TB_anio.TabIndex = 11;
            // 
            // TB_mes
            // 
            this.TB_mes.Enabled = false;
            this.TB_mes.Location = new System.Drawing.Point(12, 66);
            this.TB_mes.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.TB_mes.Name = "TB_mes";
            this.TB_mes.Size = new System.Drawing.Size(153, 20);
            this.TB_mes.TabIndex = 12;
            // 
            // TB_dia
            // 
            this.TB_dia.Enabled = false;
            this.TB_dia.Location = new System.Drawing.Point(12, 104);
            this.TB_dia.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.TB_dia.Name = "TB_dia";
            this.TB_dia.Size = new System.Drawing.Size(153, 20);
            this.TB_dia.TabIndex = 13;
            // 
            // BT_reset
            // 
            this.BT_reset.Location = new System.Drawing.Point(90, 282);
            this.BT_reset.Name = "BT_reset";
            this.BT_reset.Size = new System.Drawing.Size(75, 23);
            this.BT_reset.TabIndex = 14;
            this.BT_reset.Text = "Reiniciar";
            this.BT_reset.UseVisualStyleBackColor = true;
            this.BT_reset.Click += new System.EventHandler(this.BT_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 317);
            this.Controls.Add(this.BT_reset);
            this.Controls.Add(this.TB_dia);
            this.Controls.Add(this.TB_mes);
            this.Controls.Add(this.TB_anio);
            this.Controls.Add(this.BT_cargarDia);
            this.Controls.Add(this.BT_cargarMes);
            this.Controls.Add(this.BT_cargarAnio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Bt_fecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Yo no sé mañana...";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TB_anio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_mes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB_dia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_fecha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button BT_cargarAnio;
        private System.Windows.Forms.Button BT_cargarMes;
        private System.Windows.Forms.Button BT_cargarDia;
        private System.Windows.Forms.NumericUpDown TB_anio;
        private System.Windows.Forms.NumericUpDown TB_mes;
        private System.Windows.Forms.NumericUpDown TB_dia;
        private System.Windows.Forms.Button BT_reset;
    }
}

