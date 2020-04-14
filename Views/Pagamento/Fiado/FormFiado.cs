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
using Busines.Pagamento;
using Supporte.Cache;


namespace Views.Pagamento
{
    public partial class FormFiado : Form
    {
        private bool IsNew = true;
        public FormFiado()
        {
            InitializeComponent();
        }
        public FormFiado(string value, string value2)
        {
            InitializeComponent();
            lblTotal.Text = value;
            txtIdPedido.Text = value2;
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
            linha.Visible = true;
        }
        //verificar dados fiado
        public void ValidarFiado()
        {
            BusinesFiado.VerificarValorFiado(Convert.ToInt32(lblMatricula.Text));
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
            try
            {
                if (BusinesCliente.ConsultaCadastroCliente(txtCpf.Text))
                {
                    BusinesCliente obj = new BusinesCliente();
                    var validaCliente = obj.MostrarDadosClientes(txtCpf.Text);
                    if (validaCliente == true)
                    {
                        MostrarDados();
                        lblMatricula.Text = CacheCliente.IdCliente.ToString();
                        lblBairro.Text = CacheCliente.Bairro.ToString();
                        lblCEP.Text = CacheCliente.CEP.ToString();
                        lblCidade.Text = CacheCliente.Cidade.ToString();
                        lblCPF.Text = CacheCliente.CPF.ToString();
                        lblEmail.Text = CacheCliente.Email.ToString();
                        lblEstado.Text = CacheCliente.UF.ToString();
                        lblFone.Text = CacheCliente.Fone.ToString();
                        lblNome.Text = CacheCliente.Nome.ToString() + " " + CacheCliente.SobreNome.ToString();
                        decimal saldoDevedor = Convert.ToDecimal(CacheCliente.SaldoDevedor.ToString());
                        decimal calculoSaldoAtualizado = saldoDevedor + Convert.ToDecimal(lblTotal.Text);
                        lblSaldoAnterior.Text = saldoDevedor.ToString();
                        lblSaldoAtual.Text = calculoSaldoAtualizado.ToString();
                        
                    }
                    else
                    {
                        lblSuc.Visible = false;
                        lblError.Visible = true;
                        msgError("Cliente não tem uma conta no sistema,\n deseja criar uma nova?");
                    }
                }
                else
                {
                    lblError.Visible = true;
                    lblSuc.Visible = false;
                    msgError("Cpf não encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.StackTrace);
            }
            
            
        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (string.IsNullOrEmpty(txtCpf.Text) && IsNew == true)
                {
                    lblError.Visible = true;
                    msgError("Nenhum cliente selecionado");
                }
                else
                {
                    if (BusinesCliente.ValidaCadastro(txtCpf.Text) && IsNew == true)
                    {
                        rpta = BusinesFiado.CadastrarContaFiado(Convert.ToInt32(lblMatricula.Text), Convert.ToInt32(txtIdPedido.Text), Convert.ToDecimal(lblSaldoAtual.Text));
                    }
                }
                if (rpta.Equals("OK"))
                {
                    msgSuccess("Fechou");
                }
                else
                {
                    msgError(rpta);
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
