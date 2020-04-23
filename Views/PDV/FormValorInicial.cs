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
    public partial class FormValorInicial : Form
    {
        private bool IsNew;
        public FormValorInicial()
        {
            InitializeComponent();
        }
        private void FormValorInicial_Load(object sender, EventArgs e)
        {
            ValorInicial();
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void ValorInicial()
        {
            DataTable dt = new DataTable();
            dt = BusinesCaixa.ValorInicial(UserLoginCache.IdUser);
            if (dt.Rows.Count > 0)
            {
                if (CaixaCache.Condicao == 1)
                {
                    if (MessageBox.Show("Caixa Anterior ainda esta aberto, continuar?", "CAIXA ANTERIOR NÃO FOI FECHADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        FormPDV frm = new FormPDV();
                        frm.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    lblValorInicial.Text = "Seu caixa esta sendo iniciado com valor de R$" + Convert.ToString(CaixaCache.ValorInicial) + ".\n Altere se for necessário.";
                    txtValor.Text = CaixaCache.ValorInicial.ToString();

                }
                
            }
            //BusinesCaixa obj = new BusinesCaixa();
            //var validaValor = obj.ValorInicial();
            //if (validaValor == true)
            //{
            //    lblValorInicial.Text = "Seu caixa esta sendo iniciado com valor de R$" + Convert.ToString(CaixaCache.ValorInicial) + ".\n Altere se for necessário.";
            //    txtValor.Text = Convert.ToString(CaixaCache.ValorInicial);
            //}
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
                    rpta = BusinesCaixa.AberturaCaixa(Convert.ToDecimal(txtValor.Text),UserLoginCache.IdUser);
                }
                if (rpta == "OK")
                {
                    FormPDV frm = new FormPDV();
                    frm.ShowDialog();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
        }
    }
}
