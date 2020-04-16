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

namespace Views.PDV
{
    public partial class FormCpfNota : Form
    {
        public FormCpfNota()
        {
            InitializeComponent();
        }

        private void FormCpfNota_Load(object sender, EventArgs e)
        {

        }
        //mensagens de erro e sucesso
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

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            string rpta = "";
            try
            {
                if (string.IsNullOrEmpty(txtCpf.Text))
                {
                    lblError.Visible = true;
                    lblSuc.Visible = false;
                    msgError("CAMPO CPF VAZIO!");
                }
                else
                {
                    rpta = BusinesCliente.CadastroCpf(txtCpf.Text);
                }
                if (rpta.Equals("OK"))
                {
                    this.Close();
                }
                else
                {
                    msgError("Erro ao cadsatrar");
                }
            }
            catch (Exception ex)
            {
                msgError(ex.Message + ex.StackTrace);
            }
        }
    }
}
