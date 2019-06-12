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
    public partial class ReporteNotasAlumno : Form
    {
        public ReporteNotasAlumno()
        {
            InitializeComponent();
        }

        private void ReporteNotasAlumno_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'MisDatosAlumnoNotas.TablaNotasAlumno' Puede moverla o quitarla según sea necesario.
            this.TablaNotasAlumnoTableAdapter.Fill(this.MisDatosAlumnoNotas.TablaNotasAlumno);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
