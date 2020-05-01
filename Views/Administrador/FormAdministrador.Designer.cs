namespace Views.Administrador
{
    partial class FormAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrador));
            this.painelContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnNotification = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblBomDia = new System.Windows.Forms.Label();
            this.panelCalendario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.painelDinheiro = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVendaDinheiro = new System.Windows.Forms.Label();
            this.lblVendaFiado = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalVendas = new System.Windows.Forms.Label();
            this.calendario = new Pabo.Calendar.MonthCalendar();
            this.label12 = new System.Windows.Forms.Label();
            this.lblVendaDebito = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVendasCredito = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCadastroProduto = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.painelContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.panelCalendario.SuspendLayout();
            this.painelDinheiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelContainer
            // 
            this.painelContainer.BackColor = System.Drawing.Color.White;
            this.painelContainer.Controls.Add(this.bunifuThinButton22);
            this.painelContainer.Controls.Add(this.bunifuThinButton21);
            this.painelContainer.Controls.Add(this.btnCadastroProduto);
            this.painelContainer.Controls.Add(this.panelCalendario);
            this.painelContainer.Controls.Add(this.lblBomDia);
            this.painelContainer.Controls.Add(this.lblLogin);
            this.painelContainer.Controls.Add(this.panel1);
            this.painelContainer.Controls.Add(this.pHeader);
            this.painelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelContainer.Location = new System.Drawing.Point(0, 0);
            this.painelContainer.Name = "painelContainer";
            this.painelContainer.Size = new System.Drawing.Size(1487, 897);
            this.painelContainer.TabIndex = 0;
            this.painelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.painelContainer_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 843);
            this.panel1.TabIndex = 0;
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.White;
            this.pHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHeader.Controls.Add(this.btnNotification);
            this.pHeader.Controls.Add(this.btnConfig);
            this.pHeader.Controls.Add(this.imageLogo);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1487, 54);
            this.pHeader.TabIndex = 1;
            // 
            // btnNotification
            // 
            this.btnNotification.Image = global::Views.Properties.Resources.Asset_1sino;
            this.btnNotification.Location = new System.Drawing.Point(1332, 17);
            this.btnNotification.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotification.Name = "btnNotification";
            this.btnNotification.Size = new System.Drawing.Size(27, 25);
            this.btnNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNotification.TabIndex = 7;
            this.btnNotification.TabStop = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Image = global::Views.Properties.Resources.Asset_11;
            this.btnConfig.Location = new System.Drawing.Point(1297, 17);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(27, 25);
            this.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfig.TabIndex = 5;
            this.btnConfig.TabStop = false;
            // 
            // imageLogo
            // 
            this.imageLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageLogo.Image = global::Views.Properties.Resources.Asset_1;
            this.imageLogo.Location = new System.Drawing.Point(0, 0);
            this.imageLogo.Margin = new System.Windows.Forms.Padding(4);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(259, 52);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(250, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 843);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.lblLogin.Location = new System.Drawing.Point(384, 102);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(322, 25);
            this.lblLogin.TabIndex = 141;
            this.lblLogin.Text = "Kleiton Eduardo da Silva Freitas";
            // 
            // lblBomDia
            // 
            this.lblBomDia.AutoSize = true;
            this.lblBomDia.BackColor = System.Drawing.Color.Transparent;
            this.lblBomDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.lblBomDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.lblBomDia.Location = new System.Drawing.Point(302, 102);
            this.lblBomDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBomDia.Name = "lblBomDia";
            this.lblBomDia.Size = new System.Drawing.Size(89, 24);
            this.lblBomDia.TabIndex = 145;
            this.lblBomDia.Text = "Bom dia, ";
            this.lblBomDia.Visible = false;
            // 
            // panelCalendario
            // 
            this.panelCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelCalendario.Controls.Add(this.label2);
            this.panelCalendario.Controls.Add(this.painelDinheiro);
            this.panelCalendario.Controls.Add(this.lblVendaFiado);
            this.panelCalendario.Controls.Add(this.label7);
            this.panelCalendario.Controls.Add(this.lblTotalVendas);
            this.panelCalendario.Controls.Add(this.calendario);
            this.panelCalendario.Controls.Add(this.label12);
            this.panelCalendario.Controls.Add(this.lblVendaDebito);
            this.panelCalendario.Controls.Add(this.label4);
            this.panelCalendario.Controls.Add(this.lblVendasCredito);
            this.panelCalendario.Controls.Add(this.label10);
            this.panelCalendario.Controls.Add(this.bunifuSeparator2);
            this.panelCalendario.Controls.Add(this.label3);
            this.panelCalendario.Location = new System.Drawing.Point(1112, 164);
            this.panelCalendario.Name = "panelCalendario";
            this.panelCalendario.Size = new System.Drawing.Size(350, 715);
            this.panelCalendario.TabIndex = 146;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(4, 405);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 150;
            this.label2.Text = "Resumo de Vendas ";
            // 
            // painelDinheiro
            // 
            this.painelDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDinheiro.Controls.Add(this.label6);
            this.painelDinheiro.Controls.Add(this.lblVendaDinheiro);
            this.painelDinheiro.Location = new System.Drawing.Point(8, 472);
            this.painelDinheiro.Name = "painelDinheiro";
            this.painelDinheiro.Size = new System.Drawing.Size(321, 51);
            this.painelDinheiro.TabIndex = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 155;
            this.label6.Text = "Venda no Dinheiro:";
            // 
            // lblVendaDinheiro
            // 
            this.lblVendaDinheiro.AutoSize = true;
            this.lblVendaDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaDinheiro.Location = new System.Drawing.Point(147, 16);
            this.lblVendaDinheiro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaDinheiro.Name = "lblVendaDinheiro";
            this.lblVendaDinheiro.Size = new System.Drawing.Size(40, 18);
            this.lblVendaDinheiro.TabIndex = 154;
            this.lblVendaDinheiro.Text = "0.00";
            // 
            // lblVendaFiado
            // 
            this.lblVendaFiado.AutoSize = true;
            this.lblVendaFiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaFiado.Location = new System.Drawing.Point(155, 627);
            this.lblVendaFiado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaFiado.Name = "lblVendaFiado";
            this.lblVendaFiado.Size = new System.Drawing.Size(40, 18);
            this.lblVendaFiado.TabIndex = 162;
            this.lblVendaFiado.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(17, 628);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 163;
            this.label7.Text = "Conta:";
            // 
            // lblTotalVendas
            // 
            this.lblTotalVendas.AutoSize = true;
            this.lblTotalVendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalVendas.Location = new System.Drawing.Point(155, 672);
            this.lblTotalVendas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalVendas.Name = "lblTotalVendas";
            this.lblTotalVendas.Size = new System.Drawing.Size(40, 18);
            this.lblTotalVendas.TabIndex = 160;
            this.lblTotalVendas.Text = "0.00";
            // 
            // calendario
            // 
            this.calendario.ActiveMonth.Month = 4;
            this.calendario.ActiveMonth.Year = 2020;
            this.calendario.BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.calendario.Culture = new System.Globalization.CultureInfo("pt-BR");
            this.calendario.Footer.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Footer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.calendario.Footer.Format = Pabo.Calendar.mcTodayFormat.Long;
            this.calendario.Footer.ShowToday = false;
            this.calendario.Footer.Text = "Vendas do dia 21";
            this.calendario.Header.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Header.BackColor2 = System.Drawing.Color.Black;
            this.calendario.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendario.ImageList = null;
            this.calendario.Location = new System.Drawing.Point(8, 61);
            this.calendario.MaxDate = new System.DateTime(2030, 4, 20, 21, 3, 2, 326);
            this.calendario.MinDate = new System.DateTime(2010, 4, 20, 21, 3, 2, 326);
            this.calendario.Month.BackgroundImage = null;
            this.calendario.Month.BorderStyles.Focus = System.Windows.Forms.ButtonBorderStyle.None;
            this.calendario.Month.BorderStyles.Selected = System.Windows.Forms.ButtonBorderStyle.None;
            this.calendario.Month.Colors.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.Colors.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.Colors.Days.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.Colors.Days.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.Colors.Days.Border = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Month.DateFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Month.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Name = "calendario";
            this.calendario.SelectTrailingDates = false;
            this.calendario.ShowTrailingDates = false;
            this.calendario.Size = new System.Drawing.Size(333, 255);
            this.calendario.TabIndex = 150;
            this.calendario.TodayColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.calendario.Weekdays.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.calendario.Weekdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.calendario.Weekdays.TextColor = System.Drawing.Color.Black;
            this.calendario.Weeknumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(17, 673);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 161;
            this.label12.Text = "Total de Vendas:";
            // 
            // lblVendaDebito
            // 
            this.lblVendaDebito.AutoSize = true;
            this.lblVendaDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaDebito.Location = new System.Drawing.Point(155, 572);
            this.lblVendaDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaDebito.Name = "lblVendaDebito";
            this.lblVendaDebito.Size = new System.Drawing.Size(40, 18);
            this.lblVendaDebito.TabIndex = 152;
            this.lblVendaDebito.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(17, 573);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 153;
            this.label4.Text = "Venda no Débito:";
            // 
            // lblVendasCredito
            // 
            this.lblVendasCredito.AutoSize = true;
            this.lblVendasCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendasCredito.Location = new System.Drawing.Point(154, 602);
            this.lblVendasCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendasCredito.Name = "lblVendasCredito";
            this.lblVendasCredito.Size = new System.Drawing.Size(40, 18);
            this.lblVendasCredito.TabIndex = 150;
            this.lblVendasCredito.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(16, 603);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 17);
            this.label10.TabIndex = 151;
            this.label10.Text = "Venda no Crédito:";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(8, 40);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(333, 14);
            this.bunifuSeparator2.TabIndex = 148;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 26);
            this.label3.TabIndex = 145;
            this.label3.Text = "Vendas do Dia";
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.ActiveBorderThickness = 1;
            this.btnCadastroProduto.ActiveCornerRadius = 20;
            this.btnCadastroProduto.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnCadastroProduto.ActiveForecolor = System.Drawing.Color.White;
            this.btnCadastroProduto.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnCadastroProduto.BackColor = System.Drawing.Color.White;
            this.btnCadastroProduto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastroProduto.BackgroundImage")));
            this.btnCadastroProduto.ButtonText = "+ Cadastro Produto";
            this.btnCadastroProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastroProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadastroProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnCadastroProduto.IdleBorderThickness = 1;
            this.btnCadastroProduto.IdleCornerRadius = 5;
            this.btnCadastroProduto.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroProduto.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.btnCadastroProduto.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroProduto.Location = new System.Drawing.Point(306, 164);
            this.btnCadastroProduto.Margin = new System.Windows.Forms.Padding(5);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(239, 112);
            this.btnCadastroProduto.TabIndex = 150;
            this.btnCadastroProduto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "+ Cadastro Vendedor";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 5;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton21.Location = new System.Drawing.Point(580, 164);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(239, 112);
            this.bunifuThinButton21.TabIndex = 151;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.bunifuThinButton22.BackColor = System.Drawing.Color.White;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "+ Cadastro Clientes";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 5;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137)))));
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuThinButton22.Location = new System.Drawing.Point(845, 164);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(239, 112);
            this.bunifuThinButton22.TabIndex = 152;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 897);
            this.Controls.Add(this.painelContainer);
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painelContainer.ResumeLayout(false);
            this.painelContainer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.panelCalendario.ResumeLayout(false);
            this.panelCalendario.PerformLayout();
            this.painelDinheiro.ResumeLayout(false);
            this.painelDinheiro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelContainer;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.PictureBox btnNotification;
        private System.Windows.Forms.PictureBox btnConfig;
        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblBomDia;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCadastroProduto;
        private System.Windows.Forms.Panel panelCalendario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel painelDinheiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVendaDinheiro;
        private System.Windows.Forms.Label lblVendaFiado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalVendas;
        private Pabo.Calendar.MonthCalendar calendario;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVendaDebito;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVendasCredito;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}