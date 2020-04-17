using System;
using System.Windows.Forms;
using Busines;

namespace Views.PDV
{
    public partial class FormCpfNota : Form
    {
        private string _cpf = null;
        public string CPF { get { return _cpf; } }
        public FormCpfNota()
        {
            InitializeComponent();
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
                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    msgError("Preencha um cpf válido!");
                }
                else if (BusinesCliente.ValidaCadastro(txtCpf.Text))
                {
                    MessageBox.Show("Ja tem no banco entao vou usar esse mesmo");
                    this._cpf = txtCpf.Text;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nao tem, entao vou cadastrar");
                    rpta = BusinesCliente.CadastroCpf(txtCpf.Text);
                    this._cpf = txtCpf.Text;
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
