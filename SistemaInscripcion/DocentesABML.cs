using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaInscripcion
{
    class DocentesABML
    {
        public static int AgregarDocente1(Docente docente)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"insert into Docentes values ({0},'{1}','{2}','{3}')",
                    docente.CI,
                    docente.Nombre,
                    docente.Apellido,
                    docente.Especialidad), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        public static int AgregarDocente2(Docente docente)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion2())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"insert into Docentes values ({0},'{1}','{2}','{3}')",
                    docente.CI,
                    docente.Genero,
                    docente.Telefono,
                    docente.Direccion), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        public static List<Docente> listarDocente()
        {
            List<Docente> lista = new List<Docente>();

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"SELECT d.*, e.Genero, e.Telefono,e.Direccion FROM Docentes d, proyectoBD2.dbo.Docentes e WHERE d.CI_Docente = e.CI_Docente"),conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    Docente miListaDoc = new Docente();
                    miListaDoc.CI = leer.GetInt32(0);
                    miListaDoc.Nombre = leer.GetString(1);
                    miListaDoc.Apellido = leer.GetString(2);
                    miListaDoc.Genero = leer.GetString(3);
                    miListaDoc.Especialidad = leer.GetString(4);
                    miListaDoc.Telefono = leer.GetInt32(5);
                    miListaDoc.Direccion = leer.GetString(6);
                   lista.Add(miListaDoc);
                }
                conexion.Close();
            }
            return lista;
        }

        public static int ModificarDoc1(Docente docente)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"update Docentes set nombre= '{0}',apellido='{1}',Especialidad='{2}' WHERE CI_Docente = {3}",
                    docente.Nombre,
                    docente.Apellido,
                    docente.Especialidad,
                    docente.CI), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int ModificarDoc2(Docente docente)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion2())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"update Docentes set  Genero='{0}',Telefono={1},Direccion='{2}' WHERE CI_Docente = {3}",
                    docente.Genero,
                    docente.Telefono,
                    docente.Direccion,
                    docente.CI), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarDoc1(int ci)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"delete Docentes where CI_Docente = {0}",ci), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int EliminarDoc2(int ci)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion2())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"delete Docentes where CI_Docente={0}",
                    ci), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        public static List<string> ListCIdocente()
        {
            List<string> lista = new List<string>();

            using (SqlConnection conex = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format("SELECT CI_Docente FROM Docentes"), conex);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    int Docentes;
                    Docentes = leer.GetInt32(0);
                    lista.Add(Docentes.ToString());
                }
                conex.Close();
                return lista;
            }
        }

    }
}
