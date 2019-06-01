using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcion
{
    class Docente
    {
        public int CI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public char Genero { get; set; }
        public string Especialidad { get; set; }
        public int Telefono { get; set; }
        public string Direccion { get; set; }

        public Docente() { }

        public Docente(int ci, string nombre, string apellido, char genero, string especialidad, int telefono, string direccion)
        {
            CI = ci;
            Nombre = nombre;
            Apellido = apellido;
            Genero = genero;
            Especialidad = especialidad;
            Telefono = telefono;
            Direccion = direccion;
        }

    }
}
