using System;
using System.Windows.Forms;
using Busines.Validacoes;
using Busines.NotaFiscal;

namespace Views.PDV
{
    public partial class FormCpfNota : Form
    {
        private string _cpf = null;
        public string CPF { get { return _cpf; } }
        public int IdPedido;
        public FormCpfNota()
        {
            InitializeComponent();
        }
        public FormCpfNota(int value)
        {
            InitializeComponent();
            IdPedido = value;
        }

        private void FormCpfNota_Load(object sender, EventArgs e)
        {

        }
        //mensagens de erro e sucesso
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
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (!Validacoes.ValidaCPF(txtCpf.Text))
                {
                    msgError("CPF INVÁLIDO!");
                }
                else
                {
                    rpta = BusinesNotaFiscal.CadastroCpfNota(txtCpf.Text, IdPedido);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
    }
}
