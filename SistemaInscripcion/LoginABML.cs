using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaInscripcion
{
    class LoginABML
    {
        public static int Agregar(usuario usuario)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"insert into Usuario values ('{0}','{1}','{2}')",
                    usuario.CodUsuario,
                    usuario.Tipo,
                    usuario.Contraseña), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Modificar(usuario usuario)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"update usuario set contraseña='{0}' where Cod_Usuario={1}",
                    usuario.Contraseña,
                    usuario.CodUsuario), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static int Eliminar(string cod)
        {
            int retorno = 0;

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"delete Usuario where Cod_Usuario='{0}'",
                    cod), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();
            }
            return retorno;
        }
        public static string Autenticar(usuario usuario)
        {
            string retorno = "";

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(String.Format(@"Select tipo from Usuario where Cod_Usuario='{0}' and contraseña='{1}'",
                    usuario.CodUsuario,
                    usuario.Contraseña), conexion);
                SqlDataReader leer =comando.ExecuteReader();
                while (leer.Read())
                {
                    retorno = leer.GetString(0);
                }
                conexion.Close();
            }
            return retorno;
        }
    }
}
