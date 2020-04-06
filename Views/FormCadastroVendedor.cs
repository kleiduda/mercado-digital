using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines;
using Supporte.Cache;

namespace Views
{
    public partial class FormCadastroVendedor : Form
    {
        private bool IsNew;
        string image = "";
        public FormCadastroVendedor()
        {
            InitializeComponent();
        }

        private void FormCadastroVendedor_Load(object sender, EventArgs e)
        {
            IndexTab();
            ListarFuncao();
            if (string.IsNullOrEmpty(txtIdVendedor.Text))
            {
                IsNew = true;
                //EnableText();
            }
            else
            {
                IsNew = false;
                //DisableText();
            }
        }
        //listando vendedores
        public void ListVendedores()
        {

        }
        //definindo imagem do produto
        private void fotoVendedor_Click(object sender, EventArgs e)
        {
            DataTable dtPath = new DataTable();
            dtPath = BusinesConfig.Config();
            MessageBox.Show(dtPath.Rows[0]["image_path"].ToString());

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = false;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.fotoVendedor.SizeMode = PictureBoxSizeMode.StretchImage;
                this.fotoVendedor.Image = Image.FromFile(openFileDialog.FileName);
                foreach (string fileName in openFileDialog.FileNames)
                {
                    if (System.IO.File.Exists(dtPath.Rows[0]["image_path"].ToString() + Path.GetFileName(fileName)))
                    {
                        MessageBox.Show("Já existe uma imagem com esse nome na pasta, Atualizar?");
                        //File.Replace(fileName, @"C:\Users\ArteGift\Documents\img\" + Path.GetFileName(fileName), "copy");
                    }
                    else
                    {
                        File.Copy(fileName, dtPath.Rows[0]["image_path"].ToString() + Path.GetFileName(fileName));
                    }
                }
                string fileNames = openFileDialog.FileName;
                image = Path.GetFileName(fileNames);
            }
        }
        //ordem dos campos ao aperta o TAB
        private void IndexTab()
        {
            cbFuncao.TabIndex = 1;
            txtNome.TabIndex = 2;
            txtSobreNome.TabIndex = 3;
            txtTelefone.TabIndex = 4;
            txtEmail.TabIndex = 5;
            txtLogin.TabIndex = 6;
            txtSenha.TabIndex = 7;
            btnSalvar.TabIndex = 8;
        }
        //limpar campos
        private void Limpar()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtSobreNome.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
        }
        //listando funcao de usuario
        private void ListarFuncao()
        {
            cbFuncao.DataSource = BusinesUsuario.ListarFuncoes();
            cbFuncao.ValueMember = "id_funcao";
            cbFuncao.DisplayMember = "nome_funcao";
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
        //cadastro do produto
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string rpta = "";
                if (this.txtNome.Text == string.Empty || this.txtSobreNome.Text == string.Empty || this.txtLogin.Text == string.Empty ||
                    string.IsNullOrEmpty(txtSenha.Text))
                {
                    lblSuc.Visible = false;
                    msgError("Alguns campos obrigatórios não foram preenchidos!");
                }
                else if (BusinesUsuario.ValidaUsuario (txtLogin.Text) && IsNew == true)
                {
                    lblSuc.Visible = false;
                    msgError("Já existe um VENDEDOR com Login " + txtLogin.Text + " no banco de dados");
                    txtLogin.Focus();
                }
                else
                {
                    if (this.IsNew)
                    {
                        rpta = BusinesUsuario.InsertUsuario(
                            this.txtLogin.Text,
                            this.txtNome.Text.Trim().ToUpper(),
                            this.txtSobreNome.Text.Trim().ToUpper(),
                            this.txtEmail.Text.Trim().ToLower(),
                            this.txtTelefone.Text,
                            Convert.ToInt32(cbFuncao.SelectedValue),
                            this.txtSenha.Text
                            );
                    }
                    else
                    {
                        rpta = BusinesUsuario.Update(
                            Convert.ToInt32(txtIdVendedor.Text),
                            this.txtLogin.Text,
                            this.txtNome.Text.Trim().ToUpper(),
                            this.txtSobreNome.Text.Trim().ToUpper(),
                            this.txtEmail.Text.Trim().ToLower(),
                            this.txtTelefone.Text,
                            Convert.ToInt32(cbFuncao.SelectedValue),
                            this.txtSenha.Text
                            );
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNew)
                        {
                            lblError.Visible = false;
                            msgSuccess("Cadastro REALIZADO com sucesso!");
                        }
                        else
                        {
                            lblError.Visible = false;
                            msgSuccess("Cadastro ATUALIZADO com sucesso!");
                        }
                    }
                    else
                    {
                        msgError(rpta);
                    }

                    IsNew = true;
                    Limpar();
                    txtNome.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FormImportProduto frm = new FormImportProduto();
            frm.Show();
        }

        
    }
}
