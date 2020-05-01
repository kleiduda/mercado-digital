using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Busines;
using Supporte.Cache;
using Supporte.Enums;

namespace Views
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        //DLL para mover o form com mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        //liberando movimento com mouseDow
        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuário") { txtUser.Text = ""; txtUser.ForeColor = Color.Black; }
        }
        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "") { txtUser.Text = "Usuário"; txtUser.ForeColor = Color.Gray; }
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Senha") { txtPassword.Text = ""; txtPassword.ForeColor = Color.Black; txtPassword.UseSystemPasswordChar = true; }
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "") { txtPassword.Text = "Senha"; txtPassword.ForeColor = Color.Gray; txtPassword.UseSystemPasswordChar = false; }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //mesagem de erro login
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "Usuário")
            {
                BusinesUsuario obj = new BusinesUsuario();
                var validateUser = obj.LoginUser(txtUser.Text, txtPassword.Text);
                if (validateUser == true)
                {
                    if (UserLoginCache.Cargo == 1)
                    {
                        Administrador.FormAdministrador mainMenu = new Administrador.FormAdministrador();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    if (UserLoginCache.Cargo == 2)
                    {
                        FormDashBoardAtendente mainMenu = new FormDashBoardAtendente();
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                }
                else
                {
                    msgError("Usuário ou Senha inválido, verifique e tente novamente!");
                }
            }
            else { msgError("Por favor entre com seu USUÁRIO!"); }
            if (txtPassword.Text != "Senha") { } else { msgError("Por favor entre com sua SENHA"); }
        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUser.Text = "Usuário";
            txtPassword.Text = "Senha";
            txtPassword.UseSystemPasswordChar = false;
            lblError.Visible = false;
            this.Show();
            //txtUser.Focus();
        }
    }
}
