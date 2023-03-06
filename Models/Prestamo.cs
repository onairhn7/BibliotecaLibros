using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaLibros.Models
{
    public class Prestamo
    {

        public Libros libro { get; set; }
        public Persona persona { get; set; }

        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

    }
}
