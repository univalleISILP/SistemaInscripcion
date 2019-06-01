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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            usuario u1 = new usuario();
            u1.CodUsuario = textBox1.Text;
            u1.Contraseña = textBox1.Text;
            if (LoginABML.Autenticar(u1) == "adm")
            {
                PlataformaAdmin pA = new PlataformaAdmin();
                pA.Show();
                this.Hide();
            }
            if (LoginABML.Autenticar(u1) == "doc")
            {
                MessageBox.Show("Docente");
            }
            if (LoginABML.Autenticar(u1) == "alm")
            {
                MessageBox.Show("Alumno");
            }
        }
    }
}
