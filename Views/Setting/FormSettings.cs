using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Setting
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
        private void OpenFormPanel(object form)
        {
            if (this.panelResult.Controls.Count > 0)
                this.panelResult.Controls.RemoveAt(0);
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.panelResult.Controls.Add(frm);
            this.panelResult.Tag = frm;
            frm.Show();
        }
        private void btnGeral_Click(object sender, EventArgs e)
        {
            OpenFormPanel( new SettingGeral());
        }
    }
}
