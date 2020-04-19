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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation9 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashBoardAtendente));
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            this.radiusCaixa = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblBomDia = new System.Windows.Forms.Label();
            this.panelCalendario = new System.Windows.Forms.Panel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.fotoUsuario = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pData = new System.Windows.Forms.Panel();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblDiaLong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animaLabel = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.circularFoto = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_Mes = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCalendario.SuspendLayout();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.pData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // radiusCaixa
            // 
            this.radiusCaixa.ElipseRadius = 10;
            this.radiusCaixa.TargetControl = this;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblCargo, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.lblCargo, BunifuAnimatorNS.DecorationType.None);
            this.lblCargo.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblCargo.Location = new System.Drawing.Point(411, 434);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(93, 23);
            this.lblCargo.TabIndex = 142;
            this.lblCargo.Text = "Atendente";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblLogin, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.lblLogin, BunifuAnimatorNS.DecorationType.None);
            this.lblLogin.Font = new System.Drawing.Font("Open Sans", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.lblLogin.Location = new System.Drawing.Point(539, 395);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(441, 37);
            this.lblLogin.TabIndex = 140;
            this.lblLogin.Text = "Kleiton Eduardo da Silva Freitas";
            // 
            // lblBomDia
            // 
            this.lblBomDia.AutoSize = true;
            this.lblBomDia.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblBomDia, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.lblBomDia, BunifuAnimatorNS.DecorationType.None);
            this.lblBomDia.Font = new System.Drawing.Font("Open Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.lblBomDia.Location = new System.Drawing.Point(408, 398);
            this.lblBomDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBomDia.Name = "lblBomDia";
            this.lblBomDia.Size = new System.Drawing.Size(119, 33);
            this.lblBomDia.TabIndex = 144;
            this.lblBomDia.Text = "Bom dia, ";
            this.lblBomDia.Visible = false;
            // 
            // panelCalendario
            // 
            this.panelCalendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelCalendario.Controls.Add(this.bunifuSeparator1);
            this.panelCalendario.Controls.Add(this.label3);
            this.animaLabel.SetDecoration(this.panelCalendario, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panelCalendario, BunifuAnimatorNS.DecorationType.None);
            this.panelCalendario.Location = new System.Drawing.Point(1141, 45);
            this.panelCalendario.Name = "panelCalendario";
            this.panelCalendario.Size = new System.Drawing.Size(350, 715);
            this.panelCalendario.TabIndex = 145;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.animaLabel.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(13, 40);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(333, 14);
            this.bunifuSeparator1.TabIndex = 148;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Open Sans", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(8, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 145;
            this.label3.Text = "Vendas do Dia";
            // 
            // container
            // 
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.btnClose);
            this.container.Controls.Add(this.fotoUsuario);
            this.container.Controls.Add(this.panel1);
            this.container.Controls.Add(this.panelCalendario);
            this.container.Controls.Add(this.lblBomDia);
            this.container.Controls.Add(this.lblLogin);
            this.container.Controls.Add(this.lblCargo);
            this.animaLabel.SetDecoration(this.container, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.container, BunifuAnimatorNS.DecorationType.None);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Margin = new System.Windows.Forms.Padding(4);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1517, 800);
            this.container.TabIndex = 1;
            // 
            // fotoUsuario
            // 
            this.bunifuTransition1.SetDecoration(this.fotoUsuario, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.fotoUsuario, BunifuAnimatorNS.DecorationType.None);
            this.fotoUsuario.Image = global::Views.Properties.Resources.Asset_1default;
            this.fotoUsuario.Location = new System.Drawing.Point(992, 353);
            this.fotoUsuario.Name = "fotoUsuario";
            this.fotoUsuario.Size = new System.Drawing.Size(126, 126);
            this.fotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoUsuario.TabIndex = 147;
            this.fotoUsuario.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.pData);
            this.animaLabel.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(31, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 510);
            this.panel1.TabIndex = 146;
            // 
            // pData
            // 
            this.pData.Controls.Add(this.lbl_Mes);
            this.pData.Controls.Add(this.lblHoras);
            this.pData.Controls.Add(this.lblDia);
            this.pData.Controls.Add(this.lblDiaLong);
            this.animaLabel.SetDecoration(this.pData, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pData, BunifuAnimatorNS.DecorationType.None);
            this.pData.Location = new System.Drawing.Point(17, 10);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(326, 497);
            this.pData.TabIndex = 149;
            this.pData.Visible = false;
            // 
            // lblHoras
            // 
            this.lblHoras.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoras.AutoSize = true;
            this.lblHoras.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblHoras, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.lblHoras, BunifuAnimatorNS.DecorationType.None);
            this.lblHoras.Font = new System.Drawing.Font("Open Sans Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.White;
            this.lblHoras.Location = new System.Drawing.Point(73, 428);
            this.lblHoras.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(152, 45);
            this.lblHoras.TabIndex = 148;
            this.lblHoras.Text = "08:45AM";
            // 
            // lblDia
            // 
            this.lblDia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblDia, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.lblDia, BunifuAnimatorNS.DecorationType.None);
            this.lblDia.Font = new System.Drawing.Font("Open Sans Light", 90F);
            this.lblDia.ForeColor = System.Drawing.Color.White;
            this.lblDia.Location = new System.Drawing.Point(31, 138);
            this.lblDia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(171, 204);
            this.lblDia.TabIndex = 147;
            this.lblDia.Text = "1";
            // 
            // lblDiaLong
            // 
            this.lblDiaLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiaLong.AutoSize = true;
            this.lblDiaLong.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lblDiaLong, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.lblDiaLong, BunifuAnimatorNS.DecorationType.None);
            this.lblDiaLong.Font = new System.Drawing.Font("Open Sans Light", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaLong.ForeColor = System.Drawing.Color.White;
            this.lblDiaLong.Location = new System.Drawing.Point(68, 46);
            this.lblDiaLong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiaLong.Name = "lblDiaLong";
            this.lblDiaLong.Size = new System.Drawing.Size(177, 45);
            this.lblDiaLong.TabIndex = 147;
            this.lblDiaLong.Text = "DOMINGO";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation9;
            this.bunifuTransition1.Interval = 15;
            this.bunifuTransition1.TimeStep = 0.5F;
            // 
            // animaLabel
            // 
            this.animaLabel.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.animaLabel.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 0;
            animation10.Padding = new System.Windows.Forms.Padding(0);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.animaLabel.DefaultAnimation = animation10;
            // 
            // circularFoto
            // 
            this.circularFoto.ElipseRadius = 100;
            this.circularFoto.TargetControl = this.fotoUsuario;
            // 
            // lbl_Mes
            // 
            this.lbl_Mes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Mes.AutoSize = true;
            this.lbl_Mes.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.lbl_Mes, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.lbl_Mes, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Mes.Font = new System.Drawing.Font("Open Sans Light", 12.8F);
            this.lbl_Mes.ForeColor = System.Drawing.Color.White;
            this.lbl_Mes.Location = new System.Drawing.Point(92, 307);
            this.lbl_Mes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mes.Name = "lbl_Mes";
            this.lbl_Mes.Size = new System.Drawing.Size(68, 30);
            this.lbl_Mes.TabIndex = 149;
            this.lbl_Mes.Text = "MAIO";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuTransition1.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.btnClose, BunifuAnimatorNS.DecorationType.None);
            this.btnClose.Image = global::Views.Properties.Resources.cross;
            this.btnClose.Location = new System.Drawing.Point(1468, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 148;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.animaLabel.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(107)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(1414, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 27);
            this.label1.TabIndex = 149;
            this.label1.Text = "sair";
            // 
            // FormDashBoardAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1517, 800);
            this.Controls.Add(this.container);
            this.animaLabel.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDashBoardAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormDashBoardAtendente_Load);
            this.panelCalendario.ResumeLayout(false);
            this.panelCalendario.PerformLayout();
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse radiusCaixa;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblBomDia;
        private System.Windows.Forms.Panel panelCalendario;
     //   private BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label lblDiaLong;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.PictureBox fotoUsuario;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Timer timer1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Panel pData;
        private BunifuAnimatorNS.BunifuTransition animaLabel;
        private Bunifu.Framework.UI.BunifuElipse circularFoto;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lbl_Mes;
        private System.Windows.Forms.Label label1;
    }
}

