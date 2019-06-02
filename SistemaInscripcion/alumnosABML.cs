using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaInscripcion
{
    class alumnosABML
    {
        public static int Agregar(alumno alumno)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"insert into Alumnos values ({0},'{1}','{2}','{3}','{4}')",
                    alumno.CI_Alumno,
                    alumno.Nombre,
                    alumno.Apellido,
                    alumno.Grado,
                    alumno.AñoCurso), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Agregar2(alumno alumno)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion2())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"insert into Alumnos values ({0},{1},'{2}')",
                    alumno.CI_Alumno,           
                    alumno.Edad,
                    alumno.Genero), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Modificar(alumno alumno)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"update Alumnos set  nombre='{0}',apellido='{1}',Grado='{2}', Año_Curso='{3}',CI_Alumno={4}",
                    alumno.Nombre,
                    alumno.Apellido,                    
                    alumno.Grado,
                    alumno.AñoCurso,
                    alumno.CI_Alumno), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Modificar2(alumno alumno)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion2())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"update Alumnos set  Edad={0},Genero='{1}',CI_Alumno={2}",
                    alumno.Edad,
                    alumno.Genero,            
                    alumno.CI_Alumno), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Eliminar(int ci)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"delete alumnos where CI_Alumno = {0}",
                    ci), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Eliminar2(int ci)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion2())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"delete alumnos where CI_Alumno={0}",
                    ci), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }

        //este metodo se utiliza com  el login docentes
        public static List<ListaAlumno> listar(string mat,string año)
        {
            List<ListaAlumno> lista = new List<ListaAlumno>();

            using (SqlConnection conexion =Conexion.ObtenerConexion1())
            {

                SqlCommand comando = new SqlCommand(string.Format(@"SELECT a.nombre,a.apellido,M.Nota1,M.Nota2,M.Nota3,M.Notaf 
FROM Alumnos a,Docentes d,Modulo M,materias mat 
where a.CI_Alumno=M.CI_Alumno and d.CI_Docente=M.CI_Docente and mat.Clave_Materia=M.Clave_Materia and mat.Nombre='{0}' and a.Año_Curso='{1}'", mat,año), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    ListaAlumno milista = new ListaAlumno();
                    milista.Nombre = leer.GetString(0);
                    milista.Apellido = leer.GetString(1);
                    milista.nota1 = leer.GetFloat(2);
                    milista.nota2 = leer.GetFloat(3);
                    milista.nota3 = leer.GetFloat(4);
                    milista.notaf = leer.GetFloat(5);
                    lista.Add(milista);
                }                
                conexion.Close();               
            }
            return lista;
        }
        public static List<alumno> listar()
        {
            List<alumno> lista = new List<alumno>();

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {

                SqlCommand comando = new SqlCommand(string.Format(@"SELECT g.*,f.Edad,f.genero FROM Alumnos g,proyectoBD2.dbo.Alumnos f where g.ci_alumno=f.ci_Alumno"), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    alumno alumno = new alumno();
                    alumno.CI_Alumno = leer.GetInt32(0);
                    alumno.Nombre = leer.GetString(1);
                    alumno.Apellido = leer.GetString(2);
                    alumno.Grado = leer.GetString(3);
                    alumno.AñoCurso = leer.GetString(4);
                    alumno.Edad = leer.GetInt32(5);
                    alumno.Genero = leer.GetString(6);
                    lista.Add(alumno);
                }
                conexion.Close();
            }
            return lista;
        }

    }
}
