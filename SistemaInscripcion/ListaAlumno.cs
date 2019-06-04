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
        public double nota1 { get; set; }
        public double nota2 { get; set; }
        public double nota3 { get; set; }
        public double notaf { get; set; }

        public ListaAlumno() { }
        public ListaAlumno(string nom,string ape,double Nota1, double Nota2, double Nota3, double Notaf)
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
