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

namespace Views.Setting
{
    public partial class SettingGeral : Form
    {
        public SettingGeral()
        {
            InitializeComponent();
        }

        private void SettingGeral_Load(object sender, EventArgs e)
        {
            lblUser.Text ="Olá, " + UserLoginCache.Nome + " " + UserLoginCache.SobreNome; 
            DataTable dt = new DataTable();
            dt = BusinesConfig.PathImage();
            if (dt.Rows.Count != 0)
            {
                string imagePath = dt.Rows[0]["image_path"].ToString();
                lblFolderPath.Visible = true;
                lblFolderPath.Text = "      Suas imagens estão sendo gravadas no caminho: " + imagePath;
            }
            else
            {
                msgAlert("Defina uma pasta para guardar as imagens dos produtos, vendedores...");
            }
        }
        //mensagens customizadas
        private void msgSuccess(string msg)
        {
            lblSuc.Text = "      " + msg;
            lblSuc.Visible = true;
        }
        private void msgAlert(string msg)
        {
            lblAlert.Text = "      " + msg;
            lblAlert.Visible = true;
        }
        public void UploadImagePath()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = BusinesConfig.PathImage();
                string rpta = "";
                if (!string.IsNullOrEmpty(txtPathImage.Text))
                {
                    rpta = BusinesConfig.CadastroPathImage(txtPathImage.Text);
                    lblFolderPath.Visible = false;
                    lblAlert.Visible = false;
                    msgSuccess("Ok, gravei sua pasta de imagens com sucesso! Apartir de agora essa é sua pasta de imagens!");
                }
            }
            catch (Exception ex)
            {
                msgSuccess(ex.Message + ex.StackTrace);
            }

        }
        private void txtPathImage_Click(object sender, EventArgs e)
        {
            if (fbd1.ShowDialog() == DialogResult.OK)
            { 
                txtPathImage.Text = fbd1.SelectedPath + @"\"; 
                UploadImagePath(); 
            }

        }
    }
}
