using Supporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Administrador
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }
        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            LoadUsuario();
        }
        //adicionando uma picturebox redonda

        public void OvalPictureBox()
        {
            this.BackColor = Color.DarkBlue;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, 45, 45);
                fotoUsuario.Region = new Region(gp);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, 10, 10);

            }
        }

        //
        //dados de usuario
        private void LoadUsuario()
        {
            lblUsuario.Text = "Olá, " + UserLoginCache.Nome.ToLower() + " " + UserLoginCache.SobreNome.ToLower();
            fotoUsuario.LoadAsync(@"C:\Users\DELL\Pictures\sistema\" + UserLoginCache.Foto.ToString());
        }

    }
}
