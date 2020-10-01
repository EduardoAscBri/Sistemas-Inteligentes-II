namespace Procesamiento_de_Imagenes
{
    partial class FormMenu
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
            this.bttPromedio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bttTonalidad = new System.Windows.Forms.Button();
            this.bttLuminosidad = new System.Windows.Forms.Button();
            this.bttHistograma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bttBinarizacion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttPromedio
            // 
            this.bttPromedio.Location = new System.Drawing.Point(25, 53);
            this.bttPromedio.Name = "bttPromedio";
            this.bttPromedio.Size = new System.Drawing.Size(75, 23);
            this.bttPromedio.TabIndex = 0;
            this.bttPromedio.Text = "Promedio";
            this.bttPromedio.UseVisualStyleBackColor = true;
            this.bttPromedio.Click += new System.EventHandler(this.bttPromedio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escala de grises";
            // 
            // bttTonalidad
            // 
            this.bttTonalidad.Location = new System.Drawing.Point(25, 82);
            this.bttTonalidad.Name = "bttTonalidad";
            this.bttTonalidad.Size = new System.Drawing.Size(75, 23);
            this.bttTonalidad.TabIndex = 2;
            this.bttTonalidad.Text = "Tonalidad";
            this.bttTonalidad.UseVisualStyleBackColor = true;
            this.bttTonalidad.Click += new System.EventHandler(this.bttTonalidad_Click);
            // 
            // bttLuminosidad
            // 
            this.bttLuminosidad.Location = new System.Drawing.Point(25, 111);
            this.bttLuminosidad.Name = "bttLuminosidad";
            this.bttLuminosidad.Size = new System.Drawing.Size(75, 23);
            this.bttLuminosidad.TabIndex = 3;
            this.bttLuminosidad.Text = "Luminosidad";
            this.bttLuminosidad.UseVisualStyleBackColor = true;
            this.bttLuminosidad.Click += new System.EventHandler(this.bttLuminosidad_Click);
            // 
            // bttHistograma
            // 
            this.bttHistograma.Location = new System.Drawing.Point(156, 53);
            this.bttHistograma.Name = "bttHistograma";
            this.bttHistograma.Size = new System.Drawing.Size(75, 23);
            this.bttHistograma.TabIndex = 4;
            this.bttHistograma.Text = "Histograma";
            this.bttHistograma.UseVisualStyleBackColor = true;
            this.bttHistograma.Click += new System.EventHandler(this.bttHistograma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Histograma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Local Binary Pattern";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "LBP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Binarización";
            // 
            // bttBinarizacion
            // 
            this.bttBinarizacion.Location = new System.Drawing.Point(435, 53);
            this.bttBinarizacion.Name = "bttBinarizacion";
            this.bttBinarizacion.Size = new System.Drawing.Size(75, 23);
            this.bttBinarizacion.TabIndex = 8;
            this.bttBinarizacion.Text = "Binarización";
            this.bttBinarizacion.UseVisualStyleBackColor = true;
            this.bttBinarizacion.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 151);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttBinarizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttHistograma);
            this.Controls.Add(this.bttLuminosidad);
            this.Controls.Add(this.bttTonalidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttPromedio);
            this.Name = "FormMenu";
            this.Text = "Procesamiento de Imagenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttPromedio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttTonalidad;
        private System.Windows.Forms.Button bttLuminosidad;
        private System.Windows.Forms.Button bttHistograma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttBinarizacion;
    }
}

