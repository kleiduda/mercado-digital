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
            FiltroVendas();
            ProdutosMaisVendidos();
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
            fotoUsuario.LoadAsync(@"C:\Users\Alliance\Pictures\fotoanderson\" + UserLoginCache.Foto.ToString());
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
            dgvProdutosMaisVendidos.DataSource = Busines.BusinesProduto.ProdutosMaisVendidos();
            //
            dgvProdutosMaisVendidos.Columns["codigo"].HeaderText = "COD";
            dgvProdutosMaisVendidos.Columns["descricao"].HeaderText = "Descrição";
            dgvProdutosMaisVendidos.Columns["quantidade"].HeaderText = "Qtd";
            dgvProdutosMaisVendidos.Columns["preco"].HeaderText = "Preço";
            dgvProdutosMaisVendidos.Columns["Total"].HeaderText = "Total";
            //
        }

        #endregion
    }
}
