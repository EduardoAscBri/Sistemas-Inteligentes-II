using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamiento_de_Imagenes.Forms
{
    public partial class Histograma : Form
    {
        Image imagenOriginal;
        string rutaImagen;
        Bitmap imagenBitmap;
        int[] iHistograma;
        int mayor;

        public Histograma()
        {
            InitializeComponent();

            this.rutaImagen = Application.StartupPath + "\\Gatete.jpg";

            imagenOriginal = Image.FromFile(rutaImagen);
            this.pbOriginal.Image = imagenOriginal;

            promedio();
            histograma();
        }
        //Average
        private void promedio()
        {
            try
            {
                Bitmap imagenBitmap = new Bitmap(this.rutaImagen, true);
                for (int x = 0; x < imagenBitmap.Width; x++)
                {
                    for (int y = 0; y < imagenBitmap.Height; y++)
                    {
                        Color pixelColor = imagenBitmap.GetPixel(x, y);
                        int average = (pixelColor.R + pixelColor.B + pixelColor.G) / 3;
                        Color nuevoColor = Color.FromArgb(average, average, average);
                        imagenBitmap.SetPixel(x, y, nuevoColor);
                    }
                }
                this.pbGrises.Image = imagenBitmap;
                this.imagenBitmap = imagenBitmap;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error con la imagen");
            }
        }
        private void histograma()
        {
            this.iHistograma = new int[256];

            int x = 0;
            int y = 0;
            Color color = new Color();

            int i = 0;

            for(x = 0; x < this.imagenBitmap.Width; x++)
            {
                for(y = 0; y < this.imagenBitmap.Height; y++)
                {
                    color = this.imagenBitmap.GetPixel(x, y);

                    this.iHistograma[color.R]++;
                }
            }

            

            int n = 0;
            int mayor = 0;

            for(n = 0; n < 256; n++)
            {
                if(this.iHistograma[n] > mayor)
                {
                    mayor = this.iHistograma[n];
                }
            }

            for(n = 9; n < 256; n++)
            {
                this.iHistograma[n] = (int)((float)this.iHistograma[n] / (float)mayor * 256.0f);
            }

           
        }
        private void Histograma_Paint(object sender, PaintEventArgs e)
        {
            int n = 20;
            
            Graphics graphis = e.Graphics;
            Pen plumaH = new Pen(Color.Black);
            Pen plumaEjes = new Pen(Color.Black);

            graphis.DrawLine(plumaEjes, 5, 400, 5, 600);
            graphis.DrawLine(plumaEjes, 5, 600, 400, 600);

            for(n = 0; n < 256; n++)
            {
                graphis.DrawLine(plumaH, n+20, 600, n+20, 600-this.iHistograma[n]);
            }
        }
    }
}
