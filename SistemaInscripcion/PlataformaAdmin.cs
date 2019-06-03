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
            txtClaveMateria.Clear();
            txtNombreMateria.Clear();
        }

        void limpiarModulo()
        {
            cbxCIDoc.Text = "";
            cbxCIAlu.Text = "";
            cbxClaveMateria.Text = "";

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


                    datosDoc.DataSource = DocentesABML.listarDocente();
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


                    datosDoc.DataSource = DocentesABML.listarDocente();

                    MessageBox.Show("modificado");
                    limpiarDocente();
                }
            }
        }

        private void UpdateAdmin_Click(object sender, EventArgs e)
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

        private void BtnSaveAlumno_Click_1(object sender, EventArgs e)
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
                datosAlumnos.DataSource = alumnosABML.listar();
                MessageBox.Show("se agrego correctamente");
                limpiarAlumno();
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

                MessageBox.Show("modificado");
                limpiarAlumno();
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

       private void BtnDeleteDoc_Click(object sender, EventArgs e)
        {
            if (datosDoc.SelectedCells.Count > 0)
            {
                txtCIDoc.Text = datosDoc.CurrentRow.Cells["CI"].Value.ToString();

                string message = "estas seguro";
                string captiion = "error";

                MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captiion, mensaje);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int dato = int.Parse(txtCIDoc.Text);

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

        private void BtnAddDocentes_Click(object sender, EventArgs e)
        {
            panelDocentes.Visible = true;
            panelAlumnos.Visible = false;
            panelBuscarAlumnos.Visible = false;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = false;

        }

        private void TxtCIalumnoBuscar_TextChanged_1(object sender, EventArgs e)
        {
            string datoCIALU = txtCIalumnoBuscar.Text;
            if (datoCIALU != "")
            {
                dbgListaAlumnosBuscar.DataSource = alumnosABML.listarXci(datoCIALU);
            }
            else
            {
                txtCIalumnoBuscar.Text = "";
            }
        }

        private void TxtCIalumnoBuscar_Leave(object sender, EventArgs e)
        {
            if (txtCIalumnoBuscar.Text == "")
            {
                txtCIalumnoBuscar.Text = "numero";
                txtCIalumnoBuscar.ForeColor = Color.Black;
            }
        }

        private void TxtCIalumnoBuscar_Enter(object sender, EventArgs e)
        {
            if (txtCIalumnoBuscar.Text == "numero")
            {
                txtCIalumnoBuscar.Text = "";
                txtCIalumnoBuscar.ForeColor = Color.Black;
            }
        }

        private void DeleteAlu_Click_1(object sender, EventArgs e)
        {
            if (datosAlumnos.SelectedCells.Count > 0)
            {
                txtCIAlu.Text = datosAlumnos.CurrentRow.Cells["CI_Alumno"].Value.ToString();


                string message = "estas seguro";
                string captiion = "error";

                MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captiion, mensaje);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    int dato = int.Parse(txtCIAlu.Text);

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
            panelBuscarAlumnos.Visible = true;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = false;

        }

        private void BtnAddMaterias_Click(object sender, EventArgs e)
        {
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelBuscarAlumnos.Visible = false;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = true;
            panelModulo.Visible = false;

        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panelCambiarPass.Visible = true;
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelBuscarAlumnos.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = false;
        }

        private void BtnGuardarContraseña_Click(object sender, EventArgs e)
        {            
            if (txtContraseña1.Text == txtContraseña2.Text)
            {
                usuario us1 = new usuario();
                us1.CodUsuario = TxtCambiarCod.Text;
                us1.Contraseña = txtContraseña1.Text;
                us1.Tipo = "adm";
                LoginABML.Modificar(us1);
                MessageBox.Show("Contraseña cambiada exitosamente");
            }
            else
                MessageBox.Show("Las Contraseñas deben coincidir");
           
        }

        private void PlataformaAdmin_Load(object sender, EventArgs e)
        {
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelBuscarAlumnos.Visible = false;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = false;
        }

        private void BtnSaveMateria_Click(object sender, EventArgs e)
        {
            
        }

      
        private void BtnDeleteMateria_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnUpdateMateria_Click(object sender, EventArgs e)
        {
           
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

        }

        private void BtnModulo_Click(object sender, EventArgs e)
        {
            panelDocentes.Visible = false;
            panelAlumnos.Visible = false;
            panelBuscarAlumnos.Visible = false;
            panelCambiarPass.Visible = false;
            panelMaterias.Visible = false;
            panelModulo.Visible = true;
        }

        private void BtnDeleteModulo_Click(object sender, EventArgs e)
        {
            if (datosModulo.SelectedCells.Count > 0)
            {
                string dato1 = datosDoc.CurrentRow.Cells["CI"].Value.ToString();
                string dato2 = datosDoc.CurrentRow.Cells["CI"].Value.ToString();
                string dato3 = datosDoc.CurrentRow.Cells["CI"].Value.ToString();


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

        private void BtnSaveMaterias_Click(object sender, EventArgs e)
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

        private void BtnDeleteMaterias_Click(object sender, EventArgs e)
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

        private void BtnUpdateMaterias_Click(object sender, EventArgs e)
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
    }
}
