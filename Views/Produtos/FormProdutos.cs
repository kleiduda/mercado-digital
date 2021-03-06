﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines;

namespace Views.Produtos
{
    public partial class FormProdutos : Form
    {
        private bool IsNew;
        string image = "";
        public FormProdutos()
        {
            InitializeComponent();
        }
        private void FormNovoProduto_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ListarCategorias();
            tabControl1.SelectedIndex = 1;
            IndexTab();
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
        //listar produtos
        private void CarregarGrid()
        {
            dgvProdutos.DataSource = BusinesProduto.ListarProdutos();
            dgvProdutos.Columns["id_produto"].Visible = false;
            dgvProdutos.Columns["ean"].Visible = false;
            dgvProdutos.Columns["preco_promocional"].Visible = false;
            dgvProdutos.Columns["embalagem"].Visible = false;
            dgvProdutos.Columns["nome_categoria"].Visible = false;
            dgvProdutos.Columns["estoque"].Visible = false;
            dgvProdutos.Columns["image"].Visible = false;
            dgvProdutos.Columns["codigo"].HeaderText = "SKU";
            dgvProdutos.Columns["descricao"].HeaderText = "Descrição";
            dgvProdutos.Columns["preco"].HeaderText = "Preço";
            //
            DataGridViewCellStyle style = dgvProdutos.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.WhiteSmoke;
            style.ForeColor = Color.Black;
            style.Font = new Font("Open Sans", 8, FontStyle.Bold);
            style.SelectionBackColor = Color.WhiteSmoke;
            //
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProdutos.ColumnHeadersHeight = 50;
            dgvProdutos.ColumnHeadersVisible = true;
        }
        public void DesabilitarEdição()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtEAN.Enabled = false;
            txtEmbalagem.Enabled = false;
            txtEstoque.Enabled = false;
            txtPrecoCusto.Enabled = false;
            txtPrecoVenda.Enabled = false;
            txtPrecoPromocional.Enabled = false;
            cbCategoria.Enabled = false;
            fotoProduto.Enabled = false;
        }
        public void HabilitarEdição()
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtEAN.Enabled = true;
            txtEmbalagem.Enabled = true;
            txtEstoque.Enabled = true;
            txtPrecoCusto.Enabled = true;
            txtPrecoVenda.Enabled = true;
            txtPrecoPromocional.Enabled = true;
            cbCategoria.Enabled = true;
            fotoProduto.Enabled = true;
        }
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
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //this.fotoVendedor.SizeMode = PictureBoxSizeMode.Zoom;
                    this.fotoProduto.Image = Image.FromFile(openFileDialog.FileName);
                    string original = Path.GetFullPath(openFileDialog.FileName);
                    string novo = dtPath.Rows[0]["image_path"].ToString() + Path.GetFileName(openFileDialog.FileName);
                    //string original = dtPath.Rows[0]["image_path"].ToString() + Path.GetFileName(openFileDialog.FileName);

                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        if (File.Exists(dtPath.Rows[0]["image_path"].ToString() + Path.GetFileName(fileName)))
                        {
                            MessageBox.Show("Já existe uma imagem com esse nome na pasta, Atualizar?");
                            //File.Replace(fileName, @"C:\Users\ArteGift\Documents\img\" + Path.GetFileName(fileName), "copy");
                        }
                        else
                        {
                            ResizeImage(original, novo, 300, 200, true);
                            //File.Copy(fileName, dtPath.Rows[0]["image_path"].ToString() + Path.GetFileName(fileName));
                        }
                    }
                    string fileNames = openFileDialog.FileName;
                    image = Path.GetFileName(fileNames);
                    MessageBox.Show(image);
                }
            }
        private void IndexTab()
        {
            txtCodigo.TabIndex = 1;
            txtEAN.TabIndex = 2;
            txtDescricao.TabIndex = 3;
            txtPrecoCusto.TabIndex = 4;
            txtPrecoVenda.TabIndex = 5;
            txtPrecoPromocional.TabIndex = 6;
            txtEstoque.TabIndex = 7;
            txtEmbalagem.TabIndex = 8;
            btnSalvar.TabIndex = 9;
        }
        //limpar campos
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtEAN.Clear();
            txtEmbalagem.Clear();
            txtPrecoCusto.Clear();
            txtPrecoVenda.Clear();
            txtEstoque.Clear();
            fotoProduto.Image = Properties.Resources.Asset_1default;
        }
        //listar categorias de produto no combobox
        public void ListarCategorias()
        {
            cbCategoria.DataSource = BusinesProduto.ListarCategorias();
            cbCategoria.DisplayMember = "nome_categoria";
            cbCategoria.ValueMember = "id_categoria";
        }
        public void ProdutoSelecionado()
        {
            txtCodigo.Text = dgvProdutos.CurrentRow.Cells["codigo"].Value.ToString();
            txtEAN.Text = dgvProdutos.CurrentRow.Cells["ean"].Value.ToString();
            txtDescricao.Text = dgvProdutos.CurrentRow.Cells["descricao"].Value.ToString();
            txtEmbalagem.Text = dgvProdutos.CurrentRow.Cells["embalagem"].Value.ToString();
            txtEstoque.Text = dgvProdutos.CurrentRow.Cells["estoque"].Value.ToString();
            txtIdProduto.Text = dgvProdutos.CurrentRow.Cells["id_produto"].Value.ToString();
            txtPrecoCusto.Text = dgvProdutos.CurrentRow.Cells["preco"].Value.ToString();
            txtPrecoVenda.Text = dgvProdutos.CurrentRow.Cells["preco_promocional"].Value.ToString();
            cbCategoria.Text = dgvProdutos.CurrentRow.Cells["nome_categoria"].Value.ToString();
            DataTable dtPath = new DataTable();
            dtPath = BusinesConfig.PathImage();
            image = dgvProdutos.CurrentRow.Cells["image"].Value.ToString();
            if (string.IsNullOrEmpty(image))
            {
                image = "default.png";
            }
            if (!File.Exists(dtPath.Rows[0]["image_path"].ToString() + image))
            {
                image = "default.png";
            }
            string url = dtPath.Rows[0]["image_path"].ToString() + image;
            fotoProduto.Load(url);
            fotoProduto.Load();
        }
        public static void ResizeImage(string originalFile, string newFile, int newWidth, int maxHeight, bool onlyResizeIfWider)
        {
            Image fullsizeImage = Image.FromFile(originalFile);

            // Prevent using images internal thumbnail
            fullsizeImage.RotateFlip(RotateFlipType.Rotate180FlipNone);
            fullsizeImage.RotateFlip(RotateFlipType.Rotate180FlipNone);

            if (onlyResizeIfWider)
            {
                if (fullsizeImage.Width <= newWidth)
                {
                    newWidth = fullsizeImage.Width;
                }
            }
            //int newHeight = newWidth;
            int newHeight = fullsizeImage.Height * newWidth / fullsizeImage.Width;
            if (newHeight > maxHeight)
            {
                // Resize with height instead
                newWidth = fullsizeImage.Width * maxHeight / fullsizeImage.Height;
                newHeight = maxHeight;
            }

            Image newImage = fullsizeImage.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);

            // Clear handle to original file so that we can overwrite it if necessary
            fullsizeImage.Dispose();

            // Save resized picture
            newImage.Save(newFile);
        }
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            this.IsNew = true;
            tabControl1.SelectedIndex = 2;
            txtCodigo.Focus();
            LimparCampos();
            HabilitarEdição();
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            lblSuc.Visible = false;
            lblError.Visible = false;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
                try
                {
                    string rpta = "";
                    if (this.txtCodigo.Text == string.Empty || this.txtDescricao.Text == string.Empty || this.txtPrecoCusto.Text == string.Empty ||
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
                            rpta = BusinesProduto.Produto_Cadastro(
                                this.txtCodigo.Text,
                                this.txtEAN.Text,
                                this.txtDescricao.Text.Trim().ToUpper(),
                                decimal.Parse(txtPrecoCusto.Text),
                                Convert.ToDecimal(this.txtPrecoCusto.Text),
                                Convert.ToDecimal(this.txtPrecoVenda.Text),
                                1,
                                image,
                                this.txtEmbalagem.Text,
                                Convert.ToInt32(txtEstoque.Text)
                                );
                        }
                        else
                        {
                            rpta = BusinesProduto.Produto_Update(
                                Convert.ToInt32(txtIdProduto.Text),
                                this.txtCodigo.Text,
                                this.txtEAN.Text,
                                this.txtDescricao.Text.Trim().ToUpper(),
                                decimal.Parse(txtPrecoCusto.Text),
                                Convert.ToDecimal(this.txtPrecoCusto.Text),
                                Convert.ToDecimal(this.txtPrecoVenda.Text),
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
                                lblError.Visible = false;
                            }
                            else
                            {
                                msgSuccess("Produto ATUALIZADO com Sucesso!");
                                lblError.Visible = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show(rpta);
                        }
                        IsNew = true;
                        btnSalvar.Enabled = false;
                        btnCancelar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnNovoCadastro.Enabled = true;
                        DesabilitarEdição();
                        txtCodigo.Focus();
                        CarregarGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.IsNew = true;
            tabControl1.SelectedIndex = 2;
            txtCodigo.Focus();
            LimparCampos();
            HabilitarEdição();
            btnNovoCadastro.Enabled = false;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            lblSuc.Visible = false;
            lblError.Visible = false;
            
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.IsNew = false;
            HabilitarEdição();
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            btnNovoCadastro.Enabled = false;
            btnCancelar.Enabled = true;
            lblError.Visible = false;
            lblSuc.Visible = false;
        }

        private void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            ProdutoSelecionado();
            IsNew = false;
            tabControl1.SelectedIndex = 2;
            DesabilitarEdição();
            lblError.Visible = false;
            lblSuc.Visible = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnNovoCadastro.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnNovoCadastro.Enabled = true;
            DesabilitarEdição();
            this.IsNew = true;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
