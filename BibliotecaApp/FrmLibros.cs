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
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FrmLibros_Load(object sender, EventArgs e)
        {
            Biblioteca.LibrosSource.DataSource = Biblioteca.Libros;
            dgvLibros.DataSource = Biblioteca.LibrosSource;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
        
            //  Validar campos vacíos
            if (txtTitulo.Text.Trim() == "" ||
                txtAutor.Text.Trim() == "" ||
                txtAnio.Text.Trim() == "")
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            //  Validar que año sea número
            if (!int.TryParse(txtAnio.Text, out int anio))
            {
                MessageBox.Show("Ingrese un año válido");
                return;
            }

            //  Evitar libros repetidos (mismo título y autor)
            foreach (Libro l in Biblioteca.Libros)
            {
                if (l.Titulo.ToLower() == txtTitulo.Text.ToLower() &&
                    l.Autor.ToLower() == txtAutor.Text.ToLower())
                {
                    MessageBox.Show("Ese libro ya está registrado");
                    return;
                }
            }

            //  Crear nuevo libro con inventario
            Libro nuevo = new Libro()
            {
                Id = Biblioteca.Libros.Count + 1,
                Titulo = txtTitulo.Text.Trim(),
                Autor = txtAutor.Text.Trim(),
                Anio = anio,
                Inventario = (int)numInventario.Value
            };

            //  Agregar a la lista
            Biblioteca.Libros.Add(nuevo);

            //  Refrescar tabla
            Biblioteca.LibrosSource.ResetBindings(false);

           

            //  Quitar selección de tabla
            dgvLibros.ClearSelection();
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            numInventario.Value = 1;



            MessageBox.Show("Libro agregado correctamente");
        }

        public void limpiarcampos() 
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            numInventario.Value = 1;
        }
        

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un libro");
                return;
            }

            int fila = dgvLibros.SelectedRows[0].Index;

            Biblioteca.Libros[fila].Titulo = txtTitulo.Text;
            Biblioteca.Libros[fila].Autor = txtAutor.Text;
            Biblioteca.Libros[fila].Anio = int.Parse(txtAnio.Text);

            Biblioteca.LibrosSource.ResetBindings(false);
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            numInventario.Value = 1;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // 🔹 Verificar que haya fila seleccionada
            if (dgvLibros.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un libro para eliminar");
                return;
            }

            // 🔹 Obtener el libro real seleccionado
            Libro seleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;

            if (seleccionado == null)
            {
                MessageBox.Show("No se pudo obtener el libro");
                return;
            }

            // 🔹 Confirmar eliminación
            DialogResult r = MessageBox.Show(
                "¿Eliminar el libro: " + seleccionado.Titulo + "?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (r != DialogResult.Yes)
                return;

            // 🔹 Eliminar de la lista principal
            Biblioteca.Libros.Remove(seleccionado);

            // 🔹 Actualizar tabla
            Biblioteca.LibrosSource.ResetBindings(false);

            // 🔹 Limpiar selección
            dgvLibros.ClearSelection();

           

            MessageBox.Show("Libro eliminado correctamente");
            dgvLibros.ClearSelection();
    
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            numInventario.Value = 1;
        }

        private void dgvLibros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTitulo.Text = dgvLibros.Rows[e.RowIndex].Cells["Titulo"].Value.ToString();
                txtAutor.Text = dgvLibros.Rows[e.RowIndex].Cells["Autor"].Value.ToString();
                txtAnio.Text = dgvLibros.Rows[e.RowIndex].Cells["Anio"].Value.ToString();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.ToLower();

            var filtrados = Biblioteca.Libros.Where(libro =>
                libro.Titulo.ToLower().Contains(texto) ||
                libro.Autor.ToLower().Contains(texto)
            ).ToList();

            dgvLibros.DataSource = null;
            dgvLibros.DataSource = filtrados;
        }

        private void dgvLibros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow == null) return;

            Libro seleccionado = (Libro)dgvLibros.CurrentRow.DataBoundItem;

            txtTitulo.Text = seleccionado.Titulo;
            txtAutor.Text = seleccionado.Autor;
            txtAnio.Text = seleccionado.Anio.ToString();
            numInventario.Value = seleccionado.Inventario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }
    }
}
