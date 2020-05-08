using Busines.Pagamento;
using Supporte.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Produtos
{
    public partial class FormCartoes : Form
    {
        private bool IsNew;
        public FormCartoes()
        {
            InitializeComponent();
        }
        private void FormCartoes_Load(object sender, EventArgs e)
        {
            
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void msgSuccess(string msg)
        {
            lblSuc.Text = "      " + msg;
            lblSuc.Visible = true;
        }
        #region checkbox
        public BandeirasCartao Bandeira()
        {
            if (chkCielo.Checked == true)
            {
                return BandeirasCartao.Cielo;
            }
            else
            {
                return BandeirasCartao.GetNet;
            }
        }
        private void chkCielo_OnChange(object sender, EventArgs e)
        {
            chkStone.Checked = false;
            chkPagseguro.Checked = false;
            chkGetNet.Checked = false;
            txtDebito.Focus();
        }
        private void chkGetNet_OnChange(object sender, EventArgs e)
        {
            chkStone.Checked = false;
            chkPagseguro.Checked = false;
            chkCielo.Checked = false;
            txtDebito.Focus();
        }
        private void chkPagSeguro_OnChange(object sender, EventArgs e)
        {
            chkStone.Checked = false;
            chkCielo.Checked = false;
            chkGetNet.Checked = false;
            txtDebito.Focus();
        }
        private void chkStone_OnChange(object sender, EventArgs e)
        {
            chkCielo.Checked = false;
            chkPagseguro.Checked = false;
            chkGetNet.Checked = false;
            txtDebito.Focus();
        }
        #endregion
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (string.IsNullOrEmpty(txtDebito.Text) || string.IsNullOrEmpty(txtCredito.Text))
                {
                    msgError("Informe a taxa para DÉBITO ou CRÉDITO");
                }
                else if(!BusinesCartao.ValidaCartao(Bandeira()))
                {
                    rpta = BusinesCartao.CadastroCartao(BandeirasCartao.Cielo, decimal.Parse(txtDebito.Text), decimal.Parse(txtCredito.Text));
                }
                if (rpta.Equals("OK"))
                {
                    msgSuccess("Taxa Cadastrada com sucesso!");
                }
                else
                {
                    msgError(rpta + "Erro segundo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
