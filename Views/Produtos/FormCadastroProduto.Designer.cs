﻿namespace Views
{
    partial class FormCadastroProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.pProduct = new System.Windows.Forms.Panel();
            this.imageProduto = new System.Windows.Forms.PictureBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtPrecoPromocional = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtEmbalagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblSuc = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            //this.SuspendLayout();
            // 
            // pProduct
            // 
            this.pProduct.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pProduct.Controls.Add(this.txtEAN);
            this.pProduct.Controls.Add(this.label6);
            this.pProduct.Controls.Add(this.label5);
            this.pProduct.Controls.Add(this.txtCodigo);
            this.pProduct.Controls.Add(this.cbCategoria);
            this.pProduct.Controls.Add(this.pictureBox1);
            this.pProduct.Controls.Add(this.imageProduto);
            this.pProduct.Controls.Add(this.lblSuc);
            this.pProduct.Controls.Add(this.lblError);
            this.pProduct.Controls.Add(this.label7);
            this.pProduct.Controls.Add(this.txtDescricao);
            this.pProduct.Controls.Add(this.txtPrecoPromocional);
            this.pProduct.Controls.Add(this.txtPreco);
            this.pProduct.Controls.Add(this.label4);
            this.pProduct.Controls.Add(this.txtEstoque);
            this.pProduct.Controls.Add(this.label3);
            this.pProduct.Controls.Add(this.txtEmbalagem);
            this.pProduct.Controls.Add(this.label2);
            this.pProduct.Controls.Add(this.label1);
            this.pProduct.Location = new System.Drawing.Point(258, 117);
            this.pProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(867, 484);
            this.pProduct.TabIndex = 2;
            // 
            // imageProduto
            // 
            this.imageProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imageProduto.Image = ((System.Drawing.Image)(resources.GetObject("imageProduto.Image")));
            this.imageProduto.Location = new System.Drawing.Point(37, 17);
            this.imageProduto.Margin = new System.Windows.Forms.Padding(4);
            this.imageProduto.Name = "imageProduto";
            this.imageProduto.Size = new System.Drawing.Size(130, 130);
            this.imageProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageProduto.TabIndex = 124;
            this.imageProduto.TabStop = false;
           // this.imageProduto.Click += new System.EventHandler(this.imageProduto_Click);
            // 
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPreco.ForeColor = System.Drawing.Color.Black;
            this.txtPreco.Location = new System.Drawing.Point(41, 355);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.MaxLength = 150;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(180, 30);
            this.txtPreco.TabIndex = 127;
            // 
            // txtPrecoPromocional
            // 
            this.txtPrecoPromocional.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoPromocional.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecoPromocional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoPromocional.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPrecoPromocional.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoPromocional.Location = new System.Drawing.Point(231, 355);
            this.txtPrecoPromocional.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoPromocional.MaxLength = 150;
            this.txtPrecoPromocional.Name = "txtPrecoPromocional";
            this.txtPrecoPromocional.Size = new System.Drawing.Size(180, 30);
            this.txtPrecoPromocional.TabIndex = 128;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstoque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoque.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEstoque.ForeColor = System.Drawing.Color.Black;
            this.txtEstoque.Location = new System.Drawing.Point(421, 355);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoque.MaxLength = 150;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(180, 30);
            this.txtEstoque.TabIndex = 129;
            // 
            // txtEmbalagem
            // 
            this.txtEmbalagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmbalagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmbalagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmbalagem.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmbalagem.ForeColor = System.Drawing.Color.Black;
            this.txtEmbalagem.Location = new System.Drawing.Point(610, 355);
            this.txtEmbalagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmbalagem.MaxLength = 150;
            this.txtEmbalagem.Name = "txtEmbalagem";
            this.txtEmbalagem.Size = new System.Drawing.Size(180, 30);
            this.txtEmbalagem.TabIndex = 130;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 14);
            this.label1.TabIndex = 131;
            this.label1.Text = "Preço";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(230, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 14);
            this.label2.TabIndex = 132;
            this.label2.Text = "Preço Promocional";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(421, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 133;
            this.label3.Text = "Estoque";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(606, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 14);
            this.label4.TabIndex = 134;
            this.label4.Text = "Embalagem (un, pct, caixa)";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCodigo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 16F);
            this.txtCodigo.ForeColor = System.Drawing.Color.Black;
            this.txtCodigo.Location = new System.Drawing.Point(37, 178);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.MaxLength = 150;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(255, 38);
            this.txtCodigo.TabIndex = 123;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(37, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 14);
            this.label5.TabIndex = 138;
            this.label5.Text = "Código";
            // 
            // txtEAN
            // 
            this.txtEAN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEAN.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEAN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEAN.Font = new System.Drawing.Font("Arial", 16F);
            this.txtEAN.ForeColor = System.Drawing.Color.Black;
            this.txtEAN.Location = new System.Drawing.Point(307, 178);
            this.txtEAN.Margin = new System.Windows.Forms.Padding(4);
            this.txtEAN.MaxLength = 150;
            this.txtEAN.Name = "txtEAN";
            this.txtEAN.Size = new System.Drawing.Size(255, 38);
            this.txtEAN.TabIndex = 139;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(307, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 14);
            this.label6.TabIndex = 140;
            this.label6.Text = "EAN";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescricao.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Font = new System.Drawing.Font("Arial", 16F);
            this.txtDescricao.ForeColor = System.Drawing.Color.Black;
            this.txtDescricao.Location = new System.Drawing.Point(37, 270);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.MaxLength = 150;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(753, 38);
            this.txtDescricao.TabIndex = 141;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(37, 253);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 142;
            this.label7.Text = "Descrição";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Image = global::Views.Properties.Resources.report_min;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(42, 413);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(234, 20);
            this.lblError.TabIndex = 144;
            this.lblError.Text = "         erro ao fazer o login";
            this.lblError.Visible = false;
            // 
            // lblSuc
            // 
            this.lblSuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSuc.AutoSize = true;
            this.lblSuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.lblSuc.Image = global::Views.Properties.Resources.sucesso;
            this.lblSuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuc.Location = new System.Drawing.Point(42, 413);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(278, 20);
            this.lblSuc.TabIndex = 145;
            this.lblSuc.Text = "         erro ao cadastrar produto";
            this.lblSuc.Visible = false;
            // 
            // cbCategoria
            // 
            this.cbCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbCategoria.BackColor = System.Drawing.SystemColors.Control;
            this.cbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(573, 180);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(217, 33);
            this.cbCategoria.TabIndex = 151;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Views.Properties.Resources.plus;
            this.pictureBox1.Location = new System.Drawing.Point(797, 186);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 144;
            this.pictureBox1.TabStop = false;
          //  this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::Views.Properties.Resources.delete;
            this.btnClose.Location = new System.Drawing.Point(1270, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 143;
            this.btnClose.TabStop = false;
            // this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.label9);
            this.panelContainer.Controls.Add(this.panel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1436, 747);
            this.panelContainer.TabIndex = 141;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 342);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 44);
            this.label9.TabIndex = 153;
            this.label9.Text = "#PRODUTOS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel1.Controls.Add(this.pProduct);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(106, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 695);
            this.panel1.TabIndex = 154;
            // 
            // FormCadastroProduto
            // 
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            //this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackColor = System.Drawing.Color.White;
            //this.ClientSize = new System.Drawing.Size(1436, 747);
            //this.Controls.Add(this.panelContainer);
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "FormCadastroProduto";
            //this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            //this.Text = "Form1";
            //this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            this.pProduct.ResumeLayout(false);
            this.pProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
          //  this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pProduct;
        public System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imageProduto;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtPrecoPromocional;
        public System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtEmbalagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
    }
}

