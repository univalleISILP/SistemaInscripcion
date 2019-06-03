using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaInscripcion
{
    class MateriasABML
    {
        public static int Agregar(Materia materia)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"insert into Materias values ({0},'{1}')",
                    materia.ClaveM,
                    materia.Nombre), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Update(Materia materia)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"update Materias set nombre='{0}' WHERE Clave_Materia = {1}", materia.Nombre,materia.ClaveM), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarMateria(int Clave)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"Delete From Materias Where Clave_Materia={0}",Clave),conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static List<Materia> ListarMateria()
        {
            List<Materia> lista = new List<Materia>();

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"Select * From Materias"), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Materia materia = new Materia();
                    materia.ClaveM = leer.GetInt32(0);
                    materia.Nombre = leer.GetString(1);
                    lista.Add(materia);
                }
                conexion.Close();
            }
            return lista;
        }
        public static List<Materia> ListarXnombreMateria()
        {
            List<Materia> lista = new List<Materia>();

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"select nombre from Materias"), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Materia materia = new Materia();
                    materia.Nombre = leer.GetString(0);
                    lista.Add(materia);
                }
                conexion.Close();
            }
            return lista;
        }


        public static List<string> ListCIMateria()
        {
            List<string> lista = new List<string>();

            using (SqlConnection conex = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format("SELECT Clave_Materia FROM Materias"), conex);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    int Materia;
                    Materia = leer.GetInt32(0);
                    lista.Add(Materia.ToString());
                }
                conex.Close();
            }
            return lista;
        }



        public static List<string> ListNomMaterias()
        {
            List<string> lista = new List<string>();

            using (SqlConnection conex = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format("SELECT nombre FROM Materias"), conex);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    string Materias;
                    Materias = leer.GetString(0);
                    lista.Add(Materias);
                }
                conex.Close();
            }
            return lista;
        }
    }
}
