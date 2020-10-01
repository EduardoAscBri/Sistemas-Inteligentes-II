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
    public partial class Binarizacion : Form
    {
        Image imagenOriginal;
        string rutaImagen;
        Bitmap imagenBitmapGris;
        public Binarizacion()
        {
            InitializeComponent();

            this.rutaImagen = Application.StartupPath + "\\Gatete.jpg";

            imagenOriginal = Image.FromFile(rutaImagen);
            this.pbOriginal.Image = imagenOriginal;

            promedio();
            metodoBinarizacion();
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
        private void metodoBinarizacion()
        {
            try
            {
                Bitmap imagenBinaria = new Bitmap(this.imagenBitmapGris);
                Color pixel;
                
                for (int y = 0; y < this.imagenBitmapGris.Height; y++)
                {
                    for (int x = 0; x < this.imagenBitmapGris.Width; x++)
                    {
                        pixel = this.imagenBitmapGris.GetPixel(x, y);
                        double gris = pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11;
                        if (gris > 127)
                        {
                            imagenBinaria.SetPixel(x, y, Color.White);
                        }
                        else
                        {
                            imagenBinaria.SetPixel(x, y, Color.Black);
                        }
                    }
                }
                this.pbImagenBinaria.Image = imagenBinaria;
          
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error con la imagen.");

                MessageBox.Show(ex.Message);
            }
        }


    }
}
