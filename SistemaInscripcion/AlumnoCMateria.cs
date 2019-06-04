using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcion
{
    public class AlumnoCMateria
    {
        public string nombre { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Notaf { get; set; }
        public string NomDocente { get; set; }

        public AlumnoCMateria() { }
        public AlumnoCMateria(string nom,double n1, double n2, double n3, double nf, string nd)
        {
            nombre = nom;
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;
            Notaf = nf;
            NomDocente = nd;
        }
    }
}
