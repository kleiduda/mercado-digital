using System;
using System.Windows.Forms;
using Supporte.Cache;
using System.Globalization;
using System.Data;
using Busines;
using System.Runtime.InteropServices;
using System.Linq;
using System.Collections;

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
            DadosSobreVendas();
            ValorInicialSangria();
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
        //valores de venda total
        public void DadosSobreVendas()
        {

            DataTable dt = new DataTable();
            dt = BusinesCaixa.ValoresVendaTotal(UserLoginCache.IdUser);
            decimal valorTotal = 0;

            if (dt != null)
            {
                var total = dt.AsEnumerable().Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var debito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 2).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var credito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 3).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var fiado = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 4).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));

                lblTotalVendas.Text = total.ToString("N2");
                lblVendaDinheiro.Text = dinheiro.ToString("N2");
                lblVendaDebito.Text = debito.ToString("N2");
                lblVendaFiado.Text = fiado.ToString("N2");
                lblVendasCredito.Text = credito.ToString("N2");
            }
        }
        //override para abrir o caixa
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                switch (keyData)
                {
                    case Keys.Control | Keys.O:
                        FormValorInicial frm = new FormValorInicial();
                        frm.ShowDialog();
                        DadosSobreVendas();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dtPeriodo = DateTime.Now;
            lblHoras.Text = dtPeriodo.ToLongTimeString();
            lblDia.Text = dtPeriodo.Day.ToString();
            lblDiaLong.Text = dtPeriodo.ToString("dddd", new CultureInfo("pt-BR")).ToUpper();
            //saudacao dependendo do horario
            int hora = DateTime.Now.Hour;
            var saudacoes = new string[] { "Boa Madrugada", "Bom dia", "Boa Tarde", "Boa Noite" };
            animaLabel.Show(lblBomDia, false, BunifuAnimatorNS.Animation.Transparent);
            lblBomDia.Text = saudacoes[hora / 6] + ", ";
            lbl_Mes.Text = dtPeriodo.ToString("MMMM", new CultureInfo("pt-BR")).ToUpper() + " - " + dtPeriodo.Year.ToString();
        }
        public void ValorInicialSangria()
        {
            DataTable dt = new DataTable();
            dt = BusinesCaixa.ValoresCaixa(UserLoginCache.IdUser, CaixaCache.IdCaixa);
            if (dt.Rows.Count > 0)
            {
                lbl_ValorInicial.Text = dt.Rows[0]["troco"].ToString();
            }
        }
        //calendario
        public void StyleCalendario()
        {
            //HEADER
            this.calendario.ShowHeader = true;
            this.calendario.Header.BackColor1 = System.Drawing.Color.WhiteSmoke;
            this.calendario.Header.TextColor = System.Drawing.Color.Black;
            //MES
            //FOOTER
            this.calendario.ShowFooter = false;
            //
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

        private void calendario_DayClick(object sender, Pabo.Calendar.DayClickEventArgs e)
        {
            DateTime datetime;
            datetime = DateTime.Parse(e.Date);
            DataTable dt = new DataTable();
            dt = BusinesCaixa.ValoresVendaTotal(UserLoginCache.IdUser);
            decimal valorTotal = 0;
            if (dt != null)
            {
                var total = dt.AsEnumerable().Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var debito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 2).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var credito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 3).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var fiado = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 4).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));

                lblTotalVendas.Text = total.ToString("N2");
                lblVendaDinheiro.Text = dinheiro.ToString("N2");
                lblVendaDebito.Text = debito.ToString("N2");
                lblVendaFiado.Text = fiado.ToString("N2");
                lblVendasCredito.Text = credito.ToString("N2");
            }
        }

        private void calendario_DaySelected(object sender, Pabo.Calendar.DaySelectedEventArgs e)
        {
        }
    }
}
