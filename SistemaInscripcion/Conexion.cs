using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaInscripcion
{
    class Conexion
    {
        public static SqlConnection ObtenerConexion1()
        {
            //Conexion a a base de datos Cris
            //SqlConnection conex = new SqlConnection("Data Source=DESKTOP-3GSJ7HM;Initial Catalog=proyectoBD;Integrated Security=True");
            //Conexion a la base de datos Jorge
            SqlConnection conex = new SqlConnection("Data Source=DESKTOP-22N1BH9;Initial Catalog=proyectoBD;Integrated Security=True");
            conex.Open();
            return conex;
        }
        public static SqlConnection ObtenerConexion2()
        {
            //Conexion a a base de datos
            //SqlConnection conex = new SqlConnection("Data Source=DESKTOP-3GSJ7HM;Initial Catalog=proyectoBD2;Integrated Security=True");
            //Conexion a la base de datos Jorge
            SqlConnection conex = new SqlConnection("Data Source=DESKTOP-22N1BH9;Initial Catalog=proyectoBD2;Integrated Security=True");
            conex.Open();
            return conex;
        }
    }
}
