using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Pagamento
{
    public partial class FormDinheiro : Form
    {
        private string _recebido = null;
        private string _troco = null;
        private string _validaFecharCompra = null;
        public string Recebido { get { return _recebido; } }
        public string Troco { get { return _troco; } }
        public string ValidaFecharCompra { get { return _validaFecharCompra; } }

        public FormDinheiro()
        {
            InitializeComponent();

        }
        public FormDinheiro(string value)
        {
            InitializeComponent();
            lblTotal.Text = value;
        }

        private void FormDinheiro_Load(object sender, EventArgs e)
        {

        }
        //formatando string para moeda
        public static void Moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                    n = n.PadLeft(3, '0');
                    if (n.Length > 3 & n.Substring(0,1) == "0")
                    n = n.Substring(1, n.Length-1);
                    v = Convert.ToDouble(n) / 100;
                    txt.Text = string.Format("{0:N}", v);
                    txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception ex)
            {
                
            }
        }
        //calculando o troco do cliente
        public void CalculoTroco()
        {
            decimal ValorTotal = Convert.ToDecimal(lblTotal.Text);
            decimal ValorRecebido = 0;
            if (txtRecebido.Text != "")
            {
                ValorRecebido = Convert.ToDecimal(txtRecebido.Text);
                decimal troco = ValorRecebido - ValorTotal;
                lblTroco.Text = troco.ToString();
            }
            else
            {
                ValorRecebido = 0;
                lblTroco.Text = "0,00";
            }
        }
        //pegando valores para devolver para form PDV
        public void ValoresPDV()
        {
            this._recebido = txtRecebido.Text;
            this._troco = lblTroco.Text;
        }
        private void txtRecebido_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtRecebido);
            CalculoTroco();
            btnConfirma.Enabled = true;
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRecebido.Text))
            {
                MessageBox.Show("Qual valor recebido?");
            }
            else
            {
                decimal valorRecebido = decimal.Parse(txtRecebido.Text);
                decimal total = decimal.Parse(lblTotal.Text);
                if (valorRecebido >= total)
                {
                    this._validaFecharCompra = "2";
                    ValoresPDV();
                    this.Close();
                }
                else
                {
                    this._validaFecharCompra = "3";
                    ValoresPDV();
                    this.Close();
                }
                
            }
                
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this._validaFecharCompra = "1";
            this.Close();
        }

        private void FormFiado_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this._recebido = txtRecebido.Text;
            //this._troco = lblTroco.Text;
            this._validaFecharCompra = this._validaFecharCompra;
        }
    }
}
