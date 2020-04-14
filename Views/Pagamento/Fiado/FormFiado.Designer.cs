namespace Views.Pagamento
{
    partial class FormFiado
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
            this.btnConfirma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.lblSaldoAtual = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linha = new Bunifu.Framework.UI.BunifuSeparator();
            this.label16 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSaldoAnterior = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblSuc = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.Color.White;
            this.btnConfirma.Location = new System.Drawing.Point(34, 560);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(417, 57);
            this.btnConfirma.TabIndex = 157;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(35, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 154;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 39);
            this.label2.TabIndex = 152;
            this.label2.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 30.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTotal.Location = new System.Drawing.Point(22, 181);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 72);
            this.lblTotal.TabIndex = 153;
            this.lblTotal.Text = "0,00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 29);
            this.label1.TabIndex = 151;
            this.label1.Text = "ADICIONAR A CONTA DO CLIENTE";
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCpf.BackColor = System.Drawing.Color.White;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Arial", 30F);
            this.txtCpf.ForeColor = System.Drawing.Color.Black;
            this.txtCpf.Location = new System.Drawing.Point(41, 310);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.MaxLength = 150;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(418, 65);
            this.txtCpf.TabIndex = 150;
            // 
            // lblSaldoAtual
            // 
            this.lblSaldoAtual.AutoSize = true;
            this.lblSaldoAtual.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoAtual.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold);
            this.lblSaldoAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSaldoAtual.Location = new System.Drawing.Point(277, 424);
            this.lblSaldoAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoAtual.Name = "lblSaldoAtual";
            this.lblSaldoAtual.Size = new System.Drawing.Size(123, 59);
            this.lblSaldoAtual.TabIndex = 156;
            this.lblSaldoAtual.Text = "0,00";
            this.lblSaldoAtual.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.linha);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lblSaldoAnterior);
            this.panel1.Controls.Add(this.lblSaldoAtual);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.lblFone);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.lblCEP);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblBairro);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lblCidade);
            this.panel1.Controls.Add(this.lbl);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblCPF);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblMatricula);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Location = new System.Drawing.Point(466, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 579);
            this.panel1.TabIndex = 158;
            // 
            // linha
            // 
            this.linha.BackColor = System.Drawing.Color.Transparent;
            this.linha.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.linha.LineThickness = 1;
            this.linha.Location = new System.Drawing.Point(16, 388);
            this.linha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linha.Name = "linha";
            this.linha.Size = new System.Drawing.Size(484, 10);
            this.linha.TabIndex = 180;
            this.linha.Transparency = 255;
            this.linha.Vertical = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label16.Location = new System.Drawing.Point(285, 405);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(193, 29);
            this.label16.TabIndex = 179;
            this.label16.Text = "Saldo Atualizado";
            this.label16.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label9.Location = new System.Drawing.Point(32, 412);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 177;
            this.label9.Text = "Saldo Anterior";
            this.label9.Visible = false;
            // 
            // lblSaldoAnterior
            // 
            this.lblSaldoAnterior.AutoSize = true;
            this.lblSaldoAnterior.BackColor = System.Drawing.Color.Transparent;
            this.lblSaldoAnterior.Font = new System.Drawing.Font("Arial Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblSaldoAnterior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblSaldoAnterior.Location = new System.Drawing.Point(32, 424);
            this.lblSaldoAnterior.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldoAnterior.Name = "lblSaldoAnterior";
            this.lblSaldoAnterior.Size = new System.Drawing.Size(100, 48);
            this.lblSaldoAnterior.TabIndex = 178;
            this.lblSaldoAnterior.Text = "0,00";
            this.lblSaldoAnterior.Visible = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(115, 170);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(109, 12);
            this.lblEmail.TabIndex = 174;
            this.lblEmail.Text = "kleiduda@gmail.com";
            this.lblEmail.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(36, 167);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 17);
            this.label14.TabIndex = 175;
            this.label14.Text = "E-mail";
            this.label14.Visible = false;
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblFone.Location = new System.Drawing.Point(114, 139);
            this.lblFone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(118, 18);
            this.lblFone.TabIndex = 172;
            this.lblFone.Text = "11 94455-6923";
            this.lblFone.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(35, 140);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 173;
            this.label13.Text = "Telefone";
            this.label13.Visible = false;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCEP.Location = new System.Drawing.Point(115, 278);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(86, 18);
            this.lblCEP.TabIndex = 170;
            this.lblCEP.Text = "04459-110";
            this.lblCEP.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(36, 279);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 171;
            this.label12.Text = "CEP:";
            this.label12.Visible = false;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblBairro.Location = new System.Drawing.Point(115, 251);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(71, 18);
            this.lblBairro.TabIndex = 168;
            this.lblBairro.Text = "Pedreira";
            this.lblBairro.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(36, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 169;
            this.label11.Text = "Bairro:";
            this.label11.Visible = false;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCidade.Location = new System.Drawing.Point(115, 223);
            this.lblCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(86, 18);
            this.lblCidade.TabIndex = 166;
            this.lblCidade.Text = "São Paulo";
            this.lblCidade.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl.Location = new System.Drawing.Point(36, 224);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(56, 17);
            this.lbl.TabIndex = 167;
            this.lbl.Text = "Cidade:";
            this.lbl.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstado.Location = new System.Drawing.Point(115, 194);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(86, 18);
            this.lblEstado.TabIndex = 164;
            this.lblEstado.Text = "São Paulo";
            this.lblEstado.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(36, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 17);
            this.label8.TabIndex = 165;
            this.label8.Text = "Estado:";
            this.label8.Visible = false;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblCPF.Location = new System.Drawing.Point(114, 114);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(107, 18);
            this.lblCPF.TabIndex = 162;
            this.lblCPF.Text = "32414576804";
            this.lblCPF.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(35, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 163;
            this.label7.Text = "Cpf:";
            this.label7.Visible = false;
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMatricula.Location = new System.Drawing.Point(106, 48);
            this.lblMatricula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(26, 18);
            this.lblMatricula.TabIndex = 160;
            this.lblMatricula.Text = "01";
            this.lblMatricula.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(35, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 17);
            this.label10.TabIndex = 161;
            this.label10.Text = "Matrícula:";
            this.label10.Visible = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblNome.Location = new System.Drawing.Point(31, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(386, 25);
            this.lblNome.TabIndex = 159;
            this.lblNome.Text = "KLEITON EDUARDO DA SILVA FREITAS";
            this.lblNome.Visible = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.White;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnCadastro.ForeColor = System.Drawing.Color.Black;
            this.btnCadastro.Location = new System.Drawing.Point(245, 383);
            this.btnCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(214, 31);
            this.btnCadastro.TabIndex = 159;
            this.btnCadastro.Text = "+ Cadastrar Cliente";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.btnConsultar.ForeColor = System.Drawing.Color.Black;
            this.btnConsultar.Location = new System.Drawing.Point(41, 383);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(113, 31);
            this.btnConsultar.TabIndex = 160;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblSuc
            // 
            this.lblSuc.AutoSize = true;
            this.lblSuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.lblSuc.Image = global::Views.Properties.Resources.sucesso;
            this.lblSuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuc.Location = new System.Drawing.Point(51, 451);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(234, 20);
            this.lblSuc.TabIndex = 162;
            this.lblSuc.Text = "         erro ao fazer o login";
            this.lblSuc.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Image = global::Views.Properties.Resources.report_min;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(51, 451);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(234, 20);
            this.lblError.TabIndex = 161;
            this.lblError.Text = "         erro ao fazer o login";
            this.lblError.Visible = false;
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtIdPedido.BackColor = System.Drawing.Color.White;
            this.txtIdPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdPedido.Font = new System.Drawing.Font("Arial", 10F);
            this.txtIdPedido.ForeColor = System.Drawing.Color.Black;
            this.txtIdPedido.Location = new System.Drawing.Point(33, 100);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdPedido.MaxLength = 150;
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.Size = new System.Drawing.Size(57, 27);
            this.txtIdPedido.TabIndex = 163;
            // 
            // FormFiado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(997, 655);
            this.Controls.Add(this.txtIdPedido);
            this.Controls.Add(this.lblSuc);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFiado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFiado";
            this.Load += new System.EventHandler(this.FormFiado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label lblSaldoAtual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSaldoAnterior;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Label lblError;
        private Bunifu.Framework.UI.BunifuSeparator linha;
        public System.Windows.Forms.TextBox txtIdPedido;
    }
}