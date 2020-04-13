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

namespace Views.Pagamento
{
    public partial class FormFiado : Form
    {
        public FormFiado()
        {
            InitializeComponent();
        }
        public FormFiado(string value)
        {
            InitializeComponent();
            lblTotal.Text = value;
        }

        private void FormFiado_Load(object sender, EventArgs e)
        {
            
        }
        //mensagens
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
        //mostrando os dados 
        public void MostrarDados()
        {
            lblBairro.Visible = true;
            lblCEP.Visible = true;
            lblCidade.Visible = true;
            lblCPF.Visible = true;
            lblEmail.Visible = true;
            lblEstado.Visible = true;
            lblFone.Visible = true;
            lblMatricula.Visible = true;
            lblNome.Visible = true;
            label1.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label16.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            lbl.Visible = true;
            lblSaldoAnterior.Visible = true;
            lblSaldoAtual.Visible = true;
        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Pagamento.Fiado.FormCadastroCliente frm = new Fiado.FormCadastroCliente();
            frm.ShowDialog();
            this.Enabled = true;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            DataTable dt = new DataTable();
            dt = BusinesCliente.MostrarDadosCliente(txtCpf.Text);
            try
            {
                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    msgError("Campo CPF vazio!");
                }
                else
                {
                    lblNome.Text = dt.Rows[0]["nome"].ToString() + " " + dt.Rows[0]["sobre_nome"].ToString();
                    lblCPF.Text = dt.Rows[0]["cpf"].ToString();
                    lblFone.Text = dt.Rows[0]["fone"].ToString();
                    lblCEP.Text = dt.Rows[0]["cep"].ToString();
                    lblBairro.Text = dt.Rows[0]["bairro"].ToString();
                    lblCidade.Text = dt.Rows[0]["cidade"].ToString();
                    lblEstado.Text = dt.Rows[0]["uf"].ToString();
                    lblEmail.Text = dt.Rows[0]["email"].ToString();
                    lblSaldoAnterior.Text = lblTotal.Text;
                    MostrarDados();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
