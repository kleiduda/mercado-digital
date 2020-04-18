namespace Views
{
    partial class FormDashBoardAtendente
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
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnNotification = new System.Windows.Forms.PictureBox();
            this.btnConfig = new System.Windows.Forms.PictureBox();
            this.imageLogo = new System.Windows.Forms.PictureBox();
            this.container = new System.Windows.Forms.Panel();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.painelAbrirCaixa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuarioHeaderT = new System.Windows.Forms.Label();
            this.lblUsuarioHeader = new System.Windows.Forms.Label();
            this.imageUsuario = new System.Windows.Forms.PictureBox();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).BeginInit();
            this.container.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.painelAbrirCaixa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.White;
            this.pHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pHeader.Controls.Add(this.imageUsuario);
            this.pHeader.Controls.Add(this.lblUsuarioHeader);
            this.pHeader.Controls.Add(this.lblUsuarioHeaderT);
            this.pHeader.Controls.Add(this.btnNotification);
            this.pHeader.Controls.Add(this.btnConfig);
            this.pHeader.Controls.Add(this.imageLogo);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1333, 54);
            this.pHeader.TabIndex = 0;
            // 
            // btnNotification
            // 
            this.btnNotification.Image = global::Views.Properties.Resources.Asset_1sino;
            this.btnNotification.Location = new System.Drawing.Point(938, 13);
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
            this.btnConfig.Location = new System.Drawing.Point(903, 13);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(27, 25);
            this.btnConfig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConfig.TabIndex = 5;
            this.btnConfig.TabStop = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // imageLogo
            // 
            this.imageLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageLogo.Image = global::Views.Properties.Resources.Asset_1;
            this.imageLogo.Location = new System.Drawing.Point(0, 0);
            this.imageLogo.Margin = new System.Windows.Forms.Padding(4);
            this.imageLogo.Name = "imageLogo";
            this.imageLogo.Size = new System.Drawing.Size(152, 52);
            this.imageLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageLogo.TabIndex = 0;
            this.imageLogo.TabStop = false;
            // 
            // container
            // 
            this.container.Controls.Add(this.panelWelcome);
            this.container.Controls.Add(this.painelAbrirCaixa);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 54);
            this.container.Margin = new System.Windows.Forms.Padding(4);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1333, 632);
            this.container.TabIndex = 1;
            // 
            // panelWelcome
            // 
            this.panelWelcome.Controls.Add(this.lblLogin);
            this.panelWelcome.Controls.Add(this.lblCargo);
            this.panelWelcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWelcome.Location = new System.Drawing.Point(0, 0);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(1333, 100);
            this.panelWelcome.TabIndex = 143;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblLogin.Location = new System.Drawing.Point(32, 13);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(69, 38);
            this.lblLogin.TabIndex = 140;
            this.lblLogin.Text = "Olá";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Bahnschrift Light", 14F);
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblCargo.Location = new System.Drawing.Point(37, 53);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(114, 29);
            this.lblCargo.TabIndex = 142;
            this.lblCargo.Text = "Vendedor";
            // 
            // painelAbrirCaixa
            // 
            this.painelAbrirCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelAbrirCaixa.Controls.Add(this.label1);
            this.painelAbrirCaixa.Controls.Add(this.pictureBox1);
            this.painelAbrirCaixa.Location = new System.Drawing.Point(20, 221);
            this.painelAbrirCaixa.Name = "painelAbrirCaixa";
            this.painelAbrirCaixa.Size = new System.Drawing.Size(284, 152);
            this.painelAbrirCaixa.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(128, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 142;
            this.label1.Text = "Abrir Caixa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Views.Properties.Resources.Asset_3storePDV;
            this.pictureBox1.Location = new System.Drawing.Point(18, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuarioHeaderT
            // 
            this.lblUsuarioHeaderT.AutoSize = true;
            this.lblUsuarioHeaderT.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioHeaderT.Font = new System.Drawing.Font("Arial", 13.2F);
            this.lblUsuarioHeaderT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblUsuarioHeaderT.Location = new System.Drawing.Point(977, 13);
            this.lblUsuarioHeaderT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioHeaderT.Name = "lblUsuarioHeaderT";
            this.lblUsuarioHeaderT.Size = new System.Drawing.Size(51, 25);
            this.lblUsuarioHeaderT.TabIndex = 143;
            this.lblUsuarioHeaderT.Text = "Olá,";
            // 
            // lblUsuarioHeader
            // 
            this.lblUsuarioHeader.AutoSize = true;
            this.lblUsuarioHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioHeader.Font = new System.Drawing.Font("Open Sans SemiBold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblUsuarioHeader.Location = new System.Drawing.Point(1023, 8);
            this.lblUsuarioHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioHeader.Name = "lblUsuarioHeader";
            this.lblUsuarioHeader.Size = new System.Drawing.Size(173, 32);
            this.lblUsuarioHeader.TabIndex = 144;
            this.lblUsuarioHeader.Text = "Kleiton Freitas";
            // 
            // imageUsuario
            // 
            this.imageUsuario.Image = global::Views.Properties.Resources.Asset_3storePDV;
            this.imageUsuario.Location = new System.Drawing.Point(1286, 10);
            this.imageUsuario.Name = "imageUsuario";
            this.imageUsuario.Size = new System.Drawing.Size(30, 30);
            this.imageUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageUsuario.TabIndex = 143;
            this.imageUsuario.TabStop = false;
            // 
            // FormDashBoardAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 686);
            this.Controls.Add(this.container);
            this.Controls.Add(this.pHeader);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashBoardAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashBoardAtendente_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnNotification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConfig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageLogo)).EndInit();
            this.container.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.panelWelcome.PerformLayout();
            this.painelAbrirCaixa.ResumeLayout(false);
            this.painelAbrirCaixa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.PictureBox imageLogo;
        private System.Windows.Forms.PictureBox btnConfig;
        private System.Windows.Forms.PictureBox btnNotification;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Panel painelAbrirCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imageUsuario;
        private System.Windows.Forms.Label lblUsuarioHeader;
        private System.Windows.Forms.Label lblUsuarioHeaderT;
    }
}

