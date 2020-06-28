namespace Views.Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroProduto));
            this.label9 = new System.Windows.Forms.Label();
            this.btnNovoCadastro = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pProduct = new System.Windows.Forms.Panel();
            this.txtPrecoPromocional = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAddCategoria = new System.Windows.Forms.PictureBox();
            this.fotoProduto = new System.Windows.Forms.PictureBox();
            this.lblSuc = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPrecoVenda = new System.Windows.Forms.TextBox();
            this.txtPrecoCusto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmbalagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pButtons = new System.Windows.Forms.Panel();
            this.pInfoExtra = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtM3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrecoUnidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtdEmbalagem = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipoEmbalagem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.pProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoProduto)).BeginInit();
            this.pButtons.SuspendLayout();
            this.pInfoExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(28, 22);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 44);
            this.label9.TabIndex = 161;
            this.label9.Text = "#PRODUTOS";
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.FlatAppearance.BorderSize = 0;
            this.btnNovoCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.Image = global::Views.Properties.Resources.add__lista;
            this.btnNovoCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCadastro.Location = new System.Drawing.Point(10, 25);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Size = new System.Drawing.Size(179, 31);
            this.btnNovoCadastro.TabIndex = 162;
            this.btnNovoCadastro.Text = "NOVO CADASTRO";
            this.btnNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovoCadastro.UseVisualStyleBackColor = true;
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Views.Properties.Resources.edit;
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(897, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 31);
            this.btnEditar.TabIndex = 163;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Views.Properties.Resources.cancel;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1055, 25);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 31);
            this.btnCancelar.TabIndex = 164;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::Views.Properties.Resources.save;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(1238, 25);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(111, 31);
            this.btnSalvar.TabIndex = 165;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pProduct
            // 
            this.pProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pProduct.Controls.Add(this.txtPrecoPromocional);
            this.pProduct.Controls.Add(this.label8);
            this.pProduct.Controls.Add(this.txtId);
            this.pProduct.Controls.Add(this.txtEAN);
            this.pProduct.Controls.Add(this.label6);
            this.pProduct.Controls.Add(this.label5);
            this.pProduct.Controls.Add(this.txtCodigo);
            this.pProduct.Controls.Add(this.cbCategoria);
            this.pProduct.Controls.Add(this.btnAddCategoria);
            this.pProduct.Controls.Add(this.fotoProduto);
            this.pProduct.Controls.Add(this.lblSuc);
            this.pProduct.Controls.Add(this.lblError);
            this.pProduct.Controls.Add(this.label7);
            this.pProduct.Controls.Add(this.txtDescricao);
            this.pProduct.Controls.Add(this.txtPrecoVenda);
            this.pProduct.Controls.Add(this.txtPrecoCusto);
            this.pProduct.Controls.Add(this.label4);
            this.pProduct.Controls.Add(this.txtEstoque);
            this.pProduct.Controls.Add(this.label3);
            this.pProduct.Controls.Add(this.txtEmbalagem);
            this.pProduct.Controls.Add(this.label2);
            this.pProduct.Controls.Add(this.label1);
            this.pProduct.Location = new System.Drawing.Point(36, 172);
            this.pProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(867, 484);
            this.pProduct.TabIndex = 168;
            // 
            // txtPrecoPromocional
            // 
            this.txtPrecoPromocional.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoPromocional.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecoPromocional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoPromocional.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPrecoPromocional.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoPromocional.Location = new System.Drawing.Point(352, 355);
            this.txtPrecoPromocional.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoPromocional.MaxLength = 150;
            this.txtPrecoPromocional.Name = "txtPrecoPromocional";
            this.txtPrecoPromocional.Size = new System.Drawing.Size(132, 30);
            this.txtPrecoPromocional.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(351, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 14);
            this.label8.TabIndex = 154;
            this.label8.Text = "Preço Promocional";
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Arial", 16F);
            this.txtId.ForeColor = System.Drawing.Color.Black;
            this.txtId.Location = new System.Drawing.Point(692, 401);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 150;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(98, 38);
            this.txtId.TabIndex = 152;
            this.txtId.Visible = false;
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
            this.txtEAN.TabIndex = 2;
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
            this.txtCodigo.TabIndex = 1;
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
            this.cbCategoria.TabIndex = 3;
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddCategoria.Image = global::Views.Properties.Resources.plus;
            this.btnAddCategoria.Location = new System.Drawing.Point(797, 186);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(20, 20);
            this.btnAddCategoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddCategoria.TabIndex = 144;
            this.btnAddCategoria.TabStop = false;
            this.btnAddCategoria.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // fotoProduto
            // 
            this.fotoProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fotoProduto.Image = ((System.Drawing.Image)(resources.GetObject("fotoProduto.Image")));
            this.fotoProduto.Location = new System.Drawing.Point(37, 17);
            this.fotoProduto.Margin = new System.Windows.Forms.Padding(4);
            this.fotoProduto.Name = "fotoProduto";
            this.fotoProduto.Size = new System.Drawing.Size(130, 130);
            this.fotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoProduto.TabIndex = 124;
            this.fotoProduto.TabStop = false;
            this.fotoProduto.Click += new System.EventHandler(this.imageProduto_Click);
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
            this.txtDescricao.TabIndex = 4;
            // 
            // txtPrecoVenda
            // 
            this.txtPrecoVenda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoVenda.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoVenda.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPrecoVenda.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoVenda.Location = new System.Drawing.Point(196, 355);
            this.txtPrecoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoVenda.MaxLength = 150;
            this.txtPrecoVenda.Name = "txtPrecoVenda";
            this.txtPrecoVenda.Size = new System.Drawing.Size(132, 30);
            this.txtPrecoVenda.TabIndex = 6;
            // 
            // txtPrecoCusto
            // 
            this.txtPrecoCusto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoCusto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoCusto.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPrecoCusto.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoCusto.Location = new System.Drawing.Point(37, 355);
            this.txtPrecoCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoCusto.MaxLength = 150;
            this.txtPrecoCusto.Name = "txtPrecoCusto";
            this.txtPrecoCusto.Size = new System.Drawing.Size(132, 30);
            this.txtPrecoCusto.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(654, 338);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 14);
            this.label4.TabIndex = 134;
            this.label4.Text = "Quantidade Pacote";
            // 
            // txtEstoque
            // 
            this.txtEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstoque.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEstoque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEstoque.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEstoque.ForeColor = System.Drawing.Color.Black;
            this.txtEstoque.Location = new System.Drawing.Point(506, 355);
            this.txtEstoque.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoque.MaxLength = 150;
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(132, 30);
            this.txtEstoque.TabIndex = 129;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(506, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 14);
            this.label3.TabIndex = 133;
            this.label3.Text = "Estoque";
            // 
            // txtEmbalagem
            // 
            this.txtEmbalagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmbalagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmbalagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmbalagem.Font = new System.Drawing.Font("Arial", 12F);
            this.txtEmbalagem.ForeColor = System.Drawing.Color.Black;
            this.txtEmbalagem.Location = new System.Drawing.Point(658, 355);
            this.txtEmbalagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmbalagem.MaxLength = 150;
            this.txtEmbalagem.Name = "txtEmbalagem";
            this.txtEmbalagem.Size = new System.Drawing.Size(132, 30);
            this.txtEmbalagem.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(195, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 132;
            this.label2.Text = "Preço de Venda";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(41, 338);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 14);
            this.label1.TabIndex = 131;
            this.label1.Text = "Preço de Custo";
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.btnNovoCadastro);
            this.pButtons.Controls.Add(this.btnEditar);
            this.pButtons.Controls.Add(this.btnCancelar);
            this.pButtons.Controls.Add(this.btnSalvar);
            this.pButtons.Location = new System.Drawing.Point(36, 742);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(1363, 81);
            this.pButtons.TabIndex = 169;
            this.pButtons.Paint += new System.Windows.Forms.PaintEventHandler(this.pButtons_Paint);
            // 
            // pInfoExtra
            // 
            this.pInfoExtra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pInfoExtra.Controls.Add(this.label15);
            this.pInfoExtra.Controls.Add(this.txtMedida);
            this.pInfoExtra.Controls.Add(this.label14);
            this.pInfoExtra.Controls.Add(this.label13);
            this.pInfoExtra.Controls.Add(this.txtM3);
            this.pInfoExtra.Controls.Add(this.label12);
            this.pInfoExtra.Controls.Add(this.txtPrecoUnidade);
            this.pInfoExtra.Controls.Add(this.label11);
            this.pInfoExtra.Controls.Add(this.txtQtdEmbalagem);
            this.pInfoExtra.Controls.Add(this.label10);
            this.pInfoExtra.Controls.Add(this.txtTipoEmbalagem);
            this.pInfoExtra.Location = new System.Drawing.Point(933, 172);
            this.pInfoExtra.Name = "pInfoExtra";
            this.pInfoExtra.Size = new System.Drawing.Size(466, 484);
            this.pInfoExtra.TabIndex = 170;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.2F);
            this.label14.Location = new System.Drawing.Point(30, 54);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(335, 33);
            this.label14.TabIndex = 171;
            this.label14.Text = "INFORMAÇÕES EXTRA";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(184, 254);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 14);
            this.label13.TabIndex = 162;
            this.label13.Text = "Métro Cúbico";
            // 
            // txtM3
            // 
            this.txtM3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtM3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtM3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtM3.Font = new System.Drawing.Font("Arial", 16F);
            this.txtM3.ForeColor = System.Drawing.Color.Black;
            this.txtM3.Location = new System.Drawing.Point(182, 272);
            this.txtM3.Margin = new System.Windows.Forms.Padding(4);
            this.txtM3.MaxLength = 150;
            this.txtM3.Name = "txtM3";
            this.txtM3.Size = new System.Drawing.Size(103, 38);
            this.txtM3.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(35, 254);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 14);
            this.label12.TabIndex = 160;
            this.label12.Text = "Preço Unidade";
            // 
            // txtPrecoUnidade
            // 
            this.txtPrecoUnidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecoUnidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPrecoUnidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecoUnidade.Font = new System.Drawing.Font("Arial", 16F);
            this.txtPrecoUnidade.ForeColor = System.Drawing.Color.Black;
            this.txtPrecoUnidade.Location = new System.Drawing.Point(33, 272);
            this.txtPrecoUnidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecoUnidade.MaxLength = 150;
            this.txtPrecoUnidade.Name = "txtPrecoUnidade";
            this.txtPrecoUnidade.Size = new System.Drawing.Size(130, 38);
            this.txtPrecoUnidade.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(314, 162);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 14);
            this.label11.TabIndex = 158;
            this.label11.Text = "Qtd na Embalagem";
            // 
            // txtQtdEmbalagem
            // 
            this.txtQtdEmbalagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQtdEmbalagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtQtdEmbalagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtdEmbalagem.Font = new System.Drawing.Font("Arial", 16F);
            this.txtQtdEmbalagem.ForeColor = System.Drawing.Color.Black;
            this.txtQtdEmbalagem.Location = new System.Drawing.Point(312, 180);
            this.txtQtdEmbalagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtQtdEmbalagem.MaxLength = 150;
            this.txtQtdEmbalagem.Name = "txtQtdEmbalagem";
            this.txtQtdEmbalagem.Size = new System.Drawing.Size(130, 38);
            this.txtQtdEmbalagem.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(30, 162);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 14);
            this.label10.TabIndex = 156;
            this.label10.Text = "Tipo de Embalagem";
            // 
            // txtTipoEmbalagem
            // 
            this.txtTipoEmbalagem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTipoEmbalagem.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTipoEmbalagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTipoEmbalagem.Font = new System.Drawing.Font("Arial", 16F);
            this.txtTipoEmbalagem.ForeColor = System.Drawing.Color.Black;
            this.txtTipoEmbalagem.Location = new System.Drawing.Point(30, 180);
            this.txtTipoEmbalagem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoEmbalagem.MaxLength = 150;
            this.txtTipoEmbalagem.Name = "txtTipoEmbalagem";
            this.txtTipoEmbalagem.Size = new System.Drawing.Size(255, 38);
            this.txtTipoEmbalagem.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 6.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(32, 337);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 14);
            this.label15.TabIndex = 173;
            this.label15.Text = "Medida";
            // 
            // txtMedida
            // 
            this.txtMedida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMedida.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMedida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMedida.Font = new System.Drawing.Font("Arial", 16F);
            this.txtMedida.ForeColor = System.Drawing.Color.Black;
            this.txtMedida.Location = new System.Drawing.Point(30, 355);
            this.txtMedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedida.MaxLength = 150;
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(103, 38);
            this.txtMedida.TabIndex = 172;
            // 
            // FormCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1436, 835);
            this.Controls.Add(this.pInfoExtra);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pProduct);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroProduto";
            this.Load += new System.EventHandler(this.FormCadastroProduto_Load);
            this.pProduct.ResumeLayout(false);
            this.pProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoProduto)).EndInit();
            this.pButtons.ResumeLayout(false);
            this.pInfoExtra.ResumeLayout(false);
            this.pInfoExtra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNovoCadastro;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel pProduct;
        public System.Windows.Forms.TextBox txtPrecoPromocional;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtId;
        public System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.PictureBox btnAddCategoria;
        private System.Windows.Forms.PictureBox fotoProduto;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtPrecoVenda;
        public System.Windows.Forms.TextBox txtPrecoCusto;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtEmbalagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Panel pInfoExtra;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtM3;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txtPrecoUnidade;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtQtdEmbalagem;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtTipoEmbalagem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox txtMedida;
    }
}