using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines;

namespace Views.Produtos
{
    public partial class FormNovoProduto : Form
    {
        private bool IsNew;
        string image = "";
        public FormNovoProduto()
        {
            InitializeComponent();
        }

        private void FormNovoProduto_Load(object sender, EventArgs e)
        {
            ListarCategorias();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
