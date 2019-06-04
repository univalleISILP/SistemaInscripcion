using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaInscripcion
{
    class NotasConsultas
    {
        public static int ListCIMateria(string nom)
        {
            int ci = 0000;

            using (SqlConnection conex = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format("SELECT Clave_Materia FROM Materias where nombre='{0}'", nom), conex);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    int Materia;
                    Materia = leer.GetInt32(0);
                    ci = Materia;
                }
                conex.Close();
            }
            return ci;
        }
        public static List<ListaAlumno> listar(int mat, string año, int ciDoc, string grado)
        {
            List<ListaAlumno> lista = new List<ListaAlumno>();

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {

                SqlCommand comando = new SqlCommand(string.Format(@"SELECT a.nombre,a.apellido,M.Nota1,M.Nota2,M.Nota3,M.Notaf 
                FROM Alumnos a,Docentes d,Modulo M,materias mat 
                where a.CI_Alumno=M.CI_Alumno and d.CI_Docente=M.CI_Docente and mat.Clave_Materia=M.Clave_Materia 
                and mat.Clave_Materia={0} and a.Año_Curso='{1}' and d.ci_docente={2} and a.grado='{3}'", mat, año, ciDoc, grado), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    try
                    {
                        ListaAlumno milista = new ListaAlumno();
                        milista.Nombre = leer.GetString(0);
                        milista.Apellido = leer.GetString(1);
                        milista.nota1 = leer.GetDouble(2);
                        milista.nota2 = leer.GetDouble(3);
                        milista.nota3 = leer.GetDouble(4);
                        milista.notaf = leer.GetDouble(5);
                        lista.Add(milista);
                    }
                    catch (InvalidCastException)
                    {
                    }
                }
                conexion.Close();
            }
            return lista;
        }
        public static int ListCIAlumnos(string nombre,string apellido)
        {
            int ci = 0000;

            using (SqlConnection conex = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format("SELECT CI_Alumno FROM Alumnos where nombre='{0}' and apellido='{1}'",nombre,apellido), conex);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {                 

                    ci = leer.GetInt32(0);
                    
                }
                conex.Close();
                return ci;
            }
        }
        public static string ListarGrado(int ci)
        {
            string grado = "";

            using (SqlConnection conex = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format("SELECT Grado FROM Alumnos where CI_Alumno={0}", ci), conex);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    grado = leer.GetString(0);
                }
                conex.Close();
                return grado;
            }
        }

        public static string ListarAño(int ci)
        {
            string grado = "";

            using (SqlConnection conex = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format("SELECT Año_Curso FROM Alumnos where CI_Alumno={0}", ci), conex);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    grado = leer.GetString(0);
                }
                conex.Close();
                return grado;
            }
        }

        public static string ListarNombreM(int ci)
        {
            string nom = "";

            using (SqlConnection conex = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format("SELECT nombre FROM Materias where Clave_Materia={0}", ci), conex);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nom = leer.GetString(0);
                }
                conex.Close();
            }
            return nom;
        }

        public static string ListarXnombreMateria(string esp)
        {
            string lista="";

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"select m.nombre from Materias m,Docentes d where especialidad=m.nombre",esp), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    lista = leer.GetString(0);
                }
                conexion.Close();
            }
            return lista;
        }
        public static string listarespecialidad(int ci)
        {
            string lista = "";

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"SELECT especialidad FROM Docentes WHERE ci_docente={0}",ci), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    lista = leer.GetString(0);
                }
                conexion.Close();
            }
            return lista;
        }

    }
}
