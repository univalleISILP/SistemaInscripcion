using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaInscripcion
{
    public class plataformaAlumnoABML
    {
        public static List<ListaDatosAlumno> ListarDatosAlu(int ci,string nom)
        {
            List<ListaDatosAlumno> lista = new List<ListaDatosAlumno>();

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {

                SqlCommand comando = new SqlCommand(string.Format(@"
                SELECT n.Nota1,n.Nota2,n.Nota3,n.Notaf,d.nombre as docente
                FROM Modulo n,Materias m,Docentes d,Alumnos a	
                Where a.CI_Alumno = {0} and m.nombre = '{1}' and a.CI_Alumno=n.CI_Alumno and d.CI_Docente=n.CI_Docente and m.Clave_Materia=n.Clave_Materia", ci,nom), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    ListaDatosAlumno alumno = new ListaDatosAlumno();
                    alumno.Nota1 = leer.GetDouble(0);
                    alumno.Nota2 = leer.GetDouble(1);
                    alumno.Nota3 = leer.GetDouble(2);
                    alumno.Notaf = leer.GetDouble(3);
                    alumno.NomDocente = leer.GetString(4);
                    lista.Add(alumno);
                }
                conexion.Close();
            }
            return lista;
        }

        public static List<AlumnoCMateria> ListarDatosTodoAlu(int ci)
        {
            List<AlumnoCMateria> lista = new List<AlumnoCMateria>();

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {

                SqlCommand comando = new SqlCommand(string.Format(@"
                SELECT m.nombre,n.Nota1,n.Nota2,n.Nota3,n.Notaf,d.nombre as docente
                FROM Modulo n,Materias m,Docentes d,Alumnos a	
                Where a.CI_Alumno = {0} and a.CI_Alumno=n.CI_Alumno and d.CI_Docente=n.CI_Docente and m.Clave_Materia=n.Clave_Materia", ci), conexion);
                SqlDataReader leer = comando.ExecuteReader();

                while (leer.Read())
                {
                    AlumnoCMateria alumno = new AlumnoCMateria();
                    alumno.nombre = leer.GetString(0);
                    alumno.Nota1 = leer.GetDouble(1);
                    alumno.Nota2 = leer.GetDouble(2);
                    alumno.Nota3 = leer.GetDouble(3);
                    alumno.Notaf = leer.GetDouble(4);
                    alumno.NomDocente = leer.GetString(5);
                    lista.Add(alumno);
                }
                conexion.Close();
            }
            return lista;
        }
    }
}
