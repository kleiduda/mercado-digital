using Busines;
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

namespace Views.Produtos
{
    public partial class FormCadastroProduto : Form
    {
        private bool IsNew = true;
        string image = "";
        public FormCadastroProduto()
        {
            InitializeComponent();
        }
        public FormCadastroProduto(string value)
        {
            InitializeComponent();
            txtId.Text = value;
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            ListarCategorias();
            if (txtId.Text != "new")
            {
                IsNew = false;
                Produto();
            }

        }
        public void Produto()
        {
            DataTable dt = new DataTable();
            dt = BusinesProduto.Produto_ListaPorId(Convert.ToInt32(txtId.Text));
            txtCodigo.Text = dt.Rows[0]["codigo"].ToString();
            txtDescricao.Text = dt.Rows[0]["descricao"].ToString();
            txtEAN.Text = dt.Rows[0]["ean"].ToString();
            txtEmbalagem.Text = dt.Rows[0]["embalagem"].ToString();
            txtEstoque.Text = dt.Rows[0]["estoque"].ToString();
            txtM3.Text = dt.Rows[0]["metro_cubico"].ToString();
            txtPrecoCusto.Text = dt.Rows[0]["preco_custo"].ToString();
            txtPrecoPromocional.Text = dt.Rows[0]["preco_promocional"].ToString();
            txtPrecoUnidade.Text = dt.Rows[0]["preco_unidade"].ToString();
            txtPrecoVenda.Text = dt.Rows[0]["preco"].ToString();
            txtQtdEmbalagem.Text = dt.Rows[0]["qtd_embalagem"].ToString();
            txtTipoEmbalagem.Text = dt.Rows[0]["tipo_embalagem"].ToString();
            txtMedida.Text = dt.Rows[0]["medida"].ToString();

        }
        public void Clean()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtEAN.Clear();
            txtEmbalagem.Clear();
            txtEstoque.Clear();
            txtId.Clear();
            txtPrecoCusto.Clear();
            txtPrecoPromocional.Clear();
            txtPrecoUnidade.Clear();
            txtPrecoVenda.Clear();
            txtQtdEmbalagem.Clear();
            txtTipoEmbalagem.Clear();
            txtM3.Clear();
            txtMedida.Clear();

        }
        public void DisableEdit()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtEAN.Enabled = false;
            txtEmbalagem.Enabled = false;
            txtEstoque.Enabled = false;
            txtId.Enabled = false;
            txtPrecoCusto.Enabled = false;
            txtPrecoPromocional.Enabled = false;
            txtPrecoUnidade.Enabled = false;
            txtPrecoVenda.Enabled = false;
            txtQtdEmbalagem.Enabled = false;
            txtTipoEmbalagem.Enabled = false;
            txtM3.Enabled = false;
            cbCategoria.Enabled = false;
            txtMedida.Enabled = false;
        }
        public void EnabledEdit()
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtEAN.Enabled = true;
            txtEmbalagem.Enabled = true;
            txtEstoque.Enabled = true;
            txtId.Enabled = true;
            txtPrecoCusto.Enabled = true;
            txtPrecoPromocional.Enabled = true;
            txtPrecoUnidade.Enabled = true;
            txtPrecoVenda.Enabled = true;
            txtQtdEmbalagem.Enabled = true;
            txtTipoEmbalagem.Enabled = true;
            txtM3.Enabled = true;
            cbCategoria.Enabled = true;
            txtMedida.Enabled = true;
        }
        public void ValidateForm()
        {
            if (string.IsNullOrEmpty(txtPrecoVenda.Text))
            {
                txtPrecoVenda.BackColor = Color.Red;
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
        public void ListarCategorias()
        {
            cbCategoria.DataSource = BusinesProduto.ListarCategorias();
            cbCategoria.DisplayMember = "nome_categoria";
            cbCategoria.ValueMember = "id_categoria";
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
                            Convert.ToDecimal(this.txtPrecoVenda.Text),
                            Convert.ToDecimal(this.txtPrecoPromocional.Text),
                            1,
                            image,
                            this.txtEmbalagem.Text,
                            Convert.ToInt32(txtEstoque.Text),
                            txtTipoEmbalagem.Text.Trim().ToUpper(),
                            Convert.ToInt32(txtQtdEmbalagem.Text),
                            Convert.ToDecimal(txtPrecoUnidade.Text),
                            Convert.ToDecimal(txtM3.Text),
                            txtMedida.Text
                            );
                    }
                    else
                    {
                        rpta = BusinesProduto.Produto_Update(
                            Convert.ToInt32(txtId.Text),
                            this.txtCodigo.Text,
                            this.txtEAN.Text,
                            this.txtDescricao.Text.Trim().ToUpper(),
                            decimal.Parse(txtPrecoCusto.Text),
                            Convert.ToDecimal(this.txtPrecoVenda.Text),
                            Convert.ToDecimal(this.txtPrecoPromocional.Text),
                            1,
                            image,
                            this.txtEmbalagem.Text,
                            Convert.ToInt32(txtEstoque.Text),
                            txtTipoEmbalagem.Text.Trim().ToUpper(),
                            Convert.ToInt32(txtQtdEmbalagem.Text),
                            Convert.ToDecimal(txtPrecoUnidade.Text),
                            Convert.ToDecimal(txtM3.Text),
                            txtMedida.Text
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
                    DisableEdit();
                    txtCodigo.Focus();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            Clean();
            EnabledEdit();
            txtCodigo.Focus();
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnNovoCadastro.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledEdit();
            btnNovoCadastro.Enabled = false;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DisableEdit();
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
            btnCancelar.Enabled = false;
            btnNovoCadastro.Enabled = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FormAddCategoria frm = new FormAddCategoria();
            frm.ShowDialog();
            ListarCategorias();
        }
    }
}
