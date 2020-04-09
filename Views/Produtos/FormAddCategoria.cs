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
using Supporte.Cache;

namespace Views
{
    public partial class FormAddCategoria : Form
    {
        private bool IsNew = true;
        public FormAddCategoria()
        {
            InitializeComponent();
        }
        private void FormAddCategoria_Load(object sender, EventArgs e)
        {

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
        //validar categoria
        public void ValidarCategoria()
        {
            BusinesProduto.ValidaCategoria(txtCategoria.Text);
        }


        private void txtCategoria_Enter(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "Nome categoria") { txtCategoria.Text = ""; txtCategoria.ForeColor = Color.Black; }
        }

        private void txtCategoria_Leave(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "") { txtCategoria.Text = "Nome categoria"; txtCategoria.ForeColor = Color.Gray; }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (string.IsNullOrEmpty(txtCategoria.Text) || txtCategoria.Text == "Nome categoria")
                {
                    msgError("Campo vazio, preencha com algum valor!");
                }
                else if(BusinesProduto.ValidaCategoria(txtCategoria.Text) && IsNew == true)
                {
                    lblSuc.Visible = false;
                    msgError("Já existe uma Categoria com Nome " + txtCategoria.Text + " no banco de dados");
                    txtCategoria.Focus();
                }
                else
                {
                    if (this.IsNew)
                    {
                        rpta = BusinesProduto.CadastroCategoria(txtCategoria.Text);
                    }
                }
                if (rpta.Equals("OK"))
                {
                    msgSuccess("Categoria cadastrada com sucesso!");
                }
                else
                {
                    msgError(rpta);
                }
            }
            catch (Exception ex)
            {
               msgError(ex.Message + ex.StackTrace);
            }
            txtCategoria.Clear();
            txtCategoria.Focus();
        }
    }
}
