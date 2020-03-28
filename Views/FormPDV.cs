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

namespace Views
{
    public partial class FormPDV : Form
    {
        const decimal Desconto = 0;
        const int Qtd = 1;

        public FormPDV()
        {
            InitializeComponent();
        }

        private void FormPDV_Load(object sender, EventArgs e)
        {
            txtPesquisaProduto.Focus();
            ListarProdutos();
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
        private void dgvItens_Click(object sender, EventArgs e)
        {
            PreencherProduto();
            txtPesquisaProduto.Clear();
            txtQuantidade.Focus();
            txtQuantidade.Text = Convert.ToString(Qtd);
            txtDesconto.Text = Convert.ToString(Desconto);
            txtValorUnitario.Text = lblValor.Text;

            //calculando o subtotal
            CalculoSubtotal();
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculoSubtotal();
        }
    }
}
