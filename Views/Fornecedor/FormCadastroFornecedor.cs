using Busines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views.Produtos
{
    public partial class FormCadastroFornecedor : Form
    {
        private bool IsNew = true;
        public FormCadastroFornecedor()
        {
            InitializeComponent();
        }

        private void FormCadastroFornecedor_Load(object sender, EventArgs e)
        {

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
        public void Clean()
        {
            txtBairro.Clear();
            txtCep.Clear();
            txtCnpj.Clear();
            txtComplemento.Clear();
            txtContato.Clear();
            txtEmail.Clear();
            txtFone.Clear();
            txtIE.Clear();
            txtNomeFantasia.Clear();
            txtRazaoSocial.Clear();
            txtNumero.Clear();
            txtRua.Clear();
            txtUf.Clear();
            txtWhats.Clear();
        }
        public void DisableEdit()
        {
            txtBairro.Enabled = false;
            txtCep.Enabled = false;
            txtCnpj.Enabled = false;
            txtComplemento.Enabled = false;
            txtContato.Enabled = false;
            txtEmail.Enabled = false;
            txtFone.Enabled = false;
            txtIE.Enabled = false;
            txtNomeFantasia.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtNumero.Enabled = false;
            txtRua.Enabled = false;
            txtUf.Enabled = false;
            txtWhats.Enabled = false;
            txtCidade.Enabled = false;
        }
        public void EnabledEdit()
        {
            txtBairro.Enabled = true;
            txtCep.Enabled = true;
            txtCnpj.Enabled = true;
            txtComplemento.Enabled = true;
            txtContato.Enabled = true;
            txtEmail.Enabled = true;
            txtFone.Enabled = true;
            txtIE.Enabled = true;
            txtNomeFantasia.Enabled = true;
            txtRazaoSocial.Enabled = true;
            txtNumero.Enabled = true;
            txtRua.Enabled = true;
            txtUf.Enabled = true;
            txtWhats.Enabled = true;
            txtCidade.Enabled = true;
        }
        public void ValidateForm()
        {
            if (string.IsNullOrEmpty(txtCnpj.Text)){
                txtCnpj.BackColor = Color.Red;
            }
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

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            EnabledEdit();
            Clean();
            txtCnpj.Focus();
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledEdit();
            txtCnpj.Focus();
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovoCadastro.Enabled = false;
            btnSalvar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DisableEdit();
            btnCancelar.Enabled = false;
            btnNovoCadastro.Enabled = true;
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (IsNew == true)
                {
                    rpta = BusinesFornecedor.Fornecedor_Cadastro
                        (
                            txtCnpj.Text.Trim().ToUpper(),
                            txtNomeFantasia.Text.Trim().ToUpper(),
                            txtRazaoSocial.Text.Trim().ToUpper(),
                            txtIE.Text.Trim().ToUpper(),
                            txtEmail.Text.Trim().ToLower(),
                            txtFone.Text.Trim(),
                            txtWhats.Text.Trim(),
                            txtPais.Text.Trim().ToUpper(),
                            txtUf.Text.Trim().ToUpper(),
                            txtCidade.Text.Trim().ToUpper(),
                            txtBairro.Text.Trim().ToUpper(),
                            txtRua.Text.Trim().ToUpper(),
                            txtNumero.Text.Trim().ToUpper(),
                            txtComplemento.Text.Trim().ToUpper(),
                            txtCep.Text.Trim().ToUpper(),
                            txtContato.Text.Trim().ToUpper()
                        );
                }
                if (rpta.Equals("OK"))
                {
                    msgSuccess("Cadastro realizado com sucesso");
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
        }
    }
}
