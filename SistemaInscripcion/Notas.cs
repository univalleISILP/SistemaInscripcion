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
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            PlataformaUser pU = new PlataformaUser();
            Modulo mod = new Modulo();
            mod.CI_Alumno = int.Parse(txtCIAlm.Text);
            mod.CI_Docente = int.Parse(txtCIDoc.Text);
            mod.Clave_Materia = int.Parse(txtCIMat.Text);
            mod.Nota1 = Math.Round(double.Parse(txtNota1.Text), 0);
            mod.Nota2 = Math.Round(double.Parse(txtNota2.Text), 0);
            mod.Nota3 = Math.Round(double.Parse(txtNota3.Text), 0);
            double Notaf = Math.Round((double.Parse(txtNota1.Text)+double.Parse(txtNota2.Text)+double.Parse(txtNota3.Text))/3,0);
            mod.Notaf = Notaf;
            pU.txtCIDOC.Text = txtCIDoc.Text;
            pU.cbxAñoCurso.Text = NotasConsultas.ListarAño(int.Parse(txtCIAlm.Text));
            pU.cbxGrado.Text = NotasConsultas.ListarGrado(int.Parse(txtCIAlm.Text));
            pU.cbxMateria.Text = NotasConsultas.ListarNombreM(int.Parse(txtCIMat.Text));
            pU.panelNotas.Visible = true;
            MessageBox.Show("Notas agregadas exitosamente");
            ModuloABML.UpdateAlumno(mod);
            pU.Show();
            this.Close();
        }
    }
}
