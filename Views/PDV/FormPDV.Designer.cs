﻿namespace Views
{
    partial class FormPDV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pProduct = new System.Windows.Forms.Panel();
            this.dgvItens = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisaProduto = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblData = new System.Windows.Forms.Label();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pCupom = new System.Windows.Forms.Panel();
            this.dgvCupom = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pTotal = new System.Windows.Forms.Panel();
            this.pHeaderCupom = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pCupom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pTotal.SuspendLayout();
            this.pHeaderCupom.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pProduct
            // 
            this.pProduct.BackColor = System.Drawing.Color.White;
            this.pProduct.Controls.Add(this.btnCancelarVenda);
            this.pProduct.Controls.Add(this.label4);
            this.pProduct.Controls.Add(this.label3);
            this.pProduct.Controls.Add(this.label2);
            this.pProduct.Controls.Add(this.label1);
            this.pProduct.Controls.Add(this.txtSubTotal);
            this.pProduct.Controls.Add(this.txtValorUnitario);
            this.pProduct.Controls.Add(this.txtDesconto);
            this.pProduct.Controls.Add(this.txtQuantidade);
            this.pProduct.Controls.Add(this.lblValor);
            this.pProduct.Controls.Add(this.lblDescricao);
            this.pProduct.Controls.Add(this.pictureBox1);
            this.pProduct.Controls.Add(this.txtPesquisaProduto);
            this.pProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pProduct.Location = new System.Drawing.Point(0, 72);
            this.pProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(681, 772);
            this.pProduct.TabIndex = 1;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AllowUserToOrderColumns = true;
            this.dgvItens.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItens.BackgroundColor = System.Drawing.Color.White;
            this.dgvItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItens.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItens.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvItens.DoubleBuffered = true;
            this.dgvItens.EnableHeadersVisualStyles = false;
            this.dgvItens.GridColor = System.Drawing.Color.White;
            this.dgvItens.HeaderBgColor = System.Drawing.Color.White;
            this.dgvItens.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvItens.Location = new System.Drawing.Point(733, -116);
            this.dgvItens.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItens.MultiSelect = false;
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItens.RowHeadersVisible = false;
            this.dgvItens.RowHeadersWidth = 62;
            this.dgvItens.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvItens.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvItens.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvItens.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvItens.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItens.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvItens.RowTemplate.Height = 40;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(656, 284);
            this.dgvItens.TabIndex = 147;
            this.dgvItens.Visible = false;
            this.dgvItens.Click += new System.EventHandler(this.dgvItens_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.btnCancelarVenda.FlatAppearance.BorderSize = 0;
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenda.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenda.ForeColor = System.Drawing.Color.White;
            this.btnCancelarVenda.Location = new System.Drawing.Point(16, 640);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(248, 61);
            this.btnCancelarVenda.TabIndex = 136;
            this.btnCancelarVenda.Text = "CANCELAR VENDA";
            this.btnCancelarVenda.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(511, 480);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 14);
            this.label4.TabIndex = 134;
            this.label4.Text = "Sub Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(348, 480);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 14);
            this.label3.TabIndex = 133;
            this.label3.Text = "Valor Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(181, 480);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 132;
            this.label2.Text = "Desconto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 480);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 14);
            this.label1.TabIndex = 131;
            this.label1.Text = "Quantidade";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Arial", 20F);
            this.txtSubTotal.ForeColor = System.Drawing.Color.Black;
            this.txtSubTotal.Location = new System.Drawing.Point(513, 505);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.MaxLength = 150;
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(160, 46);
            this.txtSubTotal.TabIndex = 130;
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.BackColor = System.Drawing.Color.White;
            this.txtValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorUnitario.Font = new System.Drawing.Font("Arial", 20F);
            this.txtValorUnitario.ForeColor = System.Drawing.Color.Black;
            this.txtValorUnitario.Location = new System.Drawing.Point(348, 505);
            this.txtValorUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.txtValorUnitario.MaxLength = 150;
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(160, 46);
            this.txtValorUnitario.TabIndex = 129;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.Color.White;
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Font = new System.Drawing.Font("Arial", 20F);
            this.txtDesconto.ForeColor = System.Drawing.Color.Black;
            this.txtDesconto.Location = new System.Drawing.Point(184, 505);
            this.txtDesconto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesconto.MaxLength = 150;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(160, 46);
            this.txtDesconto.TabIndex = 128;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.Color.White;
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Font = new System.Drawing.Font("Arial", 20F);
            this.txtQuantidade.ForeColor = System.Drawing.Color.Black;
            this.txtQuantidade.Location = new System.Drawing.Point(17, 505);
            this.txtQuantidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantidade.MaxLength = 150;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(160, 46);
            this.txtQuantidade.TabIndex = 127;
            this.txtQuantidade.Leave += new System.EventHandler(this.txtQuantidade_Leave);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblValor.Location = new System.Drawing.Point(245, 381);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(100, 48);
            this.lblValor.TabIndex = 126;
            this.lblValor.Text = "0,00\r\n";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblDescricao.Location = new System.Drawing.Point(244, 251);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(345, 66);
            this.lblDescricao.TabIndex = 125;
            this.lblDescricao.Text = "50.01.056 - BALEIRO PET\r\n150ML. TP.PRATA\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Views.Properties.Resources.Asset_1default;
            this.pictureBox1.Location = new System.Drawing.Point(16, 248);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 124;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisaProduto
            // 
            this.txtPesquisaProduto.BackColor = System.Drawing.Color.White;
            this.txtPesquisaProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisaProduto.Font = new System.Drawing.Font("Open Sans", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisaProduto.ForeColor = System.Drawing.Color.Black;
            this.txtPesquisaProduto.Location = new System.Drawing.Point(17, 132);
            this.txtPesquisaProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisaProduto.MaxLength = 150;
            this.txtPesquisaProduto.Name = "txtPesquisaProduto";
            this.txtPesquisaProduto.Size = new System.Drawing.Size(656, 52);
            this.txtPesquisaProduto.TabIndex = 123;
            this.txtPesquisaProduto.TextChanged += new System.EventHandler(this.txtPesquisaProduto_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.dgvItens);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Controls.Add(this.lblData);
            this.panel1.Controls.Add(this.lblVendedor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1444, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Arial Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(1263, 0);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(181, 72);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "FECHAR CAIXA";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Location = new System.Drawing.Point(173, 29);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(91, 19);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "20/03/2010";
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.ForeColor = System.Drawing.Color.White;
            this.lblVendedor.Location = new System.Drawing.Point(16, 28);
            this.lblVendedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(123, 19);
            this.lblVendedor.TabIndex = 0;
            this.lblVendedor.Text = "Kleiton Freitas";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 30.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTotal.Location = new System.Drawing.Point(587, 42);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 72);
            this.lblTotal.TabIndex = 138;
            this.lblTotal.Text = "0,00\r\n";
            // 
            // pCupom
            // 
            this.pCupom.BackColor = System.Drawing.Color.White;
            this.pCupom.Controls.Add(this.label9);
            this.pCupom.Controls.Add(this.pictureBox2);
            this.pCupom.Controls.Add(this.pHeaderCupom);
            this.pCupom.Controls.Add(this.dgvCupom);
            this.pCupom.Controls.Add(this.pTotal);
            this.pCupom.Controls.Add(this.bunifuSeparator1);
            this.pCupom.Dock = System.Windows.Forms.DockStyle.Right;
            this.pCupom.Location = new System.Drawing.Point(681, 72);
            this.pCupom.Margin = new System.Windows.Forms.Padding(4);
            this.pCupom.Name = "pCupom";
            this.pCupom.Size = new System.Drawing.Size(763, 772);
            this.pCupom.TabIndex = 139;
            // 
            // dgvCupom
            // 
            this.dgvCupom.AllowUserToAddRows = false;
            this.dgvCupom.AllowUserToDeleteRows = false;
            this.dgvCupom.AllowUserToOrderColumns = true;
            this.dgvCupom.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCupom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCupom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCupom.BackgroundColor = System.Drawing.Color.White;
            this.dgvCupom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCupom.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCupom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCupom.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCupom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCupom.DoubleBuffered = true;
            this.dgvCupom.EnableHeadersVisualStyles = false;
            this.dgvCupom.GridColor = System.Drawing.Color.White;
            this.dgvCupom.HeaderBgColor = System.Drawing.Color.White;
            this.dgvCupom.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvCupom.Location = new System.Drawing.Point(10, 0);
            this.dgvCupom.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCupom.MultiSelect = false;
            this.dgvCupom.Name = "dgvCupom";
            this.dgvCupom.ReadOnly = true;
            this.dgvCupom.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCupom.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCupom.RowHeadersVisible = false;
            this.dgvCupom.RowHeadersWidth = 62;
            this.dgvCupom.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvCupom.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCupom.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCupom.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvCupom.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCupom.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCupom.RowTemplate.Height = 40;
            this.dgvCupom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCupom.Size = new System.Drawing.Size(753, 521);
            this.dgvCupom.TabIndex = 148;
            this.dgvCupom.Visible = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 24.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label9.Location = new System.Drawing.Point(226, 74);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(278, 58);
            this.label9.TabIndex = 138;
            this.label9.Text = "Caixa Livre";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Views.Properties.Resources.Asset_2loja;
            this.pictureBox2.Location = new System.Drawing.Point(174, 150);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 315);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pTotal
            // 
            this.pTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pTotal.Controls.Add(this.button3);
            this.pTotal.Controls.Add(this.button4);
            this.pTotal.Controls.Add(this.button2);
            this.pTotal.Controls.Add(this.button1);
            this.pTotal.Controls.Add(this.label16);
            this.pTotal.Controls.Add(this.label15);
            this.pTotal.Controls.Add(this.label14);
            this.pTotal.Controls.Add(this.label13);
            this.pTotal.Controls.Add(this.label12);
            this.pTotal.Controls.Add(this.label11);
            this.pTotal.Controls.Add(this.label10);
            this.pTotal.Controls.Add(this.lblTotal);
            this.pTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pTotal.Location = new System.Drawing.Point(10, 521);
            this.pTotal.Margin = new System.Windows.Forms.Padding(4);
            this.pTotal.Name = "pTotal";
            this.pTotal.Size = new System.Drawing.Size(753, 251);
            this.pTotal.TabIndex = 1;
            // 
            // pHeaderCupom
            // 
            this.pHeaderCupom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pHeaderCupom.Controls.Add(this.label8);
            this.pHeaderCupom.Controls.Add(this.label7);
            this.pHeaderCupom.Controls.Add(this.label6);
            this.pHeaderCupom.Controls.Add(this.label5);
            this.pHeaderCupom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeaderCupom.Location = new System.Drawing.Point(10, 0);
            this.pHeaderCupom.Margin = new System.Windows.Forms.Padding(4);
            this.pHeaderCupom.Name = "pHeaderCupom";
            this.pHeaderCupom.Size = new System.Drawing.Size(753, 41);
            this.pHeaderCupom.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(663, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 142;
            this.label8.Text = "SubTotal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(492, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 14);
            this.label7.TabIndex = 141;
            this.label7.Text = "Preco un.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(347, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 14);
            this.label6.TabIndex = 140;
            this.label6.Text = "Qtde.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 14);
            this.label5.TabIndex = 139;
            this.label5.Text = "Nome do Produto";
            // 
            // panelContainer
            // 
            this.panelContainer.Controls.Add(this.pProduct);
            this.panelContainer.Controls.Add(this.pCupom);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1444, 844);
            this.panelContainer.TabIndex = 140;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(38, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 19);
            this.label10.TabIndex = 148;
            this.label10.Text = "Sub Total:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(38, 56);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 19);
            this.label11.TabIndex = 149;
            this.label11.Text = "Desconto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(38, 83);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 19);
            this.label12.TabIndex = 150;
            this.label12.Text = "Tax:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(117, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 20);
            this.label13.TabIndex = 148;
            this.label13.Text = "22.90";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(116, 55);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 20);
            this.label14.TabIndex = 151;
            this.label14.Text = "4.99";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(115, 81);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 20);
            this.label15.TabIndex = 152;
            this.label15.Text = "1.99";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Open Sans", 8F);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(604, 30);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 19);
            this.label16.TabIndex = 153;
            this.label16.Text = "TOTAL";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(42, 119);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(340, 57);
            this.button1.TabIndex = 148;
            this.button1.Text = "Dinheiro";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(396, 119);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(340, 57);
            this.button2.TabIndex = 154;
            this.button2.Text = "Débito";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(396, 186);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(340, 57);
            this.button3.TabIndex = 156;
            this.button3.Text = "Crédito";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(42, 186);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(340, 57);
            this.button4.TabIndex = 155;
            this.button4.Text = "Fiado";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.DimGray;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 772);
            this.bunifuSeparator1.TabIndex = 149;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // FormPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1444, 844);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPDV_Load);
            this.pProduct.ResumeLayout(false);
            this.pProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pCupom.ResumeLayout(false);
            this.pCupom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCupom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pTotal.ResumeLayout(false);
            this.pTotal.PerformLayout();
            this.pHeaderCupom.ResumeLayout(false);
            this.pHeaderCupom.PerformLayout();
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pProduct;
        public System.Windows.Forms.TextBox txtPesquisaProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSubTotal;
        public System.Windows.Forms.TextBox txtValorUnitario;
        public System.Windows.Forms.TextBox txtDesconto;
        public System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pCupom;
        private System.Windows.Forms.Panel pTotal;
        private System.Windows.Forms.Panel pHeaderCupom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvItens;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCupom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelContainer;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
    }
}

