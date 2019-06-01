using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcion
{
    class Materia
    {
        public int ClaveM { get; set; }
        public String Nombre { get; set; }

        public Materia() { }
        public Materia(int claveM,string nombre)
        {
            ClaveM = claveM;
            Nombre = nombre;
        }
    }
}
