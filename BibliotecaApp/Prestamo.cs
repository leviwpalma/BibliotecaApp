using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaApp
{
    using System;

    public class Prestamo
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Libro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public bool Devuelto { get; set; }
        public string Estado => Devuelto ? "Devuelto" : "Prestado";
    }
}
