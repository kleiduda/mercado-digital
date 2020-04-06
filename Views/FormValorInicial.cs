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
            BusinesCaixa obj = new BusinesCaixa();
            var validaValor = obj.ValorInicial();
            if (validaValor == true)
            {
                lblValorInicial.Text = "Seu caixa esta sendo iniciado com valor de R$" + Convert.ToString(CaixaCache.ValorInicial) + ".\n Altere se for necessário.";
                txtValor.Text = Convert.ToString(CaixaCache.ValorInicial);
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
                    rpta = BusinesCaixa.InsertValoresCaixa(Convert.ToDecimal(txtValor.Text),UserLoginCache.IdUser);
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
