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
            //DataGridViewProdutos();
            CarregarGrid();
            dgvProdutos.DataSource = BusinesProduto.ListarProdutos();
            
        }

        private void pButtons_Paint(object sender, PaintEventArgs e)
        {
            Pen separador = new Pen(Color.Gray, 4);
            separador.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            //width, position 1, left distance, position 2
            e.Graphics.DrawLine(separador, 1400, 70, 20, 70);
            //textbox line
            Pen linhaTxt = new Pen(Color.Black, 1);
            linhaTxt.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            e.Graphics.DrawLine(linhaTxt, 800, 60, 230, 60);
        }
        public void DataGridViewProdutos()
        {
            DataGridView dgvProdutos = new DataGridView();
            dgvProdutos.Width = 1350;
            dgvProdutos.Height = 650;
            dgvProdutos.Anchor = AnchorStyles.Left;
            dgvProdutos.Anchor = AnchorStyles.Right;
            dgvProdutos.BackgroundColor = Color.FromArgb(242,242,242);
            dgvProdutos.DataSource = BusinesProduto.ListarProdutos();
            pDataGrid.Controls.Add(dgvProdutos);
        }
        private void CarregarGrid()
        {
            dgvProdutos.DataSource = BusinesProduto.ListarProdutos();
            dgvProdutos.Columns["id_produto"].Visible = false;
            dgvProdutos.Columns["preco_custo"].Visible = false;
            dgvProdutos.Columns["ean"].Visible = false;
            dgvProdutos.Columns["preco_promocional"].Visible = false;
            dgvProdutos.Columns["embalagem"].Visible = false;
            dgvProdutos.Columns["nome_categoria"].Visible = false;
            dgvProdutos.Columns["estoque"].Visible = false;
            dgvProdutos.Columns["image"].Visible = false;
            dgvProdutos.Columns["codigo"].HeaderText = "SKU";
            dgvProdutos.Columns["codigo"].Width = 200;
            dgvProdutos.Columns["descricao"].HeaderText = "Descrição";
            dgvProdutos.Columns["descricao"].Width = 700;
            dgvProdutos.Columns["preco"].HeaderText = "Preço";
            dgvProdutos.Columns["preco"].Width = 100;
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
            //
            dgvProdutos.RowTemplate.Height = 50;
            //
            dgvProdutos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProdutos.ColumnHeadersHeight = 30;
            dgvProdutos.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            
        }
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastroProduto frm = new FormCadastroProduto("new");
            frm.ShowDialog();
            ListarProdutos();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCadastroProduto _frm = new FormCadastroProduto(dgvProdutos.CurrentRow.Cells["id_produto"].Value.ToString());
            _frm.ShowDialog();
            ListarProdutos();
        }
    }
}
