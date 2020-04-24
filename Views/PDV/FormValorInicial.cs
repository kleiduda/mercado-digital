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
            dt = BusinesCaixa.ValoresCaixa(UserLoginCache.IdUser, CaixaCache.IdCaixa);
            DataTable dtCaixa = new DataTable();
            dtCaixa = BusinesCaixa.VerificarCaixasAbertos(UserLoginCache.IdUser);
            //var valor = dtCaixa.AsEnumerable().Where(x => x.Field<int>("id_vendedor") == 13);
            if (dtCaixa.Rows.Count > 0)
            {
                if (MessageBox.Show("Caixa Anterior ainda esta aberto, continuar?", "CAIXA ANTERIOR NÃO FOI FECHADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    FormPDV frm = new FormPDV();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblValorInicial.Text = "Seu caixa esta sendo iniciado com valor de R$" + Convert.ToString(CaixaCache.Troco) + ".\n Altere se for necessário.";
                    txtValor.Text = CaixaCache.Troco.ToString();

                }

            }
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
                    rpta = BusinesCaixa.AberturaCaixa(Convert.ToDecimal(txtValor.Text), UserLoginCache.IdUser, Supporte.Enums.StatusCaixa.Aberto);
                }
                if (rpta == "OK")
                {
                    //msgError("Blz garoto, tudo ok");
                    FormPDV frm = new FormPDV();
                    frm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(rpta);
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
        }
    }
}
