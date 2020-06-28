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
    public partial class PedidosCompra_Lista : Form
    {
        public PedidosCompra_Lista()
        {
            InitializeComponent();
        }
        //listando os produtos
        private void PedidosCompra_Lista_Load(object sender, EventArgs e)
        {
            Pedidos();
        }
        public void Pedidos()
        {
            dgvRegistros.DataSource = BPedidosCompra.PedidoCompra_Lista();
            dgvRegistros.Columns["id"].HeaderText = "Número";
            dgvRegistros.Columns["delete"].DisplayIndex = 5;
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
            BPedidosCompra.PedidoCompra_New(DateTime.Now);
            int ultimoId = 0;
            if (dgvRegistros.Rows.Count != 0)
            {
                ultimoId = Convert.ToInt32(dgvRegistros.Rows[this.dgvRegistros.Rows.Count - 1].Cells["id"].Value.ToString()) + 1;
            }
            PedidoCompra_New frm = new PedidoCompra_New( ultimoId.ToString());
            frm.ShowDialog();
            Pedidos();
        }

        private void dgvRegistros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PedidoCompra_New _frm = new PedidoCompra_New(dgvRegistros.CurrentRow.Cells["id"].Value.ToString());
            _frm.ShowDialog();
            Pedidos();
        }
    }
}
