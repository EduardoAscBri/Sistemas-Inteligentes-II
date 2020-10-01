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
    public partial class EscalaDeGrises : Form
    {
        Image imagenOriginal;
        string rutaImagen;
        public EscalaDeGrises()
        {
            InitializeComponent();
        }
        public EscalaDeGrises(int metodo)
        {
            InitializeComponent();

            this.rutaImagen = Application.StartupPath + "\\Gatete.jpg";

            imagenOriginal = Image.FromFile(rutaImagen);
            this.pbOriginal.Image = imagenOriginal;

            switch (metodo)
            {
                case 1:
                    promedio();
                    this.Text = "Metodo de Promedio";
                    break;

                case 2:
                    tonalidad();
                    this.Text = "Metodo de Tonalidad";
                    break;

                case 3:
                    luminosidad();
                    this.Text = "Metodo de Luminosidad";
                    break;
            }
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
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error con la imagen");
            }
        }
        //Midgrayy
        private void tonalidad()
        {
            try
            {
                // Retrieve the image.
                Bitmap imagenBitmap = new Bitmap(this.rutaImagen, true);
                for (int x = 0; x < imagenBitmap.Width; x++)
                {
                    for (int y = 0; y < imagenBitmap.Height; y++)
                    {
                        Color pixelColor = imagenBitmap.GetPixel(x, y);
                        List<int> listaColores = new List<int>();
                        listaColores.Add(pixelColor.R);
                        listaColores.Add(pixelColor.G);
                        listaColores.Add(pixelColor.B);

                        int maximo = listaColores.Max();
                        int minimo = listaColores.Min();

                        int average = (maximo + minimo) / 2;

                        Color nuevoColor = Color.FromArgb(average, average, average);
                        imagenBitmap.SetPixel(x, y, nuevoColor);
                    }
                }
                this.pbGrises.Image = imagenBitmap;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error con la imagen");
            }
        }
        //Luminosity
        private void luminosidad()
        {
            try
            {
                Bitmap imagenBitmap = new Bitmap(this.rutaImagen, true);
                for (int x = 0; x < imagenBitmap.Width; x++)
                {
                    for (int y = 0; y < imagenBitmap.Height; y++)
                    {
                        Color pixelColor = imagenBitmap.GetPixel(x, y);
                        double luminosidad = (0.299 * pixelColor.R) + (0.587 * pixelColor.G) + (0.114 * pixelColor.B);
                        int average = Convert.ToInt32(luminosidad);
                        Color nuevoColor = Color.FromArgb(average, average, average);
                        imagenBitmap.SetPixel(x, y, nuevoColor);
                    }
                }
                this.pbGrises.Image = imagenBitmap;          
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Error con la imagen");
            }
        }

    }
}
