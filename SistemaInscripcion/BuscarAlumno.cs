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
    public partial class BuscarAlumno : Form
    {
        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void TxtCIalumnoBuscar_TextChanged(object sender, EventArgs e)
        {
            string dato = txtCIalumnoBuscar.Text;
            if (dato != "")
            {
                dbgListaAlumnosBuscar.DataSource = alumnosABML.listarXCI(dato);
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

        private void TxtNombrealumnoBuscar_TextChanged(object sender, EventArgs e)
        {
            string dato = txtNombrealumnoBuscar.Text;
            if (dato != "")
            {
                dbgListaAlumnosBuscar.DataSource = alumnosABML.listarXNombre(dato);
            }
            else
            {
                txtNombrealumnoBuscar.Text = "";
            }
        }

        private void TxtNombrealumnoBuscar_Leave(object sender, EventArgs e)
        {
            if (txtNombrealumnoBuscar.Text == "")
            {
                txtNombrealumnoBuscar.Text = "nombre";
                txtNombrealumnoBuscar.ForeColor = Color.Black;
            }
        }

        private void TxtNombrealumnoBuscar_Enter(object sender, EventArgs e)
        {
            if (txtNombrealumnoBuscar.Text == "nombre")
            {
                txtNombrealumnoBuscar.Text = "";
                txtNombrealumnoBuscar.ForeColor = Color.Black;
            }
        }
        private void BuscarAlumno_Load(object sender, EventArgs e)
        {
        }

        private void BtnCancelarBuscarAlu_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }
    }
}
