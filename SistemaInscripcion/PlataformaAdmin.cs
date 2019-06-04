using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion
{
    public partial class PlataformaAdmin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private bool editarAlu = false;
        private bool editarDoc = false;
        private bool editarMat = false;

        public PlataformaAdmin()
        {
            InitializeComponent();
            datosAlumnos.DataSource = alumnosABML.listar();
            datosDoc.DataSource = DocentesABML.listarDocente();
            datosMaterias.DataSource = MateriasABML.ListarMateria();
            datosModulo.DataSource = ModuloABML.Listar();

            cbxCIDoc.DataSource = DocentesABML.ListCIdocente();
            cbxCIAlu.DataSource = alumnosABML.ListCIAlumnos();
            cbxClaveMateria.DataSource = MateriasABML.ListCIMateria();

            cbxEspecialidadDoc.DataSource = MateriasABML.ListNomMaterias();

            panelInicioAdmin.Visible = true;

        }
        void limpiarDocente()
        {
            txtCIDoc.Clear();
            txtNombreDoc.Clear();
            txtApellidosDoc.Clear();
            txtTelefonoDoc.Clear();
            txtDirecDoc.Clear();
            cbxGeneroDoc.Text = "";
            cbxEspecialidadDoc.Text = "";
        }
        void limpiarAlumno()
        {
            txtCIAlu.Clear();
            txtNombreAlu.Clear();
            txtApellAlumno.Clear();
            txtEdadAlu.Clear();
            cbxAñoCursoAlu.Text = "";
            cbxGeneroAlu.Text = "";
            cbxGradoAlu.Text = "";
        }

        void limpiarMateria()
        {
            txtCodMateria.Clear();
            cbxNomMateria.Text = "";
        }

        void limpiarModulo()
        {
            cbxCIDoc.Text = "";
            cbxCIAlu.Text = "";
            cbxClaveMateria.Text = "";

        }
        void limpiarCambiarPass()
        {
            txtCodCambiarPass.Clear();
            txtContraseña1.Clear();
            txtContraseña2.Clear();
        }
        private void BtnAddDocentes_Click_1(object sender, EventArgs e)
        {
            panelDocentes.Visible = true;
            panelAlumnos.Visible = false;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = false;
            panelUsuarios.Visible = false;

            cbxEspecialidadDoc.DataSource = MateriasABML.ListNomMaterias();

            sidePanel.Height = btnAddDocentes.Height;
            sidePanel.Top = btnAddDocentes.Top;
            
        }

        

        private void PlataformaAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnAddAlumnos_Click(object sender, EventArgs e)
        {
            panelDocentes.Visible = false;
            panelAlumnos.Visible = true;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = false;
            panelUsuarios.Visible = false;
            sidePanel.Height = btnAddAlumnos.Height;
            sidePanel.Top = btnAddAlumnos.Top;
        }

        private void BtnAddMaterias_Click(object sender, EventArgs e)
        {
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelUsuarios.Visible = false;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = true;
            panelModulo.Visible = false;
            sidePanel.Height = btnAddMaterias.Height;
            sidePanel.Top = btnAddMaterias.Top;
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sidePanel.Height = button1.Height;
            sidePanel.Top = button1.Top;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            panelCambiarPass.Visible = true;
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = false;
            panelUsuarios.Visible = false;
            sidePanel.Height = button2.Height;
            sidePanel.Top = button2.Top;
        }

        private void PlataformaAdmin_Load(object sender, EventArgs e)
        {
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = false;
            panelUsuarios.Visible = true;
            DatosUsuarios.DataSource = LoginABML.listar();
        }


        private void BtnModulo_Click(object sender, EventArgs e)
        {
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = true;
            panelUsuarios.Visible = false;
            sidePanel.Height = btnModulo.Height;
            sidePanel.Top = btnModulo.Top;

            cbxCIDoc.DataSource = DocentesABML.ListCIdocente();
            cbxCIAlu.DataSource = alumnosABML.ListCIAlumnos();
            cbxClaveMateria.DataSource = MateriasABML.ListCIMateria();
        }

        private void BtnSaveMaterias_Click_1(object sender, EventArgs e)
        {
            if (editarMat == false)
            {
                Materia addMateria = new Materia();
                addMateria.ClaveM = int.Parse(txtCodMateria.Text);
                addMateria.Nombre = cbxNomMateria.Text;

                MateriasABML.Agregar(addMateria);

                datosMaterias.DataSource = MateriasABML.ListarMateria();
                limpiarMateria();

                MessageBox.Show("Materia Agregada");
            }
            else
            {
                Materia UpdateMateria = new Materia();
                UpdateMateria.ClaveM = int.Parse(txtCodMateria.Text);
                UpdateMateria.Nombre = cbxNomMateria.Text;
                MateriasABML.Update(UpdateMateria);

                datosMaterias.DataSource = MateriasABML.ListarMateria();
                txtCodMateria.Enabled = true;
                MessageBox.Show("Materia Modificada");
                limpiarMateria();
            }
        }

        private void BtnDeleteMaterias_Click_1(object sender, EventArgs e)
        {
            if (datosMaterias.SelectedCells.Count > 0)
            {
                string claveMat = datosMaterias.CurrentRow.Cells["ClaveM"].Value.ToString();


                string message = "estas seguro";
                string captiion = "error";

                MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captiion, mensaje);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int dato = int.Parse(claveMat);

                    MateriasABML.EliminarMateria(dato);

                    datosMaterias.DataSource = MateriasABML.ListarMateria();
                    limpiarMateria();
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila para poder eliminar");
            }
        }

        private void BtnUpdateMaterias_Click_1(object sender, EventArgs e)
        {
            if (datosMaterias.SelectedCells.Count > 0)
            {
                editarMat = true;
                txtCodMateria.Enabled = false;
                txtCodMateria.Text = datosMaterias.CurrentRow.Cells["ClaveM"].Value.ToString();
                cbxNomMateria.Text = datosMaterias.CurrentRow.Cells["Nombre"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila para editar");
            }
        }

        private void BtnGuardarPass_Click(object sender, EventArgs e)
        {
            if (txtContraseña1.Text == txtContraseña2.Text)
            {
                if (txtCambiarCod.Text == txtCodCambiarPass.Text)
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

        private void BtnGuardarModulo_Click(object sender, EventArgs e)
        {
            Modulo agregarModulo = new Modulo();
            agregarModulo.CI_Docente = int.Parse(cbxCIDoc.Text);
            agregarModulo.CI_Alumno = int.Parse(cbxCIAlu.Text);
            agregarModulo.Clave_Materia = int.Parse(cbxClaveMateria.Text);
            agregarModulo.Nota1 = 0;
            agregarModulo.Nota2 = 0;
            agregarModulo.Nota3 = 0;
            agregarModulo.Notaf = 0;

            ModuloABML.Agregar(agregarModulo);
            datosModulo.DataSource = ModuloABML.Listar();
        }

        private void BtnDeleteModulo_Click(object sender, EventArgs e)
        {
            if (datosModulo.SelectedCells.Count > 0)
            {
                string dato1 = datosModulo.CurrentRow.Cells["CI_Docente"].Value.ToString();
                string dato2 = datosModulo.CurrentRow.Cells["CI_Alumno"].Value.ToString();
                string dato3 = datosModulo.CurrentRow.Cells["Clave_Materia"].Value.ToString();


                string message = "estas seguro";
                string captiion = "error";

                MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captiion, mensaje);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Modulo mod = new Modulo();
                    mod.CI_Docente = int.Parse(dato1);
                    mod.CI_Alumno = int.Parse(dato2);
                    mod.Clave_Materia = int.Parse(dato3);


                    ModuloABML.Eliminar(mod);
                    datosModulo.DataSource = ModuloABML.Listar();
                    limpiarModulo();
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila para poder eliminar");
            }
        }

        private void BtnSaveAlumno_Click(object sender, EventArgs e)
        {
            if (editarAlu == false)
            {
                alumno GuardarAlu = new alumno();

                GuardarAlu.CI_Alumno = int.Parse(txtCIAlu.Text);
                GuardarAlu.Nombre = txtNombreAlu.Text;
                GuardarAlu.Apellido = txtApellAlumno.Text;
                GuardarAlu.Genero = cbxGeneroAlu.Text;
                GuardarAlu.Edad = int.Parse(txtEdadAlu.Text);
                GuardarAlu.Grado = cbxGradoAlu.Text;
                GuardarAlu.AñoCurso = cbxAñoCursoAlu.Text;

                
                alumnosABML.AgregarAlu1(GuardarAlu);
                alumnosABML.AgregarAlu2(GuardarAlu);

                usuario agregarAluUser = new usuario();
                agregarAluUser.CodUsuario = txtCIAlu.Text;
                agregarAluUser.Tipo = "alm";
                agregarAluUser.Contraseña = "12345";


                LoginABML.Agregar(agregarAluUser);
                datosAlumnos.DataSource = alumnosABML.listar();
                MessageBox.Show("se agrego correctamente");
                limpiarAlumno();
                txtCIAlu.Enabled = true;
                txtEdadAlu.Enabled = true;
                cbxGeneroAlu.Enabled = true;
            }
            else
            {
                alumno modificarAlu1 = new alumno();
                alumno modificarAlu2 = new alumno();

                modificarAlu1.CI_Alumno = int.Parse(txtCIAlu.Text);
                modificarAlu1.Nombre = txtNombreAlu.Text;
                modificarAlu1.Apellido = txtApellAlumno.Text;
                modificarAlu1.Grado = cbxGradoAlu.Text;
                modificarAlu1.AñoCurso = cbxAñoCursoAlu.Text;


                modificarAlu2.Genero = cbxGeneroAlu.Text;
                modificarAlu2.Edad = int.Parse(txtEdadAlu.Text);


                alumnosABML.Modificar(modificarAlu1);
                alumnosABML.Modificar(modificarAlu2);

                datosAlumnos.DataSource = alumnosABML.listar();

                txtCIAlu.Enabled = true;
                txtEdadAlu.Enabled = true;
                cbxGeneroAlu.Enabled = true;

                MessageBox.Show("modificado");
                limpiarAlumno();
            }
        }

        private void DeleteAlu_Click_1(object sender, EventArgs e)
        {
            if (datosAlumnos.SelectedCells.Count > 0)
            {
                string CIalu = datosAlumnos.CurrentRow.Cells["CI_Alumno"].Value.ToString();


                string message = "estas seguro";
                string captiion = "error";

                MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captiion, mensaje);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int dato = int.Parse(CIalu);

                    alumnosABML.Eliminar(dato);
                    alumnosABML.Eliminar2(dato);

                    datosAlumnos.DataSource = alumnosABML.listar();
                    limpiarAlumno();

                }
            }
            else
            {
                MessageBox.Show("seleccione una fila para poder eliminar");
            }
        }

        private void UpdateAlu_Click_1(object sender, EventArgs e)
        {
            if (datosAlumnos.SelectedCells.Count > 0)
            {
                editarAlu = true;
                txtCIAlu.Text = datosAlumnos.CurrentRow.Cells["CI_Alumno"].Value.ToString();
                txtNombreAlu.Text = datosAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellAlumno.Text = datosAlumnos.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEdadAlu.Text = datosAlumnos.CurrentRow.Cells["Edad"].Value.ToString();
                cbxGeneroAlu.Text = datosAlumnos.CurrentRow.Cells["Genero"].Value.ToString();
                cbxGradoAlu.Text = datosAlumnos.CurrentRow.Cells["Grado"].Value.ToString();
                cbxAñoCursoAlu.Text = datosAlumnos.CurrentRow.Cells["AñoCurso"].Value.ToString();

                txtCIAlu.Enabled = false;
                txtEdadAlu.Enabled = false;
                cbxGeneroAlu.Enabled = false;

            }
            else
            {
                MessageBox.Show("seleccione una fila para editar");
            }
        }

        private void BtnSaveDocentes_Click(object sender, EventArgs e)
        {
            if (txtCIDoc.Text == "" ||
               txtNombreDoc.Text == "" ||
               txtApellidosDoc.Text == "" ||
               cbxGeneroDoc.Text == "" ||
               cbxEspecialidadDoc.Text == "" ||
               txtTelefonoDoc.Text == "" ||
               txtDirecDoc.Text == "")
            {
                MessageBox.Show("deve ingresar datos");
            }
            else
            {
                if (editarDoc == false)
                {
                    Docente doc1 = new Docente();
                    doc1.CI = int.Parse(txtCIDoc.Text);
                    doc1.Nombre = txtNombreDoc.Text;
                    doc1.Apellido = txtApellidosDoc.Text;
                    doc1.Especialidad = cbxEspecialidadDoc.Text;
                    doc1.Genero = cbxGeneroDoc.Text;
                    doc1.Telefono = int.Parse(txtTelefonoDoc.Text);
                    doc1.Direccion = txtDirecDoc.Text;

                    DocentesABML.AgregarDocente1(doc1);
                    DocentesABML.AgregarDocente2(doc1);

                    txtCIDoc.Enabled = true;
                    
                    datosDoc.DataSource = DocentesABML.listarDocente();
                    usuario agregarAluUser = new usuario();
                    agregarAluUser.CodUsuario = txtCIDoc.Text;
                    agregarAluUser.Tipo = "doc";
                    agregarAluUser.Contraseña = "12345";
                    LoginABML.Agregar(agregarAluUser);
                    MessageBox.Show("Se agrego correctamente");
                    limpiarDocente();
                }
                else
                {
                    Docente modificarDoc1 = new Docente();
                    Docente modificarDoc2 = new Docente();

                    modificarDoc1.CI = int.Parse(txtCIDoc.Text);
                    modificarDoc1.Nombre = txtNombreDoc.Text;
                    modificarDoc1.Apellido = txtApellidosDoc.Text;
                    modificarDoc1.Especialidad = cbxEspecialidadDoc.Text;

                    modificarDoc2.Genero = cbxGeneroDoc.Text;
                    modificarDoc2.Telefono = int.Parse(txtTelefonoDoc.Text);
                    modificarDoc2.Direccion = txtDirecDoc.Text;


                    DocentesABML.ModificarDoc1(modificarDoc1);
                    DocentesABML.ModificarDoc2(modificarDoc2);

                    txtCIDoc.Enabled = true;
                    datosDoc.DataSource = DocentesABML.listarDocente();

                    MessageBox.Show("modificado");
                    limpiarDocente();
                }
            }
        }

        private void BtnDeleteDoc_Click_1(object sender, EventArgs e)
        {
            if (datosDoc.SelectedCells.Count > 0)
            {
                string CIdocente = datosDoc.CurrentRow.Cells["CI"].Value.ToString();

                string message = "estas seguro";
                string captiion = "error";

                MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captiion, mensaje);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int dato = int.Parse(CIdocente);

                    DocentesABML.EliminarDoc1(dato);
                    DocentesABML.EliminarDoc2(dato);
                    datosDoc.DataSource = DocentesABML.listarDocente();
                    limpiarDocente();
                    txtCIDoc.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila para poder eliminar");
            }
        }

        private void UpdateDoc_Click_1(object sender, EventArgs e)
        {
            if (datosDoc.SelectedCells.Count > 0)
            {
                editarDoc = true;
                txtCIDoc.Enabled = false;

                txtCIDoc.Text = datosDoc.CurrentRow.Cells["CI"].Value.ToString();
                txtNombreDoc.Text = datosDoc.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellidosDoc.Text = datosDoc.CurrentRow.Cells["Apellido"].Value.ToString();
                cbxGeneroDoc.Text = datosDoc.CurrentRow.Cells["Genero"].Value.ToString();
                cbxEspecialidadDoc.Text = datosDoc.CurrentRow.Cells["Especialidad"].Value.ToString();
                txtTelefonoDoc.Text = datosDoc.CurrentRow.Cells["Telefono"].Value.ToString();
                txtDirecDoc.Text = datosDoc.CurrentRow.Cells["Direccion"].Value.ToString();

            }
            else
            {
                MessageBox.Show("seleccione una fila para editar");
            }
        }

        private void BtnInicioAdmin_Click(object sender, EventArgs e)
        {
            panelInicioAdmin.Visible = true;
            panelCambiarPass.Visible = false;
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = false;
            panelUsuarios.Visible = true;

            sidePanel.Height = btnInicioAdmin.Height;
            sidePanel.Top = btnInicioAdmin.Top;

            DatosUsuarios.DataSource = LoginABML.listar();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnBuscarAlumno_Click(object sender, EventArgs e)
        {
            BuscarAlumno buscarAlumno = new BuscarAlumno();
            buscarAlumno.Show();
        }

        private void PanelCambiarPass_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelModulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelMaterias_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelAlumnos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelDocentes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelInicioAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CbxTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosUsuarios.DataSource =LoginABML.listarxTipo(cbxTipos.Text);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string cd = Microsoft.VisualBasic.Interaction.InputBox("Inserte la clave para eliminar");
            DatosUsuarios.DataSource = LoginABML.listar(cd);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string cd = Microsoft.VisualBasic.Interaction.InputBox("Inserte la clave para eliminar");
            LoginABML.Eliminar(cd);
            DatosUsuarios.DataSource = LoginABML.listar();
        }
    }
}
