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
            //panelContainer.BorderStyle = BorderStyle.FixedSingle;
            IndexTab();
            StyleTxt();
            ListarFuncao();
            ListarUsuarios();
            FormatCollumns();
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
        public void ListarUsuarios()
        {
            //dgvUsers.DataSource = BusinesUsuario.ListarUsuarios();
            this.dgvUsers.DataSource = BusinesUsuario.ListarUsuarios();
        }
        //formatando as colunas da gridView
        public void FormatCollumns()
        {
            dgvUsers.Columns["id_vendedor"].Visible = false;
            dgvUsers.Columns["login"].Visible = false;
            dgvUsers.Columns["id_funcao"].Visible = false;
            dgvUsers.Columns["senha"].Visible = false;
            dgvUsers.Columns["sobre_nome"].Visible = false;
            dgvUsers.Columns["telefone"].Visible = false;
            dgvUsers.Columns["nome"].HeaderText = "Nome";
            dgvUsers.Columns["email"].HeaderText = "Email";
            //
            DataGridViewCellStyle style = dgvUsers.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.FromArgb(48, 175, 115);
            style.ForeColor = Color.White;
            style.Font = new Font("Open Sans", 8, FontStyle.Bold);
            style.SelectionBackColor = Color.FromArgb(48, 175, 115);
            
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.ColumnHeadersHeight = 50;
            dgvUsers.ColumnHeadersVisible = true;
        }
        //preenchendo os campos com datagrid row
        public void Preencher()
        {
            txtNome.Text = dgvUsers.CurrentRow.Cells["nome"].Value.ToString();
            txtSobreNome.Text = dgvUsers.CurrentRow.Cells["sobre_nome"].Value.ToString();
            txtEmail.Text = dgvUsers.CurrentRow.Cells["email"].Value.ToString();
            txtLogin.Text = dgvUsers.CurrentRow.Cells["login"].Value.ToString();
            txtSenha.Text = dgvUsers.CurrentRow.Cells["senha"].Value.ToString();
            txtTelefone.Text = dgvUsers.CurrentRow.Cells["telefone"].Value.ToString();
        }
        //desabilitar edição do cadastro
        public void DisableEdit()
        {
            txtNome.Enabled = false;
            txtSobreNome.Enabled = false;
            txtEmail.Enabled = false;
            txtLogin.Enabled = false;
            txtTelefone.Enabled = false;
            txtSenha.Enabled = false;
            cbFuncao.Enabled = false;
        }
        //style txt
        public void StyleTxt()
        {
            txtNome.Font = new Font("Open Sans", 10, FontStyle.Regular);
            txtNome.ForeColor = Color.Black;
            txtNome.Multiline = true;
            txtNome.MinimumSize = new Size(255,38);
            txtNome.Size = new Size(255,38);
            txtNome.Multiline = false;

            txtSobreNome.Font = new Font("Open Sans", 10, FontStyle.Regular);
            txtSobreNome.ForeColor = Color.Black;
            txtSobreNome.Multiline = true;
            txtSobreNome.MinimumSize = new Size(255, 38);
            txtSobreNome.Size = new Size(255, 38);
            txtSobreNome.Multiline = false;

            txtLogin.Font = new Font("Open Sans", 10, FontStyle.Regular);
            txtLogin.ForeColor = Color.Black;
            txtLogin.Multiline = true;
            txtLogin.MinimumSize = new Size(255, 38);
            txtLogin.Size = new Size(255, 38);
            txtLogin.Multiline = false;

            txtTelefone.Font = new Font("Open Sans", 10, FontStyle.Regular);
            txtTelefone.ForeColor = Color.Black;
            txtTelefone.Multiline = true;
            txtTelefone.MinimumSize = new Size(255, 38);
            txtTelefone.Size = new Size(255, 38);
            txtTelefone.Multiline = false;

            txtSenha.Font = new Font("Open Sans", 10, FontStyle.Regular);
            txtSenha.ForeColor = Color.Black;
            txtSenha.Multiline = true;
            txtSenha.MinimumSize = new Size(255, 38);
            txtSenha.Size = new Size(255, 38);
            txtSenha.UseSystemPasswordChar =
            txtSenha.Multiline = false;

            txtEmail.Font = new Font("Open Sans", 10, FontStyle.Regular);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Multiline = true;
            txtEmail.MinimumSize = new Size(255, 38);
            txtEmail.Size = new Size(255, 38);
            txtEmail.Multiline = false;
        }
        //Enable Edit
        public void EnabledEdit()
        {
            txtNome.Enabled = true;
            txtSobreNome.Enabled = true;
            txtEmail.Enabled = true;
            txtLogin.Enabled = true;
            txtTelefone.Enabled = true;
            txtSenha.Enabled = true;
            cbFuncao.Enabled = true;
            txtNome.Focus();
        }
        //definindo imagem do produto
        private void fotoVendedor_Click(object sender, EventArgs e)
        {
            DataTable dtPath = new DataTable();
            dtPath = BusinesConfig.PathImage();
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
                    ListarUsuarios();
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

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            Preencher();
            DisableEdit();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledEdit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            EnabledEdit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

       
    }
}
