﻿namespace Procesamiento_de_Imagenes.Forms
{
    partial class Umbralizacion
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
            this.pbOriginal = new System.Windows.Forms.PictureBox();
            this.pbGrises = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbUmbralizacion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUmbralizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOriginal
            // 
            this.pbOriginal.Location = new System.Drawing.Point(250, 12);
            this.pbOriginal.Name = "pbOriginal";
            this.pbOriginal.Size = new System.Drawing.Size(185, 186);
            this.pbOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOriginal.TabIndex = 0;
            this.pbOriginal.TabStop = false;
            // 
            // pbGrises
            // 
            this.pbGrises.Location = new System.Drawing.Point(250, 204);
            this.pbGrises.Name = "pbGrises";
            this.pbGrises.Size = new System.Drawing.Size(185, 186);
            this.pbGrises.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGrises.TabIndex = 1;
            this.pbGrises.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Foto Original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escala de grises";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(77, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Umbbralizacion";
            // 
            // pbUmbralizacion
            // 
            this.pbUmbralizacion.Location = new System.Drawing.Point(250, 396);
            this.pbUmbralizacion.Name = "pbUmbralizacion";
            this.pbUmbralizacion.Size = new System.Drawing.Size(185, 186);
            this.pbUmbralizacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUmbralizacion.TabIndex = 4;
            this.pbUmbralizacion.TabStop = false;
            // 
            // Umbralizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 589);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbUmbralizacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGrises);
            this.Controls.Add(this.pbOriginal);
            this.Name = "Umbralizacion";
            this.Text = "EscalaDeGrises";
            ((System.ComponentModel.ISupportInitialize)(this.pbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUmbralizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOriginal;
        private System.Windows.Forms.PictureBox pbGrises;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbUmbralizacion;
    }
}