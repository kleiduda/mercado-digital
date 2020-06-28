using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Setting;

namespace Views.Produtos
{
    public partial class FormConfig : Form
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void btnConfigImagePath_Click(object sender, EventArgs e)
        {
            SettingGeral frm = new SettingGeral();
            frm.ShowDialog();
        }

        private void btnImportProducts_Click(object sender, EventArgs e)
        {
            FormImportProduto frm = new FormImportProduto();
            frm.ShowDialog();
        }
    }
}
