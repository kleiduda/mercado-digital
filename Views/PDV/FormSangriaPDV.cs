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
using Supporte.Cache;

namespace Views
{
    public partial class FormSangriaPDV : Form
    {
        private bool IsNew;
        public FormSangriaPDV()
        {
            InitializeComponent();
        }
        private void FormValorInicial_Load(object sender, EventArgs e)
        {
            DadosValoresVendas();
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
        private void DadosValoresVendas()
        {
            DataTable dtCaixa = new DataTable();
            dtCaixa = BusinesCaixa.ValoresCaixa(UserLoginCache.IdUser, CacheIdCaixa.IdCaixa);
            DataTable dt = new DataTable();
            dt = BusinesCaixa.ValoresVendaTotal(UserLoginCache.IdUser);
            //
            var vendasDoDia = dt.AsEnumerable().Where(x=>x.Field<int>("id") == CacheIdCaixa.IdCaixa).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var dinheiro = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 1).Where(x => x.Field<int>("id") == CacheIdCaixa.IdCaixa).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var debito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 2).Where(x => x.Field<int>("id") == CacheIdCaixa.IdCaixa).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var credito = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 3).Where(x => x.Field<int>("id") == CacheIdCaixa.IdCaixa).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var fiado = dt.AsEnumerable().Where(x => x.Field<int>("id_pagamento") == 4).Where(x => x.Field<int>("id") == CacheIdCaixa.IdCaixa).Sum(x => x.Field<decimal>("TotalDeVendas"));
            var troco = CaixaCache.Troco;
            var maxSangria = troco + dinheiro;
            var totalDeVendas = dinheiro + debito + credito + fiado;
            //
            lblTotalDeVendas.Text = totalDeVendas.ToString();
            txtValor.Text = maxSangria.ToString();
            lblTrocoInicial.Text = troco.ToString();
            lblVendaCredito.Text = credito.ToString();
            lblVendaDebito.Text = debito.ToString();
            lblVendaDinheiro.Text = dinheiro.ToString();
            lblVendaFiado.Text = fiado.ToString();
        }
        private void btnValidar_Click(object sender, EventArgs e)
        {
            string rpta = "";
            var totalFechamento = decimal.Parse(lblTrocoInicial.Text) + decimal.Parse(lblTotalDeVendas.Text) - decimal.Parse(txtValor.Text);
            try
            {
                if (string.IsNullOrEmpty(txtValor.Text))
                {
                    msgError("Campo vazio, preencha com 0 (zero), se não tiver valor!");
                }
                else
                {
                    rpta = BusinesCaixa.FecharCaixa(CacheIdCaixa.IdCaixa ,UserLoginCache.IdUser,totalFechamento,Convert.ToDecimal(txtValor.Text),Supporte.Enums.StatusCaixa.Fechado);
                }
                if (rpta == "OK")
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show(rpta);
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
    }
}
