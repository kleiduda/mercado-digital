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

namespace Views
{
    public partial class FormCadastroProduto : Form
    {
        private bool IsNew;
        string image = "";
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            IndexTab();
            StyleTxt();
            ListarCategorias();
            ListarProdutos();
            FormatCollumns();
            
            if (string.IsNullOrEmpty(txtIdProduto.Text))
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
        //listando os produtos
        private void ListarProdutos()
        {
            dgvProdutos.DataSource = BusinesProduto.ListarProdutos();
        }
        //formatando as colunas da gridView
        public void FormatCollumns()
        {
            dgvProdutos.Columns["id_produto"].Visible = false;
            dgvProdutos.Columns["ean"].Visible = false;
            dgvProdutos.Columns["preco_promocional"].Visible = false;
            dgvProdutos.Columns["embalagem"].Visible = false;
            dgvProdutos.Columns["nome_categoria"].Visible = false;
            dgvProdutos.Columns["estoque"].Visible = false;
            dgvProdutos.Columns["codigo"].HeaderText = "SKU";
            dgvProdutos.Columns["descricao"].HeaderText = "Descrição";
            dgvProdutos.Columns["preco"].HeaderText = "Preço";
            //
            DataGridViewCellStyle style = dgvProdutos.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.FromArgb(48, 175, 115);
            style.ForeColor = Color.White;
            style.Font = new Font("Open Sans", 8, FontStyle.Bold);
            style.SelectionBackColor = Color.FromArgb(48, 175, 115);

            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProdutos.ColumnHeadersHeight = 50;
            dgvProdutos.ColumnHeadersVisible = true;
        }
        //preenchendo os campos com datagrid row
        public void Preencher()
        {
            txtCodigo.Text              = dgvProdutos.CurrentRow.Cells["codigo"].Value.ToString();
            txtEAN.Text                 = dgvProdutos.CurrentRow.Cells["ean"].Value.ToString();
            txtDescricao.Text           = dgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();
            txtEmbalagem.Text           = dgvProdutos.CurrentRow.Cells["embalagem"].Value.ToString();
            txtEstoque.Text             = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
            txtIdProduto.Text           = dgvProdutos.CurrentRow.Cells["id_produto"].Value.ToString();
            txtPreco.Text               = dgvProdutos.CurrentRow.Cells["preco"].Value.ToString();
            txtPrecoPromocional.Text    = dgvProdutos.CurrentRow.Cells["preco_promocional"].Value.ToString();
            cbCategoria.Text   = dgvProdutos.CurrentRow.Cells["nome_categoria"].Value.ToString();
        }
        //desabilitar edição do cadastro
        public void DisableEdit()
        {
            txtCodigo.Enabled = false;
            txtEAN.Enabled = false;
            txtDescricao.Enabled = false;
            txtEmbalagem.Enabled = false;
            txtEstoque.Enabled = false;
            txtIdProduto.Enabled = false;
            txtPreco.Enabled = false;
            txtPrecoPromocional.Enabled = false;
            cbCategoria.Enabled = false;
            btnSalvar.Enabled = false;
        }
        //Enable Edit
        public void EnabledEdit()
        {
            txtEAN.Enabled = true;
            txtDescricao.Enabled = true;
            txtEmbalagem.Enabled = true;
            txtEstoque.Enabled = true;
            txtIdProduto.Enabled = true;
            txtPreco.Enabled = true;
            txtPrecoPromocional.Enabled = true;
            btnSalvar.Enabled = true;
            cbCategoria.Enabled = false;
            txtCodigo.Focus();
        }
        //style txt
        public void StyleTxt()
        {
            txtCodigo.Font = new Font("Open Sans", 12, FontStyle.Regular);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Multiline = true;
            txtCodigo.MinimumSize = new Size(255, 38);
            txtCodigo.Size = new Size(255, 38);
            txtCodigo.Multiline = false;

            txtEAN.Font = new Font("Open Sans", 12, FontStyle.Regular);
            txtEAN.ForeColor = Color.Black;
            txtEAN.Multiline = true;
            txtEAN.MinimumSize = new Size(255, 38);
            txtEAN.Size = new Size(255, 38);
            txtEAN.Multiline = false;

            txtDescricao.Font = new Font("Open Sans", 10, FontStyle.Regular);
            txtDescricao.ForeColor = Color.Black;
            txtDescricao.Multiline = true;
            txtDescricao.MinimumSize = new Size(525, 38);
            txtDescricao.Size = new Size(525, 38);
            txtDescricao.Multiline = false;

            txtPreco.Font = new Font("Open Sans", 12, FontStyle.Regular);
            txtPreco.ForeColor = Color.Black;
            txtPreco.Multiline = true;
            txtPreco.MinimumSize = new Size(107, 38);
            txtPreco.Size = new Size(107, 38);
            txtPreco.Multiline = false;

            txtPrecoPromocional.Font = new Font("Open Sans", 12, FontStyle.Regular);
            txtPrecoPromocional.ForeColor = Color.Black;
            txtPrecoPromocional.Multiline = true;
            txtPrecoPromocional.MinimumSize = new Size(107, 38);
            txtPrecoPromocional.Size = new Size(107, 38);
            txtPrecoPromocional.UseSystemPasswordChar =
            txtPrecoPromocional.Multiline = false;

            txtEstoque.Font = new Font("Open Sans", 12, FontStyle.Regular);
            txtEstoque.ForeColor = Color.Black;
            txtEstoque.Multiline = true;
            txtEstoque.MinimumSize = new Size(107, 38);
            txtEstoque.Size = new Size(107, 38);
            txtEstoque.Multiline = false;

            txtEmbalagem.Font = new Font("Open Sans", 10, FontStyle.Regular);
            txtEmbalagem.ForeColor = Color.Black;
            txtEmbalagem.Multiline = true;
            txtEmbalagem.MinimumSize = new Size(131, 38);
            txtEmbalagem.Size = new Size(131, 38);
            txtEmbalagem.Multiline = false;
        }

        //mensagens customizadas
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
        //fim mensagens customizadas

        //definindo imagem do produto
        private void imageProduto_Click(object sender, EventArgs e)
        {
            DataTable dtPath = new DataTable();
            dtPath = BusinesConfig.PathImage();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = false;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "JPG files (*.jpg)|*.jpg";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.imageProduto.SizeMode = PictureBoxSizeMode.StretchImage;
                this.imageProduto.Image = Image.FromFile(openFileDialog.FileName);
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
            txtCodigo.TabIndex = 1;
            txtEAN.TabIndex = 2;
            txtDescricao.TabIndex = 3;
            txtPreco.TabIndex = 4;
            txtPrecoPromocional.TabIndex = 5;
            txtEstoque.TabIndex = 6;
            txtEmbalagem.TabIndex = 7;
            btnSalvar.TabIndex = 8;
        }
        //limpar campos
        private void Limpar()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtEAN.Clear();
            txtEmbalagem.Clear();
            txtPreco.Clear();
            txtPrecoPromocional.Clear();
            txtEstoque.Clear();
        }
        //listar categorias de produto no combobox
        public void ListarCategorias()
        {
            cbCategoria.DataSource = BusinesProduto.ListarCategorias();
            cbCategoria.DisplayMember = "nome_categoria";
            cbCategoria.ValueMember = "id_categoria";
        }
        //cadastro do produto
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string rpta = "";
                if (this.txtCodigo.Text == string.Empty || this.txtDescricao.Text == string.Empty || this.txtPreco.Text == string.Empty ||
                    string.IsNullOrEmpty(txtEstoque.Text))
                {
                    msgError("Alguns campos obrigatórios estão vazios!");
                }
                else if (BusinesProduto.ValidaProduto(txtCodigo.Text) && IsNew == true)
                {
                    msgError("Já existe um PRODUTO com Código " + txtCodigo.Text + " no banco de dados");
                    txtCodigo.Focus();
                }
                else
                {
                    if (this.IsNew)
                    {
                        rpta = BusinesProduto.InsertRegister(
                            this.txtCodigo.Text,
                            this.txtEAN.Text,
                            this.txtDescricao.Text.Trim().ToUpper(),
                            Convert.ToDecimal(this.txtPreco.Text),
                            Convert.ToDecimal(this.txtPrecoPromocional.Text),
                            1,
                            image,
                            this.txtEmbalagem.Text,
                            Convert.ToInt32(txtEstoque.Text)
                            );
                    }
                    else
                    {
                        rpta = BusinesProduto.Editar(
                            Convert.ToInt32(txtIdProduto.Text),
                            this.txtCodigo.Text,
                            this.txtEAN.Text,
                            this.txtDescricao.Text.Trim().ToUpper(),
                            Convert.ToDecimal(this.txtPreco.Text),
                            Convert.ToDecimal(this.txtPrecoPromocional.Text),
                            1,
                            image,
                            this.txtEmbalagem.Text,
                            Convert.ToInt32(txtEstoque.Text)
                            );
                    }
                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNew)
                        {
                            msgSuccess("Produto CADASTRADO com Sucesso!");
                        }
                        else
                        {
                            msgSuccess("Produto ATUALIZADO com Sucesso!");
                        }
                    }
                    else
                    {
                        this.msgError(rpta);
                    }
                    IsNew = true;
                    Limpar();
                    txtCodigo.Focus();
                    ListarProdutos();
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
            frm.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void dgvProdutos_Click(object sender, EventArgs e)
        {
            IsNew = false;
            Preencher();
            DisableEdit();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
            EnabledEdit();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledEdit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FormAddCategoria frm = new FormAddCategoria();
            frm.ShowDialog();
            ListarCategorias();
        }
    }
}
