using Procesamiento_de_Imagenes.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procesamiento_de_Imagenes
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void bttPromedio_Click(object sender, EventArgs e)
        {
            EscalaDeGrises escalaDeGrises = new EscalaDeGrises(1);
            escalaDeGrises.Show();
        }

        private void bttTonalidad_Click(object sender, EventArgs e)
        {
            EscalaDeGrises escalaDeGrises = new EscalaDeGrises(2);
            escalaDeGrises.Show();
        }

        private void bttLuminosidad_Click(object sender, EventArgs e)
        {
            EscalaDeGrises escalaDeGrises = new EscalaDeGrises(3);
            escalaDeGrises.Show();
        }

        private void bttHistograma_Click(object sender, EventArgs e)
        {
            Histograma histograma = new Histograma();
            histograma.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LBP lbp = new LBP();
            lbp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Binarizacion binarizacion = new Binarizacion();
            binarizacion.Show();
        }

        private void bttOtsu_Click(object sender, EventArgs e)
        {
            Umbralizacion umbralizacion = new Umbralizacion(1);
            umbralizacion.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Umbralizacion umbralizacion = new Umbralizacion(2);
            umbralizacion.Show();
        }
    }
}
