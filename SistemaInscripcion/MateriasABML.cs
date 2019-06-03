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
                SqlCommand comando = new SqlCommand(String.Format(@"update materias set nombre='{0}',Clave_Materia={1})",                    
                    materia.Nombre,
                    materia.ClaveM), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Eliminar(int Clave)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"delete Materias where Clave_Materia={0})",
                    Clave), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static List<Materia> Listar()
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
    }
}
