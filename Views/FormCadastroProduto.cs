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
            ListarProdutos();
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
        private void MessageOK(string message)
        {
            MessageBox.Show(message, "Sistema de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void MessageError(string message)
        {
            MessageBox.Show(message, "Sistema de Vendas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //fim mensagens customizadas
        private void ListarProdutos()
        {
            dgvProdutos.DataSource = BusinesProduto.ListarProdutos();
        }
        //definindo imagem do produto
        private void imageProduto_Click(object sender, EventArgs e)
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
        //cadastro do produto
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            try
            {
                string rpta = "";
                if (this.txtCodigo.Text == string.Empty || this.txtDescricao.Text == string.Empty || this.txtPreco.Text == string.Empty ||
                    string.IsNullOrEmpty(txtEstoque.Text))
                {
                    MessageError("Alguns campos não foram preenchidos!");
                }
                else if (BusinesProduto.ValidaProduto(txtCodigo.Text) && IsNew == true)
                {
                    MessageBox.Show("Já existe um PRODUTO com Código " + txtCodigo.Text + " no banco de dados");
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
                            1,
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
                            this.MessageOK("Produto CADASTRADO com Sucesso!");
                        }
                        else
                        {
                            this.MessageOK("Produto ATUALIZADO com Sucesso!");
                        }
                    }
                    else
                    {
                        this.MessageError(rpta);
                    }

                    IsNew = true;

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
