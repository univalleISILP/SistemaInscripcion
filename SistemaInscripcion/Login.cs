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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            usuario us = new usuario();
            us.CodUsuario = txtUserName.Text;
            us.Contraseña = txtPassword.Text;
            if (LoginABML.Autenticar(us)=="admin")
            {
                PlataformaAdmin pA = new PlataformaAdmin();
                pA.txtCambiarCod.Text = txtUserName.Text;
                pA.lblTexto.Text = "Administrador";
                pA.Show();
                this.Hide();
            }
            if (LoginABML.Autenticar(us) == "doc")
            {
                PlataformaUser pU = new PlataformaUser();
                pU.Show();
                this.Hide();
            }
            if (LoginABML.Autenticar(us) == "alm")
            {
                PlataformaAlumno pAL = new PlataformaAlumno();
                pAL.Show();
                this.Hide();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            panelLogin.Left += 20;
            if (panelLogin.Left >= 800)
            {
                timer1.Stop();
                TopMost = false;
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
                //PanelRegistrarse.Left -= 10;
                //if (PanelRegistrarse.Left <= 286)
                //{
                //    timer2.Stop();
                //}
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel1_MouseEnter(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "UserName";
                txtUserName.ForeColor = Color.Gray;
            }
        }

        private void TxtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void TxtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "UserName")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.White;

                lblusuario.Visible = false;
                lblpassword.Visible = false;
            }
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = false;
                lblusuario.Visible = false;
                lblpassword.Visible = false;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
