using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaInscripcion
{
    public partial class PlataformaAdmin : Form
    {
        private bool editar = false;
        public PlataformaAdmin()
        {
            InitializeComponent();
            datosAlumnos.DataSource = alumnosABML.listar();
        }
        void limpiarDocente()
        {
            txtCIDoc.Clear();
            txtNombreDoc.Clear();
            txtApellidosDoc.Clear();
            txtTelefonoDoc.Clear();
            txtDirecDoc.Clear();
        }
        void limpiarAlumno()
        {
            txtCIAlu.Clear();
            txtNombreAlu.Clear();
            txtApellAlumno.Clear();
            txtEdadAlu.Clear();
        }

        private void BtnSaveDocentes_Click(object sender, EventArgs e)
        {
           
            if (editar == false)
            {
                Docente doc = new Docente();

                doc.CI = int.Parse(txtCIDoc.Text);
                doc.Nombre = txtNombreDoc.Text;
                doc.Apellido = txtApellidosDoc.Text;
               // doc.Genero = txt;
                doc.Especialidad = cbxEspecialidadDoc.Text;
                doc.Telefono = int.Parse(txtTelefonoDoc.Text);
                doc.Direccion = txtDirecDoc.Text;



                //clsProductosABML.AgregarProducto(product);

                //datosGridView.DataSource = clsProductosABML.listar();
                //MessageBox.Show("Se agrego correctamente");
                //limpiar();
            }
            else
            {
                //Docente modificar = new Docente();

                //modificar.CI = int.Parse(txtCIDoc.Text);
                //modificar.Nombre = txtNombreDoc.Text;
                //modificar.Apellido = txtApellidosDoc.Text;
                //modificar.Genero;
                //modificar.Especialidad = txtEspecialidadDoc.Text;
                //modificar.Telefono = int.Parse(txtTelefonoDoc.Text);
                //modificar.Direccion = txtDirecDoc.Text;


                //clsProductosABML.ModificarProducto(modificar);

                //datosGridView.DataSource = clsProductosABML.listar();

                //MessageBox.Show("modificado");
                //limpiar();
            }
        }

        private void UpdateAdmin_Click(object sender, EventArgs e)
        {
            if (datosGridView.SelectedCells.Count > 0)
            {
                editar = true;
                txtCIDoc.Text = datosGridView.CurrentRow.Cells[""].Value.ToString();
                txtCIDoc.Enabled = false;
                txtNombreDoc.Text = datosGridView.CurrentRow.Cells[""].Value.ToString();
                txtApellidosDoc.Text = datosGridView.CurrentRow.Cells[""].Value.ToString();
                cbxEspecialidadDoc.Text = datosGridView.CurrentRow.Cells[""].Value.ToString();
                txtTelefonoDoc.Text = datosGridView.CurrentRow.Cells[""].Value.ToString();
                txtDirecDoc.Text = datosGridView.CurrentRow.Cells[""].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccione una fila para editar");
            }
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {
            if (datosGridView.SelectedCells.Count > 0)
            {
                //txtCodProducto.Text = datosGridView.CurrentRow.Cells["CodProducto"].Value.ToString();

                string message = "estas seguro";
                string captiion = "error";

                MessageBoxButtons mensaje = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(message, captiion, mensaje);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    string dato = txtCIDoc.Text;

                    //clsProductosABML.EliminarProducto(dato);
                    //datosGridView.DataSource = clsProductosABML.listar();
                    //limpiar();
                    //txtCodProducto.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila para poder eliminar");
            }
        }

        private void PanelProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAddAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void UpdateAlu_Click(object sender, EventArgs e)
        {

        }



        private void BtnSaveAlumno_Click_1(object sender, EventArgs e)
        {
            if (editar == false)
            {
                alumno GuardarAlu = new alumno();

                GuardarAlu.CI_Alumno = int.Parse(txtCIAlu.Text);
                GuardarAlu.Nombre = txtNombreAlu.Text;
                GuardarAlu.Apellido = txtApellAlu.Text;
                GuardarAlu.Genero = cbxGeneroAlu.Text;
                GuardarAlu.Edad = int.Parse(txtEdadAlu.Text);
                GuardarAlu.Grado = cbxGradoAlu.Text;
                GuardarAlu.AñoCurso = cbxAñoCursoAlu.Text;



                alumnosABML.Agregar(GuardarAlu);
                alumnosABML.Agregar2(GuardarAlu);
                datosAlumnos.DataSource = alumnosABML.listar();
                MessageBox.Show("se agrego correctamente");
                limpiarAlumno();
            }
            else
            {
                alumno modificarAlu1 = new alumno();
                alumno modificarAlu2 = new alumno();

                modificarAlu1.CI_Alumno = int.Parse(txtCIDoc.Text);
                modificarAlu1.Nombre = txtNombreDoc.Text;
                modificarAlu1.Apellido = txtApellidosDoc.Text;
                modificarAlu1.Grado = cbxGeneroAlu.Text;
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
                editar = true;
                txtCIAlu.Text = datosAlumnos.CurrentRow.Cells["CI_Alumno"].Value.ToString();
                txtNombreAlu.Text = datosAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellAlumno.Text = datosAlumnos.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEdadAlu.Text = datosAlumnos.CurrentRow.Cells["Edad"].Value.ToString();
                cbxGeneroAlu.Text = datosAlumnos.CurrentRow.Cells["Genero"].Value.ToString();
                cbxGradoAlu.Text = datosAlumnos.CurrentRow.Cells["Grado"].Value.ToString();
                cbxAñoCursoAlu.Text = datosAlumnos.CurrentRow.Cells["AñoCurso"].Value.ToString();

            }
            else
            {
                MessageBox.Show("seleccione una fila para editar");
            }
        }

        private void DeleteAlu_Click(object sender, EventArgs e)
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

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
