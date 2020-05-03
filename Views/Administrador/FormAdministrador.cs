using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void imageLogo_Click(object sender, EventArgs e)
        {
            var frm = new FORMTESTE();
            frm.TopMost = true;
            frm.BringToFront();
            frm.TopMost = false;
            frm.MdiParent = this;
            frm.Show();
        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(FORMTESTE))
                {
                    form.Activate();
                    return;
                }
                FormAdministrador f = new FormAdministrador();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
