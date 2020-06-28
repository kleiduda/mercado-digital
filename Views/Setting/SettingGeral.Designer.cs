namespace Views.Setting
{
    partial class SettingGeral
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
            this.lblUser = new System.Windows.Forms.Label();
            this.lblValorInicial = new System.Windows.Forms.Label();
            this.txtPathImage = new System.Windows.Forms.TextBox();
            this.fbd1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblAlert = new System.Windows.Forms.Label();
            this.lblFolderPath = new System.Windows.Forms.Label();
            this.lblSuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblUser.Location = new System.Drawing.Point(79, 184);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(305, 38);
            this.lblUser.TabIndex = 141;
            this.lblUser.Text = "Olá Kleiton Freitas";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorInicial
            // 
            this.lblValorInicial.AutoSize = true;
            this.lblValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorInicial.Location = new System.Drawing.Point(85, 222);
            this.lblValorInicial.Name = "lblValorInicial";
            this.lblValorInicial.Size = new System.Drawing.Size(264, 25);
            this.lblValorInicial.TabIndex = 144;
            this.lblValorInicial.Text = "Onde guardo suas imagens?";
            this.lblValorInicial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPathImage
            // 
            this.txtPathImage.AllowDrop = true;
            this.txtPathImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPathImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPathImage.Location = new System.Drawing.Point(77, 318);
            this.txtPathImage.Margin = new System.Windows.Forms.Padding(4);
            this.txtPathImage.Name = "txtPathImage";
            this.txtPathImage.Size = new System.Drawing.Size(881, 30);
            this.txtPathImage.TabIndex = 151;
            this.txtPathImage.Click += new System.EventHandler(this.txtPathImage_Click);
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.BackColor = System.Drawing.Color.Transparent;
            this.lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAlert.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblAlert.Image = global::Views.Properties.Resources.alert;
            this.lblAlert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAlert.Location = new System.Drawing.Point(83, 362);
            this.lblAlert.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(531, 20);
            this.lblAlert.TabIndex = 154;
            this.lblAlert.Text = "         blz, todas as suas imagens serão armazendas na pas x";
            this.lblAlert.Visible = false;
            // 
            // lblFolderPath
            // 
            this.lblFolderPath.AutoSize = true;
            this.lblFolderPath.BackColor = System.Drawing.Color.Transparent;
            this.lblFolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.lblFolderPath.Image = global::Views.Properties.Resources.folder16;
            this.lblFolderPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFolderPath.Location = new System.Drawing.Point(82, 361);
            this.lblFolderPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolderPath.Name = "lblFolderPath";
            this.lblFolderPath.Size = new System.Drawing.Size(531, 20);
            this.lblFolderPath.TabIndex = 153;
            this.lblFolderPath.Text = "         blz, todas as suas imagens serão armazendas na pas x";
            this.lblFolderPath.Visible = false;
            // 
            // lblSuc
            // 
            this.lblSuc.AutoSize = true;
            this.lblSuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.lblSuc.Image = global::Views.Properties.Resources.sucesso;
            this.lblSuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuc.Location = new System.Drawing.Point(86, 363);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(531, 20);
            this.lblSuc.TabIndex = 152;
            this.lblSuc.Text = "         blz, todas as suas imagens serão armazendas na pas x";
            this.lblSuc.Visible = false;
            // 
            // SettingGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblFolderPath);
            this.Controls.Add(this.lblSuc);
            this.Controls.Add(this.txtPathImage);
            this.Controls.Add(this.lblValorInicial);
            this.Controls.Add(this.lblUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingGeral";
            this.Load += new System.EventHandler(this.SettingGeral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblValorInicial;
        private System.Windows.Forms.TextBox txtPathImage;
        private System.Windows.Forms.FolderBrowserDialog fbd1;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Label lblFolderPath;
        private System.Windows.Forms.Label lblAlert;
    }
}