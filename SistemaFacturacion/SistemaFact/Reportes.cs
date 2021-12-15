using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;





namespace SistemaFact
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            graficoUno();

            graficoDos();


        }

        public void graficoUno()
        {
            string[] series = { "Zapatillas Addidas", "Gorra Polo", "Mochila Addidas" };
            int[] puntos = { 150, 120, 140 };

            GrfPrecios.Palette = ChartColorPalette.Pastel;

            GrfPrecios.Titles.Add("Precios de Articulos");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = GrfPrecios.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }

        public void graficoDos()
        {
            string[] series = { "Zapatillas Addidas", "Gorra Polo", "Mochila Addidas" };
            int[] puntos = { 3,2,1 };

            GrfVentas.Palette = ChartColorPalette.Pastel;

            GrfVentas.Titles.Add("Venta de Articulos");

            for (int i = 0; i < series.Length; i++)
            {
                Series serie = GrfVentas.Series.Add(series[i]);

                serie.Label = puntos[i].ToString();

                serie.Points.Add(puntos[i]);
            }
        }
    }
}
