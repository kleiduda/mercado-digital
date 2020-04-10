using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines;
using Supporte.Cache;

namespace Views
{
    public partial class FormPDV : Form
    {
        const decimal Desconto = 0;
        const int Qtd = 1;
        private bool IsNew = true;

        public FormPDV()
        {
            InitializeComponent();
        }

        private void FormPDV_Load(object sender, EventArgs e)
        {
            DadosVendedor();
            ListarProdutos();
            lblData.Text = DateTime.Now.ToString();
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
            decimal subTotal = Convert.ToDecimal(txtQuantidade.Text) * Convert.ToDecimal(txtValorUnitario.Text);
            txtSubTotal.Text = Convert.ToString(subTotal);
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
                    if (this.IsNew)
                    {
                        
                    }
                    
                }
                else
                {
                    MessageBox.Show(rpta);
                }
            }
            catch (Exception ex)
            {
                rpta = ex.Message + ex.StackTrace;
            }
        }
        //llistar pedidos do vendedor atual
        public void ListarVendas()
        {
            DataTable dtPedido = new DataTable();
            dtPedido = BusinesPedido.DetalhePedido(int.Parse(lblIdVendedor.Text));
            lblIdPedido.Text = dtPedido.Rows[0]["id_pedido"].ToString();
        }
        private void dgvItens_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                PreencherProduto();
                txtQuantidade.Text = Convert.ToString(Qtd);
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
            
            txtPesquisaProduto.Clear();
            txtPesquisaProduto.Focus();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculoSubtotal();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Control | Keys.L:
                    string rpta = "";
                    if (lblIdPedido.Text != "idpedido")
                    {
                        MessageBox.Show("Já existe uma compra em andamento.");
                    }
                    else
                    {
                        rpta = BusinesPedido.CadastroNovaCompra(1, Convert.ToInt32(lblIdVendedor.Text), 1);
                        lblCompraAberta.Visible = true;
                        ListarVendas();
                    }
                    txtPesquisaProduto.Focus();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
