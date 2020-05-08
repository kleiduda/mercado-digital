namespace Views.Produtos
{
    partial class FormProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProdutos));
            this.lblState = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabLista = new System.Windows.Forms.TabPage();
            this.dgvProdutos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnNovo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCadastro = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNovoCadastro = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pProduct = new System.Windows.Forms.Panel();
            this.txtIdProduto = new System.Windows.Forms.TextBox();
            this.txtEAN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.fotoProduto = new System.Windows.Forms.PictureBox();
            this.lblSuc = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtPrecoPromocional = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmbalagem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabCadastro.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblState
            // 
            this.lblState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblState.AutoSize = true;
            this.lblState.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.Gray;
            this.lblState.Location = new System.Drawing.Point(234, 434);
            this.lblState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(41, 24);
            this.lblState.TabIndex = 159;
            this.lblState.Text = "lista";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 388);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 44);
            this.label9.TabIndex = 160;
            this.label9.Text = "#PRODUTOS";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabLista);
            this.tabControl1.Controls.Add(this.tabCadastro);
            this.tabControl1.ItemSize = new System.Drawing.Size(24, 30);
            this.tabControl1.Location = new System.Drawing.Point(109, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1311, 715);
            this.tabControl1.TabIndex = 161;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1303, 677);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Vendedores";
            // 
            // tabLista
            // 
            this.tabLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabLista.Controls.Add(this.dgvProdutos);
            this.tabLista.Controls.Add(this.panel2);
            this.tabLista.Location = new System.Drawing.Point(4, 34);
            this.tabLista.Name = "tabLista";
            this.tabLista.Padding = new System.Windows.Forms.Padding(3);
            this.tabLista.Size = new System.Drawing.Size(1303, 677);
            this.tabLista.TabIndex = 0;
            this.tabLista.Text = "Lista de Produtos";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvProdutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProdutos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProdutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProdutos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProdutos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProdutos.DoubleBuffered = true;
            this.dgvProdutos.EnableHeadersVisualStyles = false;
            this.dgvProdutos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProdutos.HeaderBgColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProdutos.HeaderForeColor = System.Drawing.Color.Black;
            this.dgvProdutos.Location = new System.Drawing.Point(266, 95);
            this.dgvProdutos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(186)))), ((int)(((byte)(167)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowHeadersWidth = 62;
            this.dgvProdutos.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvProdutos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dgvProdutos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProdutos.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 5);
            this.dgvProdutos.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvProdutos.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvProdutos.RowTemplate.Height = 40;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(1022, 565);
            this.dgvProdutos.TabIndex = 167;
            this.dgvProdutos.DoubleClick += new System.EventHandler(this.dgvProdutos_DoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(9, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 104);
            this.panel2.TabIndex = 155;
            // 
            // btnNovo
            // 
            this.btnNovo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovo.BorderRadius = 0;
            this.btnNovo.ButtonText = "Novo Cadastro";
            this.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovo.DisabledColor = System.Drawing.Color.Gray;
            this.btnNovo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovo.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNovo.Iconimage = global::Views.Properties.Resources.add__lista;
            this.btnNovo.Iconimage_right = null;
            this.btnNovo.Iconimage_right_Selected = null;
            this.btnNovo.Iconimage_Selected = null;
            this.btnNovo.IconMarginLeft = 0;
            this.btnNovo.IconMarginRight = 0;
            this.btnNovo.IconRightVisible = false;
            this.btnNovo.IconRightZoom = 0D;
            this.btnNovo.IconVisible = false;
            this.btnNovo.IconZoom = 30D;
            this.btnNovo.IsTab = false;
            this.btnNovo.Location = new System.Drawing.Point(0, 47);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNovo.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnNovo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnNovo.selected = false;
            this.btnNovo.Size = new System.Drawing.Size(192, 44);
            this.btnNovo.TabIndex = 180;
            this.btnNovo.Text = "Novo Cadastro";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Textcolor = System.Drawing.Color.Gray;
            this.btnNovo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(192, 10);
            this.panel4.TabIndex = 175;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(192, 37);
            this.panel3.TabIndex = 174;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Views.Properties.Resources.arrow_top;
            this.pictureBox1.Location = new System.Drawing.Point(149, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabCadastro
            // 
            this.tabCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.tabCadastro.Controls.Add(this.pProduct);
            this.tabCadastro.Controls.Add(this.panel1);
            this.tabCadastro.Location = new System.Drawing.Point(4, 34);
            this.tabCadastro.Name = "tabCadastro";
            this.tabCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCadastro.Size = new System.Drawing.Size(1303, 677);
            this.tabCadastro.TabIndex = 2;
            this.tabCadastro.Text = "Cadastro de Produtos";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnNovoCadastro);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(9, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 317);
            this.panel1.TabIndex = 156;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.BorderRadius = 0;
            this.btnCancelar.ButtonText = "+ Cancelar";
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.DisabledColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelar.Iconimage = global::Views.Properties.Resources.cancel;
            this.btnCancelar.Iconimage_right = null;
            this.btnCancelar.Iconimage_right_Selected = null;
            this.btnCancelar.Iconimage_Selected = null;
            this.btnCancelar.IconMarginLeft = 0;
            this.btnCancelar.IconMarginRight = 0;
            this.btnCancelar.IconRightVisible = false;
            this.btnCancelar.IconRightZoom = 0D;
            this.btnCancelar.IconVisible = false;
            this.btnCancelar.IconZoom = 30D;
            this.btnCancelar.IsTab = false;
            this.btnCancelar.Location = new System.Drawing.Point(0, 149);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnCancelar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnCancelar.selected = false;
            this.btnCancelar.Size = new System.Drawing.Size(192, 44);
            this.btnCancelar.TabIndex = 178;
            this.btnCancelar.Text = "+ Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Textcolor = System.Drawing.Color.Gray;
            this.btnCancelar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovoCadastro
            // 
            this.btnNovoCadastro.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNovoCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNovoCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNovoCadastro.BorderRadius = 0;
            this.btnNovoCadastro.ButtonText = " + Novo Cadastro";
            this.btnNovoCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNovoCadastro.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnNovoCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovoCadastro.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNovoCadastro.Iconimage = global::Views.Properties.Resources.Asset_1add;
            this.btnNovoCadastro.Iconimage_right = null;
            this.btnNovoCadastro.Iconimage_right_Selected = null;
            this.btnNovoCadastro.Iconimage_Selected = null;
            this.btnNovoCadastro.IconMarginLeft = 0;
            this.btnNovoCadastro.IconMarginRight = 0;
            this.btnNovoCadastro.IconRightVisible = false;
            this.btnNovoCadastro.IconRightZoom = 0D;
            this.btnNovoCadastro.IconVisible = false;
            this.btnNovoCadastro.IconZoom = 30D;
            this.btnNovoCadastro.IsTab = false;
            this.btnNovoCadastro.Location = new System.Drawing.Point(0, 47);
            this.btnNovoCadastro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovoCadastro.Name = "btnNovoCadastro";
            this.btnNovoCadastro.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnNovoCadastro.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnNovoCadastro.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnNovoCadastro.selected = false;
            this.btnNovoCadastro.Size = new System.Drawing.Size(192, 44);
            this.btnNovoCadastro.TabIndex = 180;
            this.btnNovoCadastro.Text = " + Novo Cadastro";
            this.btnNovoCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovoCadastro.Textcolor = System.Drawing.Color.Gray;
            this.btnNovoCadastro.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoCadastro.Click += new System.EventHandler(this.btnNovoCadastro_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.BorderRadius = 0;
            this.btnEditar.ButtonText = "+ Editar";
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEditar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditar.Iconimage = global::Views.Properties.Resources.edit;
            this.btnEditar.Iconimage_right = null;
            this.btnEditar.Iconimage_right_Selected = null;
            this.btnEditar.Iconimage_Selected = null;
            this.btnEditar.IconMarginLeft = 0;
            this.btnEditar.IconMarginRight = 0;
            this.btnEditar.IconRightVisible = false;
            this.btnEditar.IconRightZoom = 0D;
            this.btnEditar.IconVisible = false;
            this.btnEditar.IconZoom = 30D;
            this.btnEditar.IsTab = false;
            this.btnEditar.Location = new System.Drawing.Point(0, 193);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnEditar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnEditar.selected = false;
            this.btnEditar.Size = new System.Drawing.Size(192, 44);
            this.btnEditar.TabIndex = 179;
            this.btnEditar.Text = "+ Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Textcolor = System.Drawing.Color.Gray;
            this.btnEditar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 237);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(192, 36);
            this.bunifuSeparator2.TabIndex = 156;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(192, 10);
            this.panel5.TabIndex = 175;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(192, 37);
            this.panel6.TabIndex = 174;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Views.Properties.Resources.arrow_top;
            this.pictureBox2.Location = new System.Drawing.Point(121, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.BorderRadius = 0;
            this.btnSalvar.ButtonText = "+ SALVAR";
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalvar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalvar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalvar.Iconimage = global::Views.Properties.Resources.save;
            this.btnSalvar.Iconimage_right = null;
            this.btnSalvar.Iconimage_right_Selected = null;
            this.btnSalvar.Iconimage_Selected = null;
            this.btnSalvar.IconMarginLeft = 0;
            this.btnSalvar.IconMarginRight = 0;
            this.btnSalvar.IconRightVisible = false;
            this.btnSalvar.IconRightZoom = 0D;
            this.btnSalvar.IconVisible = false;
            this.btnSalvar.IconZoom = 30D;
            this.btnSalvar.IsTab = false;
            this.btnSalvar.Location = new System.Drawing.Point(0, 273);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSalvar.OnHovercolor = System.Drawing.Color.WhiteSmoke;
            this.btnSalvar.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnSalvar.selected = false;
            this.btnSalvar.Size = new System.Drawing.Size(192, 44);
            this.btnSalvar.TabIndex = 176;
            this.btnSalvar.Text = "+ SALVAR";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Textcolor = System.Drawing.Color.Gray;
            this.btnSalvar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pProduct
            // 
            this.pProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pProduct.Controls.Add(this.txtIdProduto);
            this.pProduct.Controls.Add(this.txtEAN);
            this.pProduct.Controls.Add(this.label6);
            this.pProduct.Controls.Add(this.label5);
            this.pProduct.Controls.Add(this.txtCodigo);
            this.pProduct.Controls.Add(this.cbCategoria);
            this.pProduct.Controls.Add(this.pictureBox3);
            this.pProduct.Controls.Add(this.fotoProduto);
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
            this.pProduct.Location = new System.Drawing.Point(319, 96);
            this.pProduct.Margin = new System.Windows.Forms.Padding(4);
            this.pProduct.Name = "pProduct";
            this.pProduct.Size = new System.Drawing.Size(867, 484);
            this.pProduct.TabIndex = 157;
            // 
            // txtIdProduto
            // 
            this.txtIdProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtIdProduto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdProduto.Font = new System.Drawing.Font("Arial", 16F);
            this.txtIdProduto.ForeColor = System.Drawing.Color.Black;
            this.txtIdProduto.Location = new System.Drawing.Point(692, 401);
            this.txtIdProduto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProduto.MaxLength = 150;
            this.txtIdProduto.Name = "txtIdProduto";
            this.txtIdProduto.Size = new System.Drawing.Size(98, 38);
            this.txtIdProduto.TabIndex = 152;
            this.txtIdProduto.Visible = false;
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
            this.txtCodigo.TabIndex = 123;
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
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::Views.Properties.Resources.plus;
            this.pictureBox3.Location = new System.Drawing.Point(797, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 144;
            this.pictureBox3.TabStop = false;
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
            this.txtDescricao.TabIndex = 141;
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
            // txtPreco
            // 
            this.txtPreco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPreco.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPreco.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPreco.ForeColor = System.Drawing.Color.Black;
            this.txtPreco.Location = new System.Drawing.Point(37, 355);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreco.MaxLength = 150;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(180, 30);
            this.txtPreco.TabIndex = 127;
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
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1436, 835);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProdutos";
            this.Text = "FormNovoProduto";
            this.Load += new System.EventHandler(this.FormNovoProduto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabCadastro.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pProduct.ResumeLayout(false);
            this.pProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabLista;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvProdutos;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnNovo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabCadastro;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelar;
        private Bunifu.Framework.UI.BunifuFlatButton btnNovoCadastro;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalvar;
        private System.Windows.Forms.Panel pProduct;
        public System.Windows.Forms.TextBox txtIdProduto;
        public System.Windows.Forms.TextBox txtEAN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox fotoProduto;
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
    }
}