using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion
{
    public partial class PlataformaAlumno : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public PlataformaAlumno()
        {
            InitializeComponent();
            cbxMateriaAlu.DataSource = MateriasABML.ListNomMaterias();
            sidePanel.Height = btnVerNotasAlu.Height;
            sidePanel.Top = btnVerNotasAlu.Top;
        }

        private void PlataformaAlumno_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnVerDetallesAlu_Click(object sender, EventArgs e)
        {
            panelNotas.Visible = true;
        }

        void limpiarCambiarPass()
        {
            txtCodCambiarPass.Clear();
            txtContraseña1.Clear();
            txtContraseña2.Clear();
        }
        private void PlataformaAlumno_Load(object sender, EventArgs e)
        {
            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"SELECT nombre,apellido,Grado,Año_Curso FROM Alumnos where CI_Alumno = '{0}'", txtCIalumno.Text), conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    n.Text = leer.GetString(0);
                    a.Text = leer.GetString(1);
                    g.Text = leer.GetString(2);
                    acurso.Text = leer.GetString(3);
                }
                conexion.Close();
            }
        }
        int ci;
        private void BtnVerNotasAlu_Click(object sender, EventArgs e)
        {
            panelNotas.Visible = true;
            panelCambiarPass.Visible = false;
         
            ci = int.Parse(txtCIalumno.Text);
            string materia = cbxMateriaAlu.Text;
            datosAlumnoPlataformaAlumno.DataSource = plataformaAlumnoABML.ListarDatosAlu(ci,materia);
            sidePanel.Height = btnVerNotasAlu.Height;
            sidePanel.Top = btnVerNotasAlu.Top;
        }

        private void BtnCambiarPassAlu_Click(object sender, EventArgs e)
        {
            panelNotas.Visible = false;
            panelCambiarPass.Visible = true;
            sidePanel.Height = btnCambiarPassAlu.Height;
            sidePanel.Top = btnCambiarPassAlu.Top;
        }

        private void BtnListarTodo_Click(object sender, EventArgs e)
        {
            datosAlumnoPlataformaAlumno.DataSource = plataformaAlumnoABML.ListarDatosTodoAlu(ci);
        }

        private void BtnCerrarSessionAlu_Click(object sender, EventArgs e)
        {

            sidePanel.Height = btnCerrarSessionAlu.Height;
            sidePanel.Top = btnCerrarSessionAlu.Top;
            string message = "estas seguro de Cerrar Session";
            string captiion = "Cerrar session";

            MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, captiion, mensaje);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Login volver = new Login();
                this.Hide();
                volver.Show();
            }
        }

        private void BtnGuardarPass_Click(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == txtContraseña2.Text)
            {
                if (txtCIalumno.Text == txtCodCambiarPass.Text)
                {
                    string message = "estas seguro de guardar el Password";
                    string captiion = "Cambiar Password";

                    MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, captiion, mensaje);

                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        usuario us1 = new usuario();
                        us1.CodUsuario = txtCodCambiarPass.Text;
                        us1.Contraseña = txtContraseña1.Text;
                        us1.Tipo = "adm";
                        LoginABML.Modificar(us1);
                        MessageBox.Show("Contraseña cambiada exitosamente");
                        Login volver = new Login();
                        this.Hide();
                        volver.Show();
                        limpiarCambiarPass();
                    }
                }
                else
                {
                    MessageBox.Show("Codigo invalido.!!");
                }
            }
            else
            {
                MessageBox.Show("Las Contraseñas deben coincidir");
            }
        }
    }
}
