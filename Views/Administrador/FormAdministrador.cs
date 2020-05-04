using Supporte.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines.Administrador;
using Busines;

namespace Views.Administrador
{
    public partial class FormAdministrador : Form
    {
        public FormAdministrador()
        {
            InitializeComponent();
        }
        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            LoadUsuario();
            //FiltroVendas();
            ProdutosMaisVendidos();
            ProdutosDataVencimento();
            CaixaAberto();
        }
        #region estilo do form
        //adicionando uma picturebox redonda
        public void OvalPictureBox()
        {
            this.BackColor = Color.DarkBlue;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using (GraphicsPath gp = new GraphicsPath())
            {
                gp.AddEllipse(0, 0, 45, 45);
                fotoUsuario.Region = new Region(gp);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawEllipse(new Pen(new SolidBrush(this.BackColor), 1), 0, 0, 10, 10);
            }
        }
        #endregion
        //dados de usuario
        private void LoadUsuario()
        {
            lblUsuario.Text = "Olá, " + UserLoginCache.Nome.ToLower() + " " + UserLoginCache.SobreNome.ToLower();
            fotoUsuario.LoadAsync(@"C:\Users\DELL\Pictures\sistema\" + UserLoginCache.Foto.ToString());
        }
        #region Controles do DashBoard
        public void FiltroVendas()
        {
            DataTable dt = new DataTable();
            dt = BusinesAdministrador.TotalDeVendas();
            decimal valorTotal = 0;

            if (dt != null)
            {
                var total = dt.AsEnumerable().Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var debito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 2).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var credito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 3).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var fiado = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 4).Where(x => x.Field<string>("data_fechamento") == DateTime.Now.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));

                lblTotalVendas.Text = total.ToString("C");
                lblVendaDinheiro.Text = dinheiro.ToString("C");
                lblVendaDebito.Text = debito.ToString("C");
                lblVendaFiado.Text = fiado.ToString("C");
                lblVendasCredito.Text = credito.ToString("C");
            }
        }
        private void calendario_DayClick(object sender, Pabo.Calendar.DayClickEventArgs e)
        {
            DateTime datetime;
            datetime = DateTime.Parse(e.Date);
            DataTable dt = new DataTable();
            dt = BusinesAdministrador.TotalDeVendas();
            decimal valorTotal = 0;
            if (dt != null)
            {
                var total = dt.AsEnumerable().Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var debito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 2).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var credito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 3).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));
                var fiado = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 4).Where(x => x.Field<string>("data_fechamento") == datetime.ToShortDateString()).Sum(x => x.Field<decimal>("TotalDeVendas"));

                lblTotalVendas.Text = total.ToString("C");
                lblVendaDinheiro.Text = dinheiro.ToString("C");
                lblVendaDebito.Text = debito.ToString("C");
                lblVendaFiado.Text = fiado.ToString("C");
                lblVendasCredito.Text = credito.ToString("C");
            }
        }
        
        public void ProdutosMaisVendidos()
        {
           // dgvProdutosMaisVendidos.DataSource = BusinesProduto.CarregaDadosComDataReader();
            dgvProdutosMaisVendidos.DataSource = BusinesProduto.CarregaDadosComDataTable();
            //
            dgvProdutosMaisVendidos.Columns["IdPagamento"].Visible = false;
            dgvProdutosMaisVendidos.Columns["IdStatusVenda"].Visible = false;
            //dgvProdutosMaisVendidos.Columns["descricao"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvProdutosMaisVendidos.Columns["codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvProdutosMaisVendidos.Columns["descricao"].Width = 170;
            dgvProdutosMaisVendidos.Columns["preco"].Width = 70;
            dgvProdutosMaisVendidos.Columns["quantidade"].Width = 60;
            dgvProdutosMaisVendidos.Columns["quantidade"].DefaultCellStyle.ForeColor = Color.Red;
            //
            dgvProdutosMaisVendidos.Columns["codigo"].HeaderText = "Cod.";
            dgvProdutosMaisVendidos.Columns["descricao"].HeaderText = "Descrição";
            dgvProdutosMaisVendidos.Columns["quantidade"].HeaderText = "Qtd";
            dgvProdutosMaisVendidos.Columns["preco"].HeaderText = "Prç.";
            dgvProdutosMaisVendidos.Columns["Total"].HeaderText = "Total";
            dgvProdutosMaisVendidos.Columns["Total"].DefaultCellStyle.Format = "c";
            //precisa mudar a cor da fonte na coluna quantidade para vermelho
            //
            //lblMaisVendido.Text = dgvProdutosMaisVendidos.SelectedRows[0].Cells["descricao"].Value.ToString()
                //+ "  |  " + dgvProdutosMaisVendidos.SelectedRows[0].Cells["quantidade"].Value.ToString() + " Unidades Vendidas";
        }
        public void ProdutosDataVencimento()
        {
            dgvProdutosVencimento.DataSource = BusinesAdministrador.Vencimento();
        }
        public void CaixaAberto()
        {
            DataTable dt = new DataTable();
            dt = BusinesAdministrador.CaixaAberto();
            decimal valor = 0;
            pCaixas.AutoScroll = true;
            if (dt.Rows.Count != 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var caixaNome ="CAIXA: " + dt.Rows[i]["id"].ToString() + "  | Operador(a): " + dt.Rows[i]["nome"].ToString() + " " + dt.Rows[i]["sobre_nome"].ToString();
                    Panel pCx = new Panel();
                    pCaixaAberto.Controls.Add(pCx);
                    pCx.Left = 10;
                    pCx.Top = i * 70;
                    pCx.BackColor = Color.WhiteSmoke;
                    pCx.Width = 600;
                    pCx.Height = 68;
                    Label nome = new Label();
                    pCx.Controls.Add(nome);
                    nome.AutoSize = true;
                    nome.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                    nome.ForeColor = Color.Gray;
                    nome.Text = caixaNome.ToString();
                    nome.Top = 25;
                    nome.Left = 20;
                    Label total = new Label();
                    pCx.Controls.Add(total);
                    total.AutoSize = true;
                    total.Left = 400;
                    total.Top = 8;
                    total.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                    total.ForeColor = Color.Gray;
                    total.Text = "Total de Vendas";
                    Label TotalVendas = new Label();
                    pCx.Controls.Add(TotalVendas);
                    TotalVendas.Font = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);
                    TotalVendas.ForeColor = Color.Gray;
                    TotalVendas.Left = 400;
                    TotalVendas.Top = 30;
                    TotalVendas.Text = dt.Rows[i]["TotalVendas"].ToString();
                }
            }


        }

        #endregion

         
    }
}
