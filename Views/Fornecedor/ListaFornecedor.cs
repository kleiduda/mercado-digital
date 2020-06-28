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
    public partial class ListaFornecedor : Form
    {
        public ListaFornecedor()
        {
            InitializeComponent();
        }
        //listando os produtos
        private void ListaFornecedor_Load(object sender, EventArgs e)
        {
            Fornecedores();
        }
        private void Fornecedores()
        {
            dgvRegistros.DataSource = BusinesFornecedor.Fornecedor_Lista();
            dgvRegistros.Columns["id"].Visible = false;
            dgvRegistros.Columns["nome_fantasia"].HeaderText = "Nome Fantasia";
            dgvRegistros.Columns["cnpj"].HeaderText = "CNPJ";
            dgvRegistros.Columns["email"].HeaderText = "E-mail";
            dgvRegistros.Columns["fone"].HeaderText = "Telefone";
            dgvRegistros.Columns["uf"].HeaderText = "UF";
            dgvRegistros.Columns["cidade"].HeaderText = "Cidade";
            dgvRegistros.Columns["delete"].DisplayIndex = 7;


            //
            //DataGridViewCellStyle style = dgvRegistros.ColumnHeadersDefaultCellStyle;
            //style.BackColor = Color.WhiteSmoke;
            //style.ForeColor = Color.Black;
            //style.Font = new Font("Open Sans", 8, FontStyle.Bold);
            //style.SelectionBackColor = Color.WhiteSmoke;

            ////
            //dgvRegistros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvRegistros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            //dgvRegistros.ColumnHeadersHeight = 50;
            //dgvRegistros.ColumnHeadersVisible = true;
            ////
            //dgvRegistros.RowTemplate.Height = 50;
            ////
            //dgvRegistros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            //dgvRegistros.ColumnHeadersHeight = 30;
            //dgvRegistros.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
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

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            FormCadastroFornecedor frm = new FormCadastroFornecedor();
            frm.ShowDialog();
        }

        
    }
}
