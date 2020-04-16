namespace Views.Pagamento
{
    partial class FormDinheiro
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
            this.txtRecebido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTroco = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRecebido
            // 
            this.txtRecebido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtRecebido.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRecebido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRecebido.Font = new System.Drawing.Font("Arial", 30F);
            this.txtRecebido.ForeColor = System.Drawing.Color.Black;
            this.txtRecebido.Location = new System.Drawing.Point(31, 310);
            this.txtRecebido.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecebido.MaxLength = 150;
            this.txtRecebido.Name = "txtRecebido";
            this.txtRecebido.Size = new System.Drawing.Size(418, 65);
            this.txtRecebido.TabIndex = 129;
            this.txtRecebido.TextChanged += new System.EventHandler(this.txtRecebido_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 37);
            this.label1.TabIndex = 130;
            this.label1.Text = "PAGAMENTO EM DINHEIRO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 46);
            this.label2.TabIndex = 131;
            this.label2.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Arial Black", 30.25F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTotal.Location = new System.Drawing.Point(20, 181);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(149, 72);
            this.lblTotal.TabIndex = 139;
            this.lblTotal.Text = "0,00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label3.Location = new System.Drawing.Point(33, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 140;
            this.label3.Text = "RECEBIDO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 20F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label4.Location = new System.Drawing.Point(27, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 46);
            this.label4.TabIndex = 141;
            this.label4.Text = "TROCO";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.BackColor = System.Drawing.Color.Transparent;
            this.lblTroco.Font = new System.Drawing.Font("Arial Black", 30.25F, System.Drawing.FontStyle.Bold);
            this.lblTroco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTroco.Location = new System.Drawing.Point(25, 458);
            this.lblTroco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(149, 72);
            this.lblTroco.TabIndex = 142;
            this.lblTroco.Text = "0,00";
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.btnConfirma.Enabled = false;
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.Color.White;
            this.btnConfirma.Location = new System.Drawing.Point(32, 560);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(417, 57);
            this.btnConfirma.TabIndex = 149;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 35);
            this.panel4.TabIndex = 167;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::Views.Properties.Resources.delete;
            this.btnClose.Location = new System.Drawing.Point(446, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(27, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 143;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormDinheiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(473, 655);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecebido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDinheiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamento em Dinheiro";
            this.Load += new System.EventHandler(this.FormDinheiro_Load);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtRecebido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btnClose;
    }
}