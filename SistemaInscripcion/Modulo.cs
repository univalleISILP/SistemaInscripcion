using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcion
{
    class Modulo
    {
        public int CI_Docente { get; set; }
        public int CI_Alumno { get; set; }
        public int Clave_Materia { get; set; }
        public float Nota1 { get; set; }
        public float Nota2 { get; set; }
        public float Nota3 { get; set; }
        public float Notaf { get; set; }

        public Modulo() { }

        public Modulo(int ciDoc, int ciAlm, int clveMat, float nota1, float nota2, float nota3, float notaf)
        {
            CI_Docente = ciDoc;
            CI_Alumno = ciAlm;
            Clave_Materia = Clave_Materia;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Notaf = notaf;
        }
    }
}
