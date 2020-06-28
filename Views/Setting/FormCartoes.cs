using Busines.Pagamento;
using Supporte.Enums;
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

namespace Views.Produtos
{
    public partial class FormCartoes : Form
    {
        private bool IsNew;
        public FormCartoes()
        {
            InitializeComponent();
        }
        private void dgvCadastro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                MessageBox.Show("OK");
                MessageBox.Show((e.RowIndex + 1) + "  Row  " + (e.ColumnIndex + 1) + "  Column button clicked ");
            }
        }
        private void FormCartoes_Load(object sender, EventArgs e)
        {
            dgvCadastros.DataSource = BusinesCartao.ListarDebito();
            dgvCadastros.Columns["id_bandeira"].Visible = false;
            DataGridViewButtonColumn btnExcluir = new DataGridViewButtonColumn();
            btnExcluir.HeaderText = "Excluir";
            btnExcluir.Text = "X";
            btnExcluir.UseColumnTextForButtonValue = true;
            dgvCadastros.Columns.Add(btnExcluir);
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void msgSuccess(string msg)
        {
            lblSuc.Text = "      " + msg;
            lblSuc.Visible = true;
        }
        #region checkbox
        public BandeirasCartao Bandeira()
        {
            if (chkCielo.Checked == true)
            {
                return BandeirasCartao.Cielo;
            }
            else if (chkGetNet.Checked == true)
            {
                return BandeirasCartao.GetNet;
            }
            else if (chkStone.Checked == true)
            {
                return BandeirasCartao.Stone;
            }
            else
            {
                return BandeirasCartao.PagSeguro;
            }
        }
        private void LiberarCampos()
        {
            txtDebito.Enabled = true;
            txtCredito.Enabled = true;
            btnSalvar.Enabled = true;
            txtDebito.Clear();
            txtCredito.Clear();
            lblSuc.Visible = false;
            lblError.Visible = false;
        }
        private void BloquearCampos()
        {
            txtDebito.Enabled = false;
            txtCredito.Enabled = false;
            btnSalvar.Enabled = false;
        }
        private void chkCielo_OnChange(object sender, EventArgs e)
        {
            chkStone.Checked = false;
            chkPagseguro.Checked = false;
            chkGetNet.Checked = false;
            LiberarCampos();
            txtDebito.Focus();
        }
        private void chkGetNet_OnChange(object sender, EventArgs e)
        {
            chkStone.Checked = false;
            chkPagseguro.Checked = false;
            chkCielo.Checked = false;
            LiberarCampos();
            txtDebito.Focus();
        }
        private void chkPagSeguro_OnChange(object sender, EventArgs e)
        {
            chkStone.Checked = false;
            chkCielo.Checked = false;
            chkGetNet.Checked = false;
            LiberarCampos();
            txtDebito.Focus();
        }
        private void chkStone_OnChange(object sender, EventArgs e)
        {
            chkCielo.Checked = false;
            chkPagseguro.Checked = false;
            chkGetNet.Checked = false;
            LiberarCampos();
            txtDebito.Focus();
        }
        #endregion
        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (this.txtDebito.Text == string.Empty || this.txtCredito.Text == string.Empty)
                {
                    lblSuc.Visible = false;
                    msgError("Alguns campos obrigatórios não foram preenchidos!");
                }
                else if (BusinesCartao.ValidaCartao(Bandeira()))
                {
                    rpta = BusinesCartao.UpdateCartao(Bandeira(), decimal.Parse(txtDebito.Text), decimal.Parse(txtCredito.Text));
                    if (rpta.Equals("OK"))
                    {
                        lblError.Visible = false;
                        lblSuc.Visible = true;
                        msgSuccess("Cadastro ATUALIZADO com sucesso!");
                    }
                }
                else
                {
                    rpta = BusinesCartao.CadastroCartao(Bandeira(), decimal.Parse(txtDebito.Text), decimal.Parse(txtCredito.Text));
                    
                    if (rpta.Equals("OK"))
                    {
                        lblError.Visible = false;
                        lblSuc.Visible = true;
                        msgSuccess("Cadastro REALIZADO com sucesso!");
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblSuc.Visible = false;
                        msgError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            
            BloquearCampos();
        }
    }
}
