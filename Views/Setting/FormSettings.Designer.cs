namespace Views.Setting
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenuLeft = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelResult = new System.Windows.Forms.Panel();
            this.btnGeral = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelContainer.SuspendLayout();
            this.panelMenuLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.White;
            this.panelContainer.Controls.Add(this.panelResult);
            this.panelContainer.Controls.Add(this.panelMenuLeft);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1351, 733);
            this.panelContainer.TabIndex = 0;
            // 
            // panelMenuLeft
            // 
            this.panelMenuLeft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenuLeft.Controls.Add(this.btnGeral);
            this.panelMenuLeft.Location = new System.Drawing.Point(19, 24);
            this.panelMenuLeft.Name = "panelMenuLeft";
            this.panelMenuLeft.Size = new System.Drawing.Size(218, 697);
            this.panelMenuLeft.TabIndex = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.panelMenuLeft;
            // 
            // panelResult
            // 
            this.panelResult.Location = new System.Drawing.Point(243, 24);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(1096, 697);
            this.panelResult.TabIndex = 1;
            // 
            // btnGeral
            // 
            this.btnGeral.ActiveBorderThickness = 1;
            this.btnGeral.ActiveCornerRadius = 1;
            this.btnGeral.ActiveFillColor = System.Drawing.Color.Gray;
            this.btnGeral.ActiveForecolor = System.Drawing.Color.White;
            this.btnGeral.ActiveLineColor = System.Drawing.Color.SeaShell;
            this.btnGeral.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeral.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeral.BackgroundImage")));
            this.btnGeral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGeral.ButtonText = "+ Geral";
            this.btnGeral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeral.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeral.ForeColor = System.Drawing.Color.Gray;
            this.btnGeral.IdleBorderThickness = 1;
            this.btnGeral.IdleCornerRadius = 1;
            this.btnGeral.IdleFillColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeral.IdleForecolor = System.Drawing.Color.Gray;
            this.btnGeral.IdleLineColor = System.Drawing.Color.WhiteSmoke;
            this.btnGeral.Location = new System.Drawing.Point(9, 86);
            this.btnGeral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGeral.Name = "btnGeral";
            this.btnGeral.Size = new System.Drawing.Size(201, 41);
            this.btnGeral.TabIndex = 2;
            this.btnGeral.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1351, 733);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelMenuLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelMenuLeft;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGeral;
        private System.Windows.Forms.Panel panelResult;
    }
}