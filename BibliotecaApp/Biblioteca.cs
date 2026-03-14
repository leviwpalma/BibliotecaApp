using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows.Forms;

    public static class Biblioteca
    {
        public static BindingSource LibrosSource = new BindingSource();
        public static List<Libro> Libros = new List<Libro>();

        public static BindingList<Usuario> Usuarios = new BindingList<Usuario>();
        public static BindingSource UsuariosSource = new BindingSource();

        public static BindingList<Prestamo> Prestamos = new BindingList<Prestamo>();
        public static BindingSource PrestamosSource = new BindingSource();
    }
}
