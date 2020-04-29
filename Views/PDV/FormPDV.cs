using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Busines;
using Supporte.Cache;
using Supporte.Enums;
using Views.PDV;
using Views.Pagamento;
using System.Linq;

namespace Views
{
    public partial class FormPDV : Form
    {
        const decimal Desconto = 0;
        int Qtd = 1;
        private bool IsNew = true;
        private bool CompraEmAndamento = true;
        private string CpfNaNota = null;

        public FormPDV()
        {
            InitializeComponent();
        }

        private void FormPDV_Load(object sender, EventArgs e)
        {
            IdCaixaAtual();
            VerificarComprasAbertas();
            DadosVendedor();
            ListarProdutos();
            ImagemCupom();
            
        }
        //IdCaixaAtual
        public void IdCaixaAtual()
        {
            DataTable dt = new DataTable();
            dt = BusinesCaixa.PegarIdCaixaAtual(UserLoginCache.IdUser);
            idCaixa.Text = dt.AsEnumerable().OrderByDescending(x=>x.Field<int>("id")).Select(r=>r.Field<int>("id")).First().ToString();
        }
        public void ImagemCupom()
        {
            if (lblCompraAberta.Text == "Caixa Livre...")
            {
                imageStore.Visible = true;
                lblCaixaLivreCupom.Visible = true;
            }
            else
            {
                imageStore.Visible = false;
                lblCaixaLivreCupom.Visible = false;
            }
        }

        //habilitar e desabilitar pagamentos
        public void EnableBtn()
        {
            btnFiado.Enabled = true;
            btnDinheiro.Enabled = true;
            btnCredito.Enabled = true;
            btnDebito.Enabled = true;
            btnCpfNaNota.Enabled = true;
            dgvCupom.Enabled = true;
        }
        public void DisableBtn()
        {
            btnFiado.Enabled = false;
            btnDinheiro.Enabled = false;
            btnCredito.Enabled = false;
            btnDebito.Enabled = false;
            btnCpfNaNota.Enabled = false;
            dgvCupom.Enabled = false;
        }
        //bloco pagamento. recebido, troco
        public void LimparBlocoPagamento()
        {
            lblrecebido.Text = string.Empty;
            lblTroco.Text = string.Empty;
            lblPagamento.Text = string.Empty;
        }
        private void ListarProdutos()
        {
            dgvItens.DataSource = BusinesProduto.ListarProdutos();
        }
        private void PesquisaProduto()
        {
            dgvItens.DataSource = BusinesProduto.PesquisaProduto(txtPesquisaProduto.Text);
        }
        //formatando as colunas
        private void FormatandoColunas()
        {
            dgvItens.Columns["nome_categoria"].Visible = false;
            //dgvItens.Columns["preco_promocional"].Visible = false;

            dgvItens.Columns["codigo"].HeaderText = "Código";
            dgvItens.Columns["descricao"].HeaderText = "Descrição";
            dgvItens.Columns["preco"].HeaderText = "Preço";

        }
        //preenchendo com os dados do produto
        private void PreencherProduto()
        {
            txtIdProduto.Text = dgvItens.CurrentRow.Cells["id_produto"].Value.ToString();
            lblDescricao.Text = dgvItens.CurrentRow.Cells["descricao"].Value.ToString();
            lblValor.Text = dgvItens.CurrentRow.Cells["preco"].Value.ToString();

        }
        private void txtPesquisaProduto_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisaProduto.Text))
            {
                dgvItens.Visible = false;
            }
            else
            {
                dgvItens.Visible = true;
                FormatandoColunas();
                PesquisaProduto();
            }

        }
        //metodo de calculo subtotal
        private void CalculoSubtotal()
        {
            if (!string.IsNullOrEmpty(txtValorUnitario.Text))
            {
                decimal subTotal = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValorUnitario.Text);
                txtSubTotal.Text = Convert.ToString(subTotal);
            }

        }
        //dados do vendedor
        public void DadosVendedor()
        {
            lblIdVendedor.Text = UserLoginCache.IdUser.ToString();
            lblVendedor.Text = UserLoginCache.Nome + " " + UserLoginCache.SobreNome;
        }
        //abrindo uma nova compra
        public void IncluirItem()
        {
            string rpta = "";
            try
            {
                if (string.IsNullOrEmpty(txtIdProduto.Text))
                {
                    MessageBox.Show("Nenhum Produto Definido");
                }
                else
                {
                    if (this.IsNew)
                    {
                        rpta = BusinesPedido.InserirItemPedido(
                        Convert.ToInt32(lblIdPedido.Text),
                        Convert.ToInt32(txtIdProduto.Text),
                        Convert.ToInt32(txtQuantidade.Text),
                        Convert.ToInt32(txtQuantidade.Text)
                        );
                    }
                }
                if (rpta.Equals("OK"))
                {
                    txtQuantidade.Enabled = false;
                }
                else
                {
                    MessageBox.Show("IsNew = false");
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message + ex.StackTrace;
            }
        }
        //listar os itens no cupom
        public void ListarItensCupom()
        {
            dgvCupom.DataSource = BusinesPedido.ListarItemPedido(int.Parse(lblIdPedido.Text));
            dgvCupom.Columns["id_pedido"].Visible = false;
            dgvCupom.Columns["id_produto"].Visible = false;
            dgvCupom.Columns["descricao"].DisplayIndex = 1;
            dgvCupom.Columns["descricao"].HeaderText = "Nome do Produto";
            dgvCupom.Columns["descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCupom.Columns["codigo"].DisplayIndex = 2;
            dgvCupom.Columns["codigo"].HeaderText = "Código";
            dgvCupom.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCupom.Columns["quantidade"].DisplayIndex = 3;
            dgvCupom.Columns["quantidade"].HeaderText = "Qtde.";
            //dgvCupom.Columns["quantidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCupom.Columns["preco"].DisplayIndex = 4;
            dgvCupom.Columns["preco"].HeaderText = "Preço un.";
            //dgvCupom.Columns["preco"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            DataGridViewCellStyle style = dgvCupom.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.Font = new Font("Open Sans", 7, FontStyle.Bold);
            style.SelectionBackColor = Color.WhiteSmoke;

            dgvCupom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCupom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCupom.ColumnHeadersHeight = 40;
            dgvCupom.ColumnHeadersVisible = true;
            lblTotalItens.Text = dgvCupom.Rows.Count.ToString();

        }
        //listar detalhes
        public void DetalhesPedido()
        {
            DataTable dt = new DataTable();
            dt = BusinesPedido.ListarItemPedido(int.Parse(lblIdPedido.Text));
            lblTotal.Text = dt.Rows[0]["Total"].ToString();
            Decimal valorTotal = 0;
            if (!string.IsNullOrEmpty(dt.Rows[0]["Total"].ToString()))
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    valorTotal += Convert.ToDecimal(dt.Rows[i]["Total"].ToString());
                }
            }
            lblSubTotalCupom.Text = valorTotal.ToString("N2");
            lblTotal.Text = valorTotal.ToString("N2");

        }
        //modo consulta
        //public void ModoConsulta()
        //{
        //    if (lblIdPedido.Text == "idpedido")
        //    {

        //    }
        //}
        //llistar pedidos do vendedor atual
        public void ListarVendas()
        {
            DataTable dtPedido = new DataTable();
            dtPedido = BusinesPedido.DetalhePedido(UserLoginCache.IdUser);
            lblIdPedido.Text = dtPedido.Rows[0]["id_pedido"].ToString();
        }
        //liberando grande quantidade
        private void dgvItens_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                PreencherProduto();
                if (txtQuantidade.Enabled == false)
                {
                    txtQuantidade.Text = Convert.ToString(Qtd);
                }
                else if (txtQuantidade.Text != "1" && !string.IsNullOrEmpty(txtQuantidade.Text))
                {
                    txtQuantidade.Text = txtQuantidade.Text;
                }


                txtDesconto.Text = Convert.ToString(Desconto);
                txtValorUnitario.Text = lblValor.Text;
                //calculando o subtotal
                CalculoSubtotal();
                IncluirItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show(rpta = ex.Message);
            }
            ListarItensCupom();
            DetalhesPedido();
            txtPesquisaProduto.Clear();
            txtPesquisaProduto.Focus();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculoSubtotal();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            FormSangriaPDV frm = new FormSangriaPDV();
            frm.ShowDialog();

            this.Close();
        }
        //liberando controles da compra aberta
        public void LiberarControlesNovaCompra()
        {
            txtPesquisaProduto.Enabled = true;
            btnCpfNaNota.Enabled = true;
            btnFechar.Enabled = false;
            btnDinheiro.Enabled = true;
            btnFiado.Enabled = true;
            btnDebito.Enabled = true;
            btnCredito.Enabled = true;
            dgvCupom.DataSource = null;
            lblTotal.Text = "0,00";
            lblSubTotalCupom.Text = "0,00";
            lblCompraAberta.Text = "Compra em andamento...";
            LimparBlocoPagamento();
            ImagemCupom();
            txtPesquisaProduto.Focus();
            
            CompraEmAndamento = false;
        }
        public void LiberarControlesCompraRecuperada()
        {
            txtPesquisaProduto.Enabled = true;
            btnCpfNaNota.Enabled = true;
            btnFechar.Enabled = false;
            btnDinheiro.Enabled = true;
            btnFiado.Enabled = true;
            btnDebito.Enabled = true;
            btnCredito.Enabled = true;
            lblCompraAberta.Text = "Compra em andamento...";
            ImagemCupom();
            DetalhesPedido();
            txtPesquisaProduto.Focus();

            CompraEmAndamento = false;
        }
        //vericar se existe uma compra aberta
        public void VerificarComprasAbertas()
        {
            DataTable dt = new DataTable();
            dt = BusinesPedido.VerificarComprasAbertas(UserLoginCache.IdUser, CacheIdCaixa.IdCaixa);
            if (dt.Rows.Count > 0)
            {
                lblIdPedido.Text = dt.Rows[0]["id_pedido"].ToString();
                ListarItensCupom();
                LiberarControlesCompraRecuperada();
            }
        }
        //tecla de atalho para abrir uma nova compra
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                switch (keyData)
                {
                    //nova abertura
                    case Keys.Control | Keys.M:
                        try
                        {
                            string resposta = "";
                            if (CompraEmAndamento == true)
                            {
                               resposta = BusinesPedido.CadastroNovaCompra
                            (
                                1,
                                UserLoginCache.IdUser,
                                StatusPedido.Aberto,
                                TipoEntrega.Balcão,
                                DateTime.Now,
                                CacheIdCaixa.IdCaixa
                            );
                                LiberarControlesNovaCompra();
                                CompraEmAndamento = false;
                                txtPesquisaProduto.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Compra em Andamento");
                            }
                            ListarVendas();
                            
                        }
                        catch (Exception ex)
                        {

                        }
                        break;
                    case Keys.F1:
                        txtQuantidade.Enabled = true;
                        txtValorUnitario.Clear();
                        txtSubTotal.Clear();
                        txtQuantidade.Focus();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnDinheiro_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormDinheiro _frm = new FormDinheiro(lblTotal.Text);
            _frm.ShowDialog();
            this.Enabled = true;
            lblrecebido.Text = _frm.Recebido;
            lblTroco.Text = _frm.Troco;
            this.txtValida.Text = _frm.ValidaFecharCompra;
            string idCliente = null;
            if (!string.IsNullOrEmpty(CpfNaNota))
            {
                idCliente = CacheCliente.IdCliente.ToString();
            }
            else
            {
                idCliente = "1";
            }
            if (txtValida.Text == "2")
            {
                try
                {
                    string rpta = BusinesPedido.FecharCompra(Convert.ToInt32(lblIdPedido.Text), TiposPagamento.Dinheiro, StatusPedido.Fechado);
                    lblIdPedido.Text = "idpedido";
                    txtPesquisaProduto.Enabled = false;
                    lblCompraAberta.Text = "Compra Finalizada... *F5 PARA ABRIR UMA NOVA COMPRA";
                    DisableBtn();
                    btnFechar.Enabled = true;
                    lblTrocoT.Text = "Troco:";
                    if (rpta.Equals("OK"))
                    {
                        lblPagamento.Text = TiposPagamento.Dinheiro.ToString();
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                CompraEmAndamento = true;
            }
            if (txtValida.Text == "3")
            {
                var novoTotal = decimal.Parse(lblSubTotalCupom.Text) - decimal.Parse(lblrecebido.Text);
                lblTrocoT.Text = "Falta:";
               
                lblTotal.Text = novoTotal.ToString();
                CompraEmAndamento = false;
            }
            CpfNaNota = string.Empty;
            
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Pagamento.FormDebito frm = new Pagamento.FormDebito(lblTotal.Text);
            frm.ShowDialog();
            this.Enabled = true;
        }
        private void btnFiado_Click(object sender, EventArgs e)
        {
            FormFiado _frm = new FormFiado(lblTotal.Text, lblIdPedido.Text);
            _frm.ShowDialog();
            this.txtValida.Text = _frm.Valor;
            if (txtValida.Text == "2")
            {
                try
                {
                    string rpta = BusinesPedido.FecharCompra(Convert.ToInt32(lblIdPedido.Text), TiposPagamento.Fiado, StatusPedido.Fechado);
                    lblIdPedido.Text = "idpedido";
                    txtPesquisaProduto.Enabled = false;
                    lblCompraAberta.Text = "Compra Finalizada... *F5 PARA ABRIR UMA NOVA COMPRA";
                    lblRecebidoT.Text = "Cliente:";
                    lblrecebido.Text = _frm.NomeCliente;
                    lblTrocoT.Text = "CPF:";
                    lblTroco.Text = _frm.CpfCliente;
                    DisableBtn();
                    btnFechar.Enabled = true;
                    if (rpta.Equals("OK"))
                    {
                        lblPagamento.Text = TiposPagamento.Fiado.ToString();
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            CompraEmAndamento = true;
        }
        private void btnCpfNaNota_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormCpfNota frm = new FormCpfNota(Convert.ToInt32(lblIdPedido.Text));
            frm.ShowDialog();
            this.Enabled = true;
            CpfNaNota = frm.CPF;
        }

        private void timerHeader_Tick(object sender, EventArgs e)
        {
            DateTime data = DateTime.Now;
            lblData.Text = data.ToShortDateString() + " "+ data.ToLongTimeString();
        }
    }
}
