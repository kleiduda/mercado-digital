using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private string _valor = null;
        private DataTable _dtClientes;
        private string _nomeCliente = null;
        private string _cpfCliente = null;
        public string NomeCliente { get { return _nomeCliente; } }
        public string CpfCliente { get { return _cpfCliente; } }

        public string Valor
        {
            get { return _valor; }
        }
        public DataTable DtClientes { get { return _dtClientes; } }

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
            ListarClientes();
        }
        //carregar dados dos clientes
        public void ListarClientes()
        {
            this._dtClientes = BusinesCliente.ListarClientes();
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
            lblTitle.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label16.Visible = true;
            lblTotalT.Visible = true;
            label3.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            lbl.Visible = true;
            lblSaldoAnterior.Visible = true;
            lblSaldoAtual.Visible = true;
            linha.Visible = true;
        }
        //esconder dados
        public void EsconderDados()
        {
            lblBairro.Visible = false;
            lblCEP.Visible = false;
            lblCidade.Visible = false;
            lblCPF.Visible = false;
            lblEmail.Visible = false;
            lblEstado.Visible = false;
            lblFone.Visible = false;
            lblMatricula.Visible = false;
            lblNome.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label16.Visible = false;
            label3.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            lbl.Visible = false;
            lblSaldoAnterior.Visible = false;
            lblSaldoAtual.Visible = false;
            linha.Visible = false;
        }
        //verificar dados fiado
        public void ValidarFiado()
        {
            BusinesFiado.VerificarValorFiado(Convert.ToInt32(lblMatricula.Text));
        }
        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Fiado.FormCadastroCliente frm = new Fiado.FormCadastroCliente(txtIdPedido.Text, lblTotal.Text);
            frm.ShowDialog();
            this.Enabled = true;
            string respostaCadastro = frm.Resposta;
            if (respostaCadastro.Equals("OK"))
            {
                this._valor = "2";
                this.Close();
            }
        }
        private void ConsultaCpf_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = _dtClientes.AsEnumerable().Where(x => x.Field<string>("cpf") == txtCpf.Text)
                    .Select(k =>
                {
                    var row = _dtClientes.NewRow(); row.ItemArray = new object[]
                      { k.Field<string>("cpf"),
                      k.Field<string>("fone"),
                      k.Field<string>("email"),
                      k.Field<string>("uf"),
                      k.Field<string>("bairro"),
                      k.Field<string>("cep"),
                      k.Field<string>("nome"),
                      k.Field<string>("sobre_nome"),
                      k.Field<Int32>("id_cliente"),
                      k.Field<decimal>("saldo_devedor")
                      };
                    return row;
                });

                if (dt.Any())
                {
                    MostrarDados();
                    DataTable dtNew = dt.CopyToDataTable();
                    lblCPF.Text = dtNew.Rows[0][0].ToString();
                    lblFone.Text = dtNew.Rows[0][1].ToString();
                    lblEmail.Text = dtNew.Rows[0][2].ToString();
                    lblEstado.Text = dtNew.Rows[0][3].ToString();
                    lblBairro.Text = dtNew.Rows[0][4].ToString();
                    lblCEP.Text = dtNew.Rows[0][5].ToString();
                    lblNome.Text = dtNew.Rows[0][6].ToString() + " " + dtNew.Rows[0][7].ToString();
                    lblMatricula.Text = dtNew.Rows[0][8].ToString();
                    decimal valor = 0;
                    for (int i = 0; i < dtNew.Rows.Count; i++)
                    {
                         valor += decimal.Parse(dtNew.Rows[i][9].ToString());
                    }
                    
                    //
                    lblSaldoAnterior.Text = valor.ToString();
                    var total = valor + decimal.Parse(lblTotal.Text);
                    lblSaldoAtual.Text = total.ToString();
                }
                else
                {
                    lblError.Visible = true;
                    lblSuc.Visible = false;
                    msgError("CPF não encontrado");
                    EsconderDados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }



        }
        //private void btnConsultar_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        dt = BusinesCliente.ListarCadastro(txtCpf.Text);
        //        DataTable dtFiado = new DataTable();
        //        dtFiado = BusinesCliente.MostrarDadosFiado(txtCpf.Text);
        //        string rpta = "";
        //        bool validaCliente = true;
        //        if (lblCPF.Text == txtCpf.Text)
        //        {
        //            MessageBox.Show("Cliente já esta na tela!");
        //        }
        //        else if (BusinesCliente.ConsultaCadastroCliente(txtCpf.Text))
        //        {
        //            if (validaCliente == true)
        //            {
        //                MostrarDados();
        //                lblMatricula.Text = dt.Rows[0]["id_cliente"].ToString();
        //                lblBairro.Text = dt.Rows[0]["bairro"].ToString();
        //                lblCEP.Text = dt.Rows[0]["cep"].ToString();
        //                lblCidade.Text = CacheCliente.Cidade.ToString();
        //                lblCPF.Text = CacheCliente.CPF.ToString();
        //                lblEmail.Text = CacheCliente.Email.ToString();
        //                lblEstado.Text = CacheCliente.UF.ToString();
        //                lblFone.Text = CacheCliente.Fone.ToString();
        //                lblNome.Text = CacheCliente.Nome.ToString() + " " + CacheCliente.SobreNome.ToString();
        //                decimal saldoDevedor = decimal.Parse(dt.Rows[0]["saldo_devedor"].ToString());

        //                decimal calculoSaldoAtualizado = saldoDevedor + Convert.ToDecimal(lblTotal.Text);
        //                lblSaldoAnterior.Text = saldoDevedor.ToString();
        //                lblSaldoAtual.Text = calculoSaldoAtualizado.ToString();
        //            }
        //            else
        //            {
        //                lblSaldoAtual.Visible = true;
        //                lblSaldoAnterior.Visible = true;
        //                lblSaldoAnterior.Text = "0";
        //                lblSaldoAtual.Text = lblTotal.Text;
        //                lblSuc.Visible = false;
        //                lblError.Visible = true;
        //                if (MessageBox.Show("Criar uma nova conta para o cliente?", "Cliente não tem uma conta...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //                {
        //                   rpta = BusinesFiado.CadastrarContaFiado(
        //                       Convert.ToInt32(dt.Rows[0]["id_cliente"].ToString()),
        //                       Convert.ToInt32(txtIdPedido.Text), 
        //                       Convert.ToDecimal(lblSaldoAtual.Text));
        //                }
        //                if (rpta.Equals("OK"))
        //                {
        //                    lblError.Visible = false;
        //                    lblSuc.Visible = true;
        //                    this.Close();
        //                }
        //                else
        //                {
        //                    lblError.Visible = true;
        //                    lblSuc.Visible = false;
        //                    MessageBox.Show(rpta);
        //                }
        //            }
        //        }
        //        else
        //        {
        //            lblError.Visible = true;
        //            lblSuc.Visible = false;
        //            msgError("Cpf não encontrado! Faça um novo Cadastro");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message, ex.StackTrace);
        //    }


        //}
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    lblError.Visible = true;
                    msgError("Nenhum cliente selecionado");
                }
                else
                {
                    rpta = BusinesFiado.AtualizarContaFiado(int.Parse(txtIdPedido.Text), int.Parse(lblMatricula.Text), decimal.Parse(lblTotal.Text));
                }
                if (rpta.Equals("OK"))
                {
                    this._valor = "2";
                    this.Close();
                }
                else
                {
                    msgError(rpta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this._valor = "1";
            this.Close();
        }

        private void FormFiado_FormClosing(object sender, FormClosingEventArgs e)
        {
            this._nomeCliente = lblNome.Text;
            this._cpfCliente = lblCPF.Text;
            this._valor = this._valor;
        }
    }
}
