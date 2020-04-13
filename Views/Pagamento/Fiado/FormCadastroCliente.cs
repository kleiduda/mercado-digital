﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Busines;

namespace Views.Pagamento.Fiado
{
    public partial class FormCadastroCliente : Form
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }
        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            TabIndex();
        }
        //tabIndex
        public void TabIndex()
        {
            txtNome.TabIndex = 1;
            txtSobreNome.TabIndex = 2;
            txtCPF.TabIndex = 3;
            txtTelefone.TabIndex = 4;
            txtEmail.TabIndex = 5;
            txtCEP.TabIndex = 5;
            txtUF.TabIndex = 6;
            txtCidade.TabIndex = 7;
            txtBairro.TabIndex = 8;
            txtEndereco.TabIndex = 9;
            txtNumero.TabIndex = 10;
        }
        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            string obs = "";
            try
            {
                if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtCPF.Text) || string.IsNullOrEmpty(txtCEP.Text))
                {
                    MessageBox.Show("Campo obrigatório não preenchido");
                }
                else
                {
                    if (MessageBox.Show("Canfirmar Cadastro", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        rpta = BusinesCliente.InsertCadastroCliente
                        (
                            txtNome.Text.Trim().ToUpper(),
                            txtSobreNome.Text.Trim().ToUpper(),
                            txtCPF.Text.Trim().ToUpper(),
                            txtTelefone.Text.Trim().ToUpper(),
                            txtEmail.Text.Trim().ToUpper(),
                            txtCEP.Text.Trim().ToUpper(),
                            txtEndereco.Text.Trim().ToUpper(),
                            txtBairro.Text.Trim().ToUpper(),
                            txtCidade.Text.Trim().ToUpper(),
                            txtUF.Text.Trim().ToUpper(),
                            obs
                        );
                        this.Close();
                    }
                    else
                    {

                    }
                    
                }
                
            }
            catch (Exception ex)
            {

            }
        }

        
    }
}
