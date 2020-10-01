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
    public partial class LBP : Form
    {
        Image imagenOriginal;
        string rutaImagen;
        Bitmap imagenBitmapGris;
        public LBP()
        {
            InitializeComponent();

            this.rutaImagen = Application.StartupPath + "\\Gatete.jpg";

            imagenOriginal = Image.FromFile(rutaImagen);
            this.pbOriginal.Image = imagenOriginal;

            promedio();
            metodoLBP();
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
                this.imagenBitmapGris = imagenBitmap;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error con la imagen");
            }
        }
        private void metodoLBP()
        {
            try
            {
                Bitmap imagenBitmapLBP = (Bitmap) this.imagenBitmapGris.Clone();

                int x, y;

                //// Loop through the images pixels to reset color.
                string cadenaResultado = "";
                for (int i = 1; i < this.imagenBitmapGris.Width -1; i++)
                {
                    for (int j = 1; j < this.imagenBitmapGris.Height -1; j++)
                    {
                        cadenaResultado = (this.imagenBitmapGris.GetPixel(i, j).R >= this.imagenBitmapGris.GetPixel(i, j - 1).R) ? "1" : "0";
                        cadenaResultado += (this.imagenBitmapGris.GetPixel(i, j).R >= this.imagenBitmapGris.GetPixel(i, j + 1).R) ? "1" : "0";
                        cadenaResultado += (this.imagenBitmapGris.GetPixel(i, j).R >= this.imagenBitmapGris.GetPixel(i - 1, j).R) ? "1" : "0";
                        cadenaResultado += (this.imagenBitmapGris.GetPixel(i, j).R >= this.imagenBitmapGris.GetPixel(i - 1, j + 1).R) ? "1" : "0";
                        cadenaResultado += (this.imagenBitmapGris.GetPixel(i, j).R >= this.imagenBitmapGris.GetPixel(i - 1, j - 1).R) ? "1" : "0";
                        cadenaResultado += (this.imagenBitmapGris.GetPixel(i, j).R >= this.imagenBitmapGris.GetPixel(i + 1, j).R) ? "1" : "0";
                        cadenaResultado += (this.imagenBitmapGris.GetPixel(i, j).R >= this.imagenBitmapGris.GetPixel(i + 1, j - 1).R) ? "1" : "0";
                        cadenaResultado += (this.imagenBitmapGris.GetPixel(i, j).R >= this.imagenBitmapGris.GetPixel(i + 1, j + 1).R) ? "1" : "0";

                        int conversion = Convert.ToInt32(cadenaResultado, 2);
                        Color color = Color.FromArgb(conversion, conversion, conversion);
                        imagenBitmapLBP.SetPixel(i, j, color);
                    }
                }

                this.pbLBP.Image = imagenBitmapLBP;     
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error en la imagen");

                MessageBox.Show(ex.Message);
            }
        }


    }
}
