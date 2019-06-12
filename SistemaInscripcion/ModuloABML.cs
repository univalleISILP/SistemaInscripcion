using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInscripcion
{
    class ModuloABML
    {
        public static int Agregar(Modulo mod)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"insert into Modulo values ({0},{1},'{2}',{3},{4},{5},{6})",
                    mod.CI_Docente,
                    mod.CI_Alumno,
                    mod.Clave_Materia,
                    mod.Nota1,
                    mod.Nota2,
                    mod.Nota3,
                    mod.Notaf), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int UpdateAlumno(Modulo mod)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"Update modulo set Nota1={2},Nota2={3},Nota3={4},Notaf={5} where CI_Alumno={0} and Clave_Materia={1} and CI_Docente={6}",
                    mod.CI_Alumno,
                    mod.Clave_Materia,
                    mod.Nota1,
                    mod.Nota2,
                    mod.Nota3,
                    mod.Notaf,
                    mod.CI_Docente), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Eliminar(Modulo mod)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"delete Modulo where CI_Docente={0} and CI_Alumno={1} and Clave_Materia={2}",
                    mod.CI_Docente,
                    mod.CI_Alumno,
                    mod.Clave_Materia), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static List<Modulo> Listar()
        {
            List<Modulo> lista = new List<Modulo>();

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"Select * From Modulo"), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Modulo mod = new Modulo();
                    mod.CI_Docente = leer.GetInt32(0);
                    mod.CI_Alumno = leer.GetInt32(1);
                    mod.Clave_Materia = leer.GetInt32(2);
                    mod.Nota1 = leer.GetDouble(3);
                    mod.Nota2 = leer.GetDouble(4);
                    mod.Nota3 = leer.GetDouble(5);
                    mod.Notaf = leer.GetDouble(6);
                    lista.Add(mod);
                }
                conexion.Close();
            }
            return lista;
        }
    }
}
