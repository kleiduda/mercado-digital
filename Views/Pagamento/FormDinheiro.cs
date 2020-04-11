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

        private void txtRecebido_TextChanged(object sender, EventArgs e)
        {
            Moeda(ref txtRecebido);
            CalculoTroco();
        }
    }
}
