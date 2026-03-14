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

namespace BibliotecaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FrmLibros f = new FrmLibros();
            f.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios f = new FrmUsuarios();
            f.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamos f = new FrmPrestamos();
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGraficaLibros();
            CargarGraficaUsuarios();
        }
           private void CargarGraficaLibros()
            {
            chartLibros.Series.Clear();
            chartLibros.Titles.Clear();

            chartLibros.Titles.Add("Libros Más Prestados");

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Column;

            var libros = Biblioteca.Prestamos
                .GroupBy(p => p.Libro)
                .Select(g => new
                {
                    Libro = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .Take(5);

            foreach (var item in libros)
            {
                serie.Points.AddXY(item.Libro, item.Cantidad);
            }

            chartLibros.Series.Add(serie);
        }

        private void CargarGraficaUsuarios()
        {
            chartUsuarios.Series.Clear();
            chartUsuarios.Titles.Clear();

            chartUsuarios.Titles.Add("Usuarios Más Activos");

            Series serie = new Series();
            serie.ChartType = SeriesChartType.Column;

            var usuarios = Biblioteca.Prestamos
                .GroupBy(p => p.Usuario)
                .Select(g => new
                {
                    Usuario = g.Key,
                    Cantidad = g.Count()
                })
                .OrderByDescending(x => x.Cantidad)
                .Take(5);

            foreach (var item in usuarios)
            {
                serie.Points.AddXY(item.Usuario, item.Cantidad);
            }

            chartUsuarios.Series.Add(serie);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGraficaLibros();
            CargarGraficaUsuarios();
        }
    }
}

