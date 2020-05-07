using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Views.Administrador;
using Supporte.Enums;
using Busines;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Views.Produtos
{
    public partial class FormVendedores : Form
    {
        private bool IsNew = true;
        string image = "";
        public FormVendedores()
        {
            InitializeComponent();
        }
        
        private void FormListaVendedor_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            CarregarDataGrid();
            ListarCargos();
        }
        #region abrir forms

        #endregion
        private void btnNovo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            LimparCampos();
            txtNome.Focus();
            lblState.Text = "cadastro";
            btnEditar.Enabled = false;
            btnNovoCadastro.Enabled = false;
            this.IsNew = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblState.Text = "lista";
        }
        #region metodos form lista
        //listar cadastros
        public void CarregarDataGrid()
        {
            dgvVendedores.DataSource = BusinesUsuario.ListarUsuarios();
            dgvVendedores.Columns["id_vendedor"].Visible = false;
            dgvVendedores.Columns["id_cargo"].Visible = false;
            dgvVendedores.Columns["senha"].Visible = false;
            dgvVendedores.Columns["foto"].Visible = false;
            dgvVendedores.Columns["login"].Visible = false;
        }
        #endregion
        #region metodos do form cadastro
        public void DesabilitarEdição()
        {
            txtNome.Enabled = false;
            txtSobreNome.Enabled = false;
            txtEmail.Enabled = false;
            txtLogin.Enabled = false;
            txtTelefone.Enabled = false;
            txtSenha.Enabled = false;
            cbCargo.Enabled = false;
            fotoVendedor.Enabled = false;
            
        }
        public void EnabledEdit()
        {
            txtNome.Enabled = true;
            txtSobreNome.Enabled = true;
            txtEmail.Enabled = true;
            txtLogin.Enabled = true;
            txtTelefone.Enabled = true;
            txtSenha.Enabled = true;
            cbCargo.Enabled = true;
            fotoVendedor.Enabled = true;
            txtNome.Focus();
        }
        private void IndexTab()
        {
            cbCargo.TabIndex = 3;
            txtNome.TabIndex = 1;
            txtSobreNome.TabIndex = 2;
            txtTelefone.TabIndex = 4;
            txtEmail.TabIndex = 5;
            txtLogin.TabIndex = 6;
            txtSenha.TabIndex = 7;
            btnSalvar.TabIndex = 8;
        }
        private void LimparCampos()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtSobreNome.Clear();
            txtEmail.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtIdVendedor.Clear();
            fotoVendedor.Image = Properties.Resources.Asset_1default;
        }
        private void ListarCargos()
        {
            cbCargo.DataSource = BusinesUsuario.ListarFuncoes();
            cbCargo.ValueMember = "id_cargo";
            cbCargo.DisplayMember = "cargo";
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
       
        //redimesionar
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
        private void fotoVendedor_Click(object sender, EventArgs e)
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
                this.fotoVendedor.Image = Image.FromFile(openFileDialog.FileName);
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
        public void VendedorSelecionado()
        {
            DataTable dt = new DataTable();
            dt = BusinesConfig.PathImage();
            txtNome.Text = dgvVendedores.CurrentRow.Cells["nome"].Value.ToString();
            txtSobreNome.Text = dgvVendedores.CurrentRow.Cells["sobre_nome"].Value.ToString();
            txtEmail.Text = dgvVendedores.CurrentRow.Cells["email"].Value.ToString();
            txtLogin.Text = dgvVendedores.CurrentRow.Cells["login"].Value.ToString();
            txtSenha.Text = dgvVendedores.CurrentRow.Cells["senha"].Value.ToString();
            txtTelefone.Text = dgvVendedores.CurrentRow.Cells["telefone"].Value.ToString();
            txtIdVendedor.Text = dgvVendedores.CurrentRow.Cells["id_vendedor"].Value.ToString();
            DataTable dtPath = new DataTable();
            dtPath = BusinesConfig.PathImage();
            image = dgvVendedores.CurrentRow.Cells["foto"].Value.ToString();
            if (string.IsNullOrEmpty(image))
            {
                image = "default.png";
            }
            if (!File.Exists(dtPath.Rows[0]["image_path"].ToString() + image))
            {
                image = "default.png";
            }
            string url = dtPath.Rows[0]["image_path"].ToString() + image;
            fotoVendedor.Load(url);
            fotoVendedor.Load();
        }
        private void dgvVendedores_DoubleClick(object sender, EventArgs e)
        {
            VendedorSelecionado();
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
        private void btnEditar_Click(object sender, EventArgs e)
        {
            EnabledEdit();
            btnSalvar.Enabled = true;
            btnNovoCadastro.Enabled = false;
            btnCancelar.Enabled = true;
            this.IsNew = false;
        }
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
                else if (BusinesUsuario.ValidaUsuario(txtLogin.Text) && IsNew == true)
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
                            Convert.ToInt32(cbCargo.SelectedValue),
                            this.txtSenha.Text,
                            image
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
                            Convert.ToInt32(cbCargo.SelectedValue),
                            this.txtSenha.Text,
                            image
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
                    btnSalvar.Enabled = false;
                    btnCancelar.Enabled = false;
                    btnEditar.Enabled = true;
                    btnNovoCadastro.Enabled = true;
                    DesabilitarEdição();
                    txtNome.Focus();
                    CarregarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
       
        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
            txtNome.Focus();
            LimparCampos();
            EnabledEdit();
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;
            this.IsNew = true;
        }
        #endregion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = true;
            btnSalvar.Enabled = false;
            DesabilitarEdição();
            this.IsNew = true;
        }
    }
}
