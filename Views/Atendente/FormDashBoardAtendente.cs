using System;
using System.Windows.Forms;
using Supporte.Cache;
using System.Globalization;

namespace Views
{
    public partial class FormDashBoardAtendente : Form
    {
        const decimal Desconto = 0;
        const int Qtd = 1;
        string PeriodoDia = null;

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
            lblLogin.Text = UserLoginCache.Nome.ToLower() + " " + UserLoginCache.SobreNome.ToLower();
            lblCargo.Text = UserLoginCache.Cargo.ToString();
            timer1.Enabled = true;
            bunifuTransition1.Show(pData, false, BunifuAnimatorNS.Animation.Transparent);
           
            StyleCalendario();
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            DateTime dtPeriodo = DateTime.Now;
            lblHoras.Text = dtPeriodo.ToLongTimeString();
            lblDia.Text = dtPeriodo.Day.ToString();
            lblDiaLong.Text = dtPeriodo.ToString("dddd", new CultureInfo("pt-BR")).ToUpper();
            //saudacao dependendo do horario
            int hora = DateTime.Now.Hour;
            var saudacoes = new string[]{"Boa Madrugada", "Bom dia", "Boa Tarde", "Boa Noite" };
            animaLabel.Show(lblBomDia, false, BunifuAnimatorNS.Animation.Transparent);
            lblBomDia.Text = saudacoes[hora / 6] + ", ";
            lbl_Mes.Text = dtPeriodo.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper() + " - " + dtPeriodo.Year.ToString(); 
        }
        //calendario
        public void StyleCalendario()
        {
            //this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(242,242,242);
            //this.monthCalendar1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(0)), ((System.Byte)(192)));
            //this.monthCalendar1.TitleBackColor = System.Drawing.Color.Purple;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            FormValorInicial frm = new FormValorInicial();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente encerrar a seção?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
