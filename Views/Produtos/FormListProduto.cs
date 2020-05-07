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

namespace Views.Produtos
{
    public partial class FormListProduto : Form
    {
        public FormListProduto()
        {
            InitializeComponent();
        }
        //listando os produtos
        private void FormListProduto_Load(object sender, EventArgs e)
        {
            ListarProdutos();
        }
        private void ListarProdutos()
        {
            dgvProdutos.DataSource = BusinesProduto.ListarProdutos();
            dgvProdutos.Columns["id_produto"].Visible = false;
            dgvProdutos.Columns["ean"].Visible = false;
            dgvProdutos.Columns["preco_promocional"].Visible = false;
            dgvProdutos.Columns["embalagem"].Visible = false;
            dgvProdutos.Columns["nome_categoria"].Visible = false;
            dgvProdutos.Columns["estoque"].Visible = false;
            dgvProdutos.Columns["image"].Visible = false;
            dgvProdutos.Columns["codigo"].HeaderText = "SKU";
            dgvProdutos.Columns["descricao"].HeaderText = "Descrição";
            dgvProdutos.Columns["preco"].HeaderText = "Preço";
            //
            DataGridViewCellStyle style = dgvProdutos.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.Font = new Font("Open Sans", 8, FontStyle.Bold);
            style.SelectionBackColor = Color.WhiteSmoke;
            //
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProdutos.ColumnHeadersHeight = 50;
            dgvProdutos.ColumnHeadersVisible = true;
        }
    }
}
