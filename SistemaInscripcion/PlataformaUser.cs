using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace SistemaInscripcion
{
    public partial class PlataformaUser : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public PlataformaUser()
        {
            InitializeComponent();
            sidePanel.Height = btnNotas.Height;
            sidePanel.Top = btnNotas.Top;
        }

        private void BtnNotas_Click(object sender, EventArgs e)
        {
            panelNotas.Visible = true;
            panelCambiarPass.Visible = false;
            cbxMateria.DataSource = MateriasABML.ListNomMaterias();            
            int clmat = NotasConsultas.ListCIMateria(cbxMateria.Text);
            int ci = int.Parse(txtCIDOC.Text);
            datosNotas.DataSource = NotasConsultas.listar(clmat,cbxAñoCurso.Text,ci,cbxGrado.Text);

            sidePanel.Height = btnNotas.Height;
            sidePanel.Top = btnNotas.Top;
        }

        private void PlataformaUser_Load(object sender, EventArgs e)
        {
            string especialidad = NotasConsultas.listarespecialidad(int.Parse(txtCIDOC.Text));
            cbxMateria.DataSource = MateriasABML.ListNomMaterias();
            int clmat = MateriasABML.ListCIMateria(cbxMateria.Text);
            int ci = int.Parse(txtCIDOC.Text);
            datosNotas.DataSource = alumnosABML.listar(clmat, cbxAñoCurso.Text, ci, cbxGrado.Text);

            using (SqlConnection conexion = Conexion.ObtenerConexion1())
            {
                SqlCommand comando = new SqlCommand(string.Format(@"SELECT nombre,apellido,Especialidad FROM Docentes where CI_Docente = '{0}'", txtCIDOC.Text), conexion);
                SqlDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    nd.Text = leer.GetString(0);
                    ad.Text = leer.GetString(1);
                    ed.Text = leer.GetString(2);
                }
                conexion.Close();
            }
        }

        private void CbxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clmat = NotasConsultas.ListCIMateria(cbxMateria.Text);
            int ci = int.Parse(txtCIDOC.Text);
            datosNotas.DataSource = NotasConsultas.listar(clmat, cbxAñoCurso.Text, ci, cbxGrado.Text);
        }

        private void CbxAñoCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clmat = NotasConsultas.ListCIMateria(cbxMateria.Text);
            int ci = int.Parse(txtCIDOC.Text);
            datosNotas.DataSource = NotasConsultas.listar(clmat, cbxAñoCurso.Text, ci, cbxGrado.Text);
        }

        private void CbxGrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            int clmat = NotasConsultas.ListCIMateria(cbxMateria.Text);
            int ci = int.Parse(txtCIDOC.Text);
            datosNotas.DataSource = NotasConsultas.listar(clmat, cbxAñoCurso.Text, ci, cbxGrado.Text);
        }

        private void DatosNotas_Click(object sender, EventArgs e)
        {
            if (datosNotas.Rows.Count > 0)
            {
                txtCIALM.Text = NotasConsultas.ListCIAlumnos(datosNotas.CurrentRow.Cells["Nombre"].Value.ToString(), datosNotas.CurrentRow.Cells["Apellido"].Value.ToString()).ToString();
                txtnota1.Text = datosNotas.CurrentRow.Cells["Nota1"].Value.ToString();
                txtnota2.Text = datosNotas.CurrentRow.Cells["Nota2"].Value.ToString();
                txtnota3.Text = datosNotas.CurrentRow.Cells["Nota3"].Value.ToString();
                txtnotaf.Text = datosNotas.CurrentRow.Cells["Notaf"].Value.ToString();
                txtCIMAT.Text = NotasConsultas.ListCIMateria(cbxMateria.Text).ToString();
            }
            else
            {
                MessageBox.Show("No hay datos");
            }
        }

        private void BtnGuardarNotas_Click(object sender, EventArgs e)
        {
            if (txtCIALM.Text == "" || txtCIMAT.Text == "")
            {
                MessageBox.Show("Debe Seleccionar un alumno");
            }
            else
            {
                Notas notas = new Notas();
                notas.txtNota1.Text = txtnota1.Text;
                notas.txtNota2.Text = txtnota2.Text;
                notas.txtNota3.Text = txtnota3.Text;
                notas.txtNotaf.Text = txtnotaf.Text;
                notas.txtCIDoc.Text = txtCIDOC.Text;
                notas.txtCIAlm.Text = txtCIALM.Text;
                notas.txtCIMat.Text = txtCIMAT.Text;
                notas.Show();
                this.Close();
            }
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panelCambiarPass.Visible = true;
            panelNotas.Visible = false;
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
        }

        private void BtnGuardarPass_Click(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == txtContraseña2.Text)
            {
                if (txtCIDOC.Text == txtCodCambiarPass.Text)
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
                        us1.Tipo = "doc";
                        LoginABML.Modificar(us1);
                        MessageBox.Show("Contraseña cambiada exitosamente");
                        Login volver = new Login();
                        this.Hide();
                        volver.Show();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
            panelCambiarPass.Visible = false;
            panelNotas.Visible = false;


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

        private void PanelCambiarPass_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelCambiarPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelNotas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PlataformaUser_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
