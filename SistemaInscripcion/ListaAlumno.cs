using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcion
{
    class ListaAlumno
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public float nota1 { get; set; }
        public float nota2 { get; set; }
        public float nota3 { get; set; }
        public float notaf { get; set; }

        public ListaAlumno() { }
        public ListaAlumno(string nom,string ape,float Nota1, float Nota2, float Nota3, float Notaf)
        {
            Nombre = nom;
            Apellido = ape;
            nota1 = Nota1;
            nota2 = Nota2;
            nota3 = Nota3;
            notaf = Notaf;
        }
    }
}
