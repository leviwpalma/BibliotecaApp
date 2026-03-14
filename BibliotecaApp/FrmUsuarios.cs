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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Biblioteca.UsuariosSource.DataSource = Biblioteca.Usuarios;
            dgvUsuarios.DataSource = Biblioteca.UsuariosSource;
            dgvUsuarios.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "" ||
       txtDocumento.Text.Trim() == "")
            {
                MessageBox.Show("Complete los campos obligatorios");
                return;
            }

            foreach (Usuario u in Biblioteca.Usuarios)
            {
                if (u.Documento == txtDocumento.Text)
                {
                    MessageBox.Show("Usuario ya registrado");
                    return;
                }
            }

            Usuario nuevo = new Usuario()
            {
                Id = Biblioteca.Usuarios.Count + 1,
                Nombre = txtNombre.Text.Trim(),
                Documento = txtDocumento.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Correo = txtCorreo.Text.Trim()
            };

            Biblioteca.Usuarios.Add(nuevo);
            Biblioteca.UsuariosSource.ResetBindings(false);

            LimpiarCampos();
            dgvUsuarios.ClearSelection();

            MessageBox.Show("Usuario agregado correctamente");
        }
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            Usuario seleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            Biblioteca.Usuarios.Remove(seleccionado);
            Biblioteca.UsuariosSource.ResetBindings(false);

            LimpiarCampos();
            dgvUsuarios.ClearSelection();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            Usuario seleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            Biblioteca.Usuarios.Remove(seleccionado);
            Biblioteca.UsuariosSource.ResetBindings(false);

            LimpiarCampos();
            dgvUsuarios.ClearSelection();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario para editar");
                return;
            }

            Usuario seleccionado = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

            seleccionado.Nombre = txtNombre.Text.Trim();
            seleccionado.Documento = txtDocumento.Text.Trim();
            seleccionado.Telefono = txtTelefono.Text.Trim();
            seleccionado.Correo = txtCorreo.Text.Trim();

            Biblioteca.UsuariosSource.ResetBindings(false);

            LimpiarCampos();
            dgvUsuarios.ClearSelection();

            MessageBox.Show("Usuario editado correctamente");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == "")
            {
                dgvUsuarios.DataSource = Biblioteca.UsuariosSource;
                return;
            }

            string filtro = txtBuscar.Text.ToLower();

            var listaFiltrada = Biblioteca.Usuarios
                .Where(u => u.Nombre.ToLower().Contains(filtro)
                         || u.Documento.ToLower().Contains(filtro))
                .ToList();

            dgvUsuarios.DataSource = listaFiltrada;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
                return;

            Usuario seleccionado = dgvUsuarios.CurrentRow.DataBoundItem as Usuario;

            if (seleccionado == null)
                return;

            txtNombre.Text = seleccionado.Nombre;
            txtDocumento.Text = seleccionado.Documento;
            txtTelefono.Text = seleccionado.Telefono;
            txtCorreo.Text = seleccionado.Correo;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
