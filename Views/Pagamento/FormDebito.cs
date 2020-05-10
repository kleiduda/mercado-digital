using Busines.Pagamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Pagamento
{
    public partial class FormDebito : Form
    {
        private DataTable _dtCartoes;
        public FormDebito()
        {
            InitializeComponent();
        }
        public FormDebito(string value)
        {
            InitializeComponent();
            lblTotal.Text = value;
        }
        private void FormDebito_Load(object sender, EventArgs e)
        {
            ListarCartao();
        }
        #region metodos de acao
        public void ListarCartao()
        {
            _dtCartoes = BusinesCartao.ListarDebito();
            MessageBox.Show(_dtCartoes.Rows[0]["taxa_debito"].ToString());
            var dt = _dtCartoes.AsEnumerable().Where(x => x.Field<decimal>("taxa_debito") > 0).Select(k =>
              {
                  var row = _dtCartoes.NewRow();
                  row.ItemArray = new object[]
                  {
                      k.Field<Int32>("id_bandeira"),
                      k.Field<string>("nome_bandeira"),
                      k.Field<decimal>("taxa_debito"),
                      k.Field<decimal>("taxa_credito")
                  };
                  return row;
              });
            if (dt.Any())
            {
                dgvDebito.DataSource = dt.CopyToDataTable();
                dgvDebito.Columns["id_bandeira"].Visible = false;
                dgvDebito.Columns["taxa_credito"].Visible = false;
                dgvDebito.Columns["taxa_debito"].Visible = false;
            }
            else
            {
                MessageBox.Show("nada aqui");
            }
        }

        #endregion

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            try
            {
                switch (keyData)
                {
                    case Keys.Down:
                        break;
                    case Keys.Enter:
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void dgvDebito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
           // this.Close();
        }
        private void btnConfirma_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
