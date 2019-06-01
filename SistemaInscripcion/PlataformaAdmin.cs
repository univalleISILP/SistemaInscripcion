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
            
        }
        void limpiar()
        {
            txtCIDoc.Clear();
            txtNombreDoc.Clear();
            txtApellidosDoc.Clear();
            //txtGeneroDoc.Clear();
            //txtEpecialidadDoc.Clear();
            txtTelefonoDoc.Clear();
            txtDirecDoc.Clear();
        }
        char gen;
        private void BtnSaveDocentes_Click(object sender, EventArgs e)
        {
            if (radioVaron.Text == "varon")
            {
                gen = 'v';
            }
            if (radioMujer.Text == "mujer")
            {
                gen = 'm';
            }

            if (editar == false)
            {
                Docente doc = new Docente();

                doc.CI = int.Parse(txtCIDoc.Text);
                doc.Nombre = txtNombreDoc.Text;
                doc.Apellido = txtApellidosDoc.Text;
                doc.Genero = gen;
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
                limpiar();
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

        private void BtnSaveAlumno_Click(object sender, EventArgs e)
        {
            if (radioVaron.Text == "varon")
            {
                gen = 'v';
            }
            if (radioMujer.Text == "mujer")
            {
                gen = 'm';
            }

            if (editar == false)
            {
                alumno doc = new alumno();

                doc.CI_Alumno = int.Parse(txtCIDoc.Text);
                doc.Nombre = txtNombreDoc.Text;
                doc.Apellido = txtApellidosDoc.Text;
                doc.Genero = gen;
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
                limpiar();
            }
        }

        private void BtnDeleteAlu_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdateAlu_Click(object sender, EventArgs e)
        {

        }
    }
}
