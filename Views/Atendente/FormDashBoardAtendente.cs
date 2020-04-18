using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Supporte.Cache;
using Busines;


namespace Views
{
    public partial class FormDashBoardAtendente : Form
    {
        const decimal Desconto = 0;
        const int Qtd = 1;

        public FormDashBoardAtendente()
        {
            InitializeComponent();
        }

        private void FormDashBoardAtendente_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            lblUsuarioHeader.Text = UserLoginCache.Nome + " " + UserLoginCache.SobreNome;
            lblLogin.Text = "Olá, " + UserLoginCache.Nome + " " + UserLoginCache.SobreNome;
            lblCargo.Text = UserLoginCache.Cargo.ToString();
        }
        private void OpenFormPanel(object form)
        {
            if (this.container.Controls.Count > 0)
                this.container.Controls.RemoveAt(0);
            Form frm = form as Form;
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            this.container.Controls.Add(frm);
            this.container.Tag = frm;
            frm.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenFormPanel(new Formdashboard());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCadastroProduto frm = new FormCadastroProduto();
            frm.ShowDialog();
        }

        private void frenteDeCaixaPDVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPDV frm = new FormPDV();
            frm.ShowDialog();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a seção?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            FormValorInicial frm = new FormValorInicial();
            frm.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormCadastroVendedor frm = new FormCadastroVendedor();
            frm.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            OpenFormPanel(new Setting.FormSettings());
            painelAbrirCaixa.Visible = false;
        }
    }
}
