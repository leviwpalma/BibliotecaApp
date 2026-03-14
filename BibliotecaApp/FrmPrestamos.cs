using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaApp
{
    public partial class FrmPrestamos : Form
    {
        public FrmPrestamos()
        {
            InitializeComponent();
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            
            dgvUsuariosPrestamo.DataSource = Biblioteca.UsuariosSource;
            dgvLibrosPrestamo.DataSource = Biblioteca.LibrosSource;

            dgvUsuariosPrestamo.ClearSelection();
            dgvLibrosPrestamo.ClearSelection();
        








        Biblioteca.PrestamosSource.DataSource = Biblioteca.Prestamos;
            dgvPrestamos.DataSource = Biblioteca.PrestamosSource;


            dgvPrestamos.ClearSelection();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            if (dgvUsuariosPrestamo.CurrentRow == null ||
        dgvLibrosPrestamo.CurrentRow == null)
            {
                MessageBox.Show("Seleccione usuario y libro");
                return;
            }

            Usuario usuario = dgvUsuariosPrestamo.CurrentRow.DataBoundItem as Usuario;
            Libro libro = dgvLibrosPrestamo.CurrentRow.DataBoundItem as Libro;

            if (libro.Inventario <= 0)
            {
                MessageBox.Show("No hay inventario disponible");
                return;
            }

            Prestamo nuevo = new Prestamo()
            {
                Id = Biblioteca.Prestamos.Count + 1,
                Usuario = usuario.Nombre,
                Libro = libro.Titulo,
                FechaPrestamo = dtpPrestamo.Value,
                FechaDevolucion = dtpDevolucion.Value,
                Devuelto = false
            };

            Biblioteca.Prestamos.Add(nuevo);
            libro.Inventario--;

            Biblioteca.LibrosSource.ResetBindings(false);
            Biblioteca.PrestamosSource.ResetBindings(false);

            MessageBox.Show("Préstamo realizado correctamente");
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un préstamo");
                return;
            }

            Prestamo p = dgvPrestamos.CurrentRow.DataBoundItem as Prestamo;

            if (p.Devuelto)
            {
                MessageBox.Show("Ya fue devuelto");
                return;
            }

            p.Devuelto = true;

            Libro libro = Biblioteca.Libros.FirstOrDefault(l => l.Titulo == p.Libro);
            if (libro != null)
                libro.Inventario++; // 🔺 aumenta inventario

            Biblioteca.LibrosSource.ResetBindings(false);
            Biblioteca.PrestamosSource.ResetBindings(false);

            MessageBox.Show("Libro devuelto");
        }

        private void Libro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text.Trim() == "")
            {
                dgvUsuariosPrestamo.DataSource = Biblioteca.UsuariosSource;
                return;
            }

            string filtro = txtBuscarUsuario.Text.ToLower();

            var listaFiltrada = Biblioteca.Usuarios
                .Where(u => u.Nombre.ToLower().Contains(filtro)
                         || u.Documento.ToLower().Contains(filtro))
                .ToList();

            dgvUsuariosPrestamo.DataSource = listaFiltrada;
        }

        private void txtBuscarLibro_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarLibro.Text.Trim() == "")
            {
                dgvLibrosPrestamo.DataSource = Biblioteca.LibrosSource;
                return;
            }

            string filtro = txtBuscarLibro.Text.ToLower();

            var listaFiltrada = Biblioteca.Libros
                .Where(l => l.Titulo.ToLower().Contains(filtro)
                         || l.Autor.ToLower().Contains(filtro))
                .ToList();

            dgvLibrosPrestamo.DataSource = listaFiltrada;
        }

        private void txtBuscarPrestamo_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarPrestamo.Text.Trim() == "")
            {
                dgvPrestamos.DataSource = Biblioteca.PrestamosSource;
                return;
            }

            string filtro = txtBuscarPrestamo.Text.ToLower();

            var listaFiltrada = Biblioteca.Prestamos
                .Where(p =>
                    p.Usuario.ToLower().Contains(filtro) ||
                    p.Libro.ToLower().Contains(filtro) ||
                    p.Estado.ToLower().Contains(filtro) ||
                    p.FechaPrestamo.ToString("dd/MM/yyyy").Contains(filtro) ||
                    p.FechaDevolucion.ToString("dd/MM/yyyy").Contains(filtro)
                )
                .ToList();

            dgvPrestamos.DataSource = listaFiltrada;
        }

        private void cbLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
