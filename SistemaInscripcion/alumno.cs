using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcion
{
    public class alumno
    {
        public int CI_Alumno { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public char Genero { get; set; }
        
        public string Grado { get; set; }
        public string AñoCurso { get; set; }


        public alumno(){}

        public alumno(int ciAlum,string nom, string apell,char geb, int ed, string grad, string aCur)
        {
            CI_Alumno = ciAlum;
            Nombre = nom;
            Apellido = apell;
            Genero = geb;
            Edad = ed;
            Grado = grad;
            AñoCurso = aCur;
        }
    }
}
