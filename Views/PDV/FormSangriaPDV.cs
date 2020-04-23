using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines;
using Supporte.Cache;

namespace Views
{
    public partial class FormSangriaPDV : Form
    {
        private bool IsNew;
        public FormSangriaPDV()
        {
            InitializeComponent();
        }
        private void FormValorInicial_Load(object sender, EventArgs e)
        {
            DadosValoresVendas();
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void DadosValoresVendas()
        {
            DataTable dtCaixa = new DataTable();
            dtCaixa = BusinesCaixa.ValorIncialSangria(UserLoginCache.IdUser);
            DataTable dt = new DataTable();
            dt = BusinesCaixa.ValoresVendaTotal(UserLoginCache.IdUser);
            var vendasDoDia = dt.AsEnumerable().Sum(x => x.Field<decimal>("TotalDeVendas"));
            var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var debito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 2).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var credito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 3).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var fiado = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 4).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var totalEmCaixa = vendasDoDia + Convert.ToDecimal(dtCaixa.Rows[0]["valor_inicial"].ToString());
            MessageBox.Show(totalEmCaixa.ToString());
            lblTotalEmCaixa.Text = totalEmCaixa.ToString("N2");
            lblVendaCredito.Text = credito.ToString();
            lblVendaDebito.Text = debito.ToString();
            lblVendaDinheiro.Text = dinheiro.ToString();
            lblVendaFiado.Text = fiado.ToString();
           
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            
            try
            {
                if (string.IsNullOrEmpty(txtValor.Text))
                {
                    msgError("Campo vazio, preencha com 0 (zero), se não tiver valor!");
                }
                else
                {
                    rpta = BusinesCaixa.FecharCaixa(UserLoginCache.IdUser, Convert.ToDecimal(lblTotalEmCaixa.Text), Convert.ToDecimal(txtValor.Text));
                }
                if (rpta == "OK")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show(rpta);
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
    }
}
