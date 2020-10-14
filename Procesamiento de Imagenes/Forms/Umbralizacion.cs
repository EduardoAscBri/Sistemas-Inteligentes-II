using Procesamiento_de_Imagenes.Classes;
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
    public partial class Umbralizacion : Form
    {
        Image imagenOriginal;
        string rutaImagen;
        public Umbralizacion()
        {
            InitializeComponent();
        }
        public Umbralizacion(int metodo)
        {
            InitializeComponent();

            this.rutaImagen = Application.StartupPath + "\\Gatete.jpg";

            imagenOriginal = Image.FromFile(rutaImagen);
            this.pbOriginal.Image = imagenOriginal;

            switch (metodo)
            {
                case 1:
                    promedio();
                    otsu();
                    this.Text = "Umbralizacion metodo Otsu";
                    break;

                case 2:
                    promedio();
                    canny();
                    this.Text = "Umbralizacion metodo Canny";
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
        private void otsu()
        {
            //Bitmap temp = (Bitmap)org.Clone();
            Bitmap temp = (Bitmap) this.pbGrises.Image.Clone();
            Otsu otsu = new Otsu();
            //ot.Convert2GrayScaleFast(temp);
            int otsuThreshold = otsu.getOtsuThreshold((Bitmap)temp);
            otsu.threshold(temp, otsuThreshold);
            //textBox1.Text = otsuThreshold.ToString();
            pbUmbralizacion.Image = temp;
        }
        private void canny()
        {
            float TH = 20f;
            float TL = 10f;
            int MaskSize = 5;
            int Sigma = 1;

            Bitmap temp = (Bitmap)this.pbGrises.Image.Clone();
            Canny CannyData = new Canny(temp, TH, TL, MaskSize, Sigma);


            Bitmap HystThreshImage = CannyData.DisplayImage(CannyData.NonMax);
            Bitmap GaussianFilteredImage = CannyData.DisplayImage(CannyData.FilteredImage);
            Bitmap GNL = CannyData.DisplayImage(CannyData.GNL);
            Bitmap GNH = CannyData.DisplayImage(CannyData.GNH);

            pbUmbralizacion.Image = CannyData.DisplayImage(CannyData.EdgeMap);
        }

    }
}
