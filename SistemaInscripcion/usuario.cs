using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcion
{
    public class usuario
    {
        public string CodUsuario { get; set; }
        public string Tipo { get; set; }
        public string Contraseña { get; set; }


        public usuario() { }

        public usuario(string codUser, string tip, string pswd) {

            CodUsuario = codUser;
            Tipo = tip;
            Contraseña = pswd;
        }
    } 
}
