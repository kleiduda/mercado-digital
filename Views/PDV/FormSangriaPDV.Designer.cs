namespace Views
{
    partial class FormSangriaPDV
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblError = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.painelDinheiro = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVendaDinheiro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblVendaDebito = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVendaCredito = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblVendaFiado = new System.Windows.Forms.Label();
            this.lblTotalEmCaixaT = new System.Windows.Forms.Label();
            this.lblTotalEmCaixa = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.painelDinheiro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(19, 360);
            this.btnValidar.Margin = new System.Windows.Forms.Padding(4);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(351, 67);
            this.btnValidar.TabIndex = 141;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 38);
            this.label1.TabIndex = 142;
            this.label1.Text = "Realizar Sangria?";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.Gray;
            this.txtValor.Location = new System.Drawing.Point(22, 218);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.MaxLength = 150;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(348, 38);
            this.txtValor.TabIndex = 145;
            this.txtValor.Text = "0,00";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.Enabled = false;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(22, 263);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(348, 9);
            this.bunifuSeparator2.TabIndex = 144;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Image = global::Views.Properties.Resources.report_min;
            this.lblError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblError.Location = new System.Drawing.Point(18, 305);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(234, 20);
            this.lblError.TabIndex = 146;
            this.lblError.Text = "         erro ao fazer o login";
            this.lblError.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalEmCaixa);
            this.panel1.Controls.Add(this.lblTotalEmCaixaT);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblVendaFiado);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblVendaCredito);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblVendaDebito);
            this.panel1.Controls.Add(this.painelDinheiro);
            this.panel1.Location = new System.Drawing.Point(394, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 429);
            this.panel1.TabIndex = 147;
            // 
            // painelDinheiro
            // 
            this.painelDinheiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painelDinheiro.Controls.Add(this.label6);
            this.painelDinheiro.Controls.Add(this.lblVendaDinheiro);
            this.painelDinheiro.Location = new System.Drawing.Point(18, 215);
            this.painelDinheiro.Name = "painelDinheiro";
            this.painelDinheiro.Size = new System.Drawing.Size(321, 51);
            this.painelDinheiro.TabIndex = 151;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(9, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 17);
            this.label6.TabIndex = 155;
            this.label6.Text = "Total em Dinheiro:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(28, 275);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 157;
            this.label2.Text = "Total em Débito:";
            // 
            // lblVendaDebito
            // 
            this.lblVendaDebito.AutoSize = true;
            this.lblVendaDebito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaDebito.Location = new System.Drawing.Point(166, 274);
            this.lblVendaDebito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaDebito.Name = "lblVendaDebito";
            this.lblVendaDebito.Size = new System.Drawing.Size(40, 18);
            this.lblVendaDebito.TabIndex = 156;
            this.lblVendaDebito.Text = "0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(28, 317);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 159;
            this.label4.Text = "Total em Crédito:";
            // 
            // lblVendaCredito
            // 
            this.lblVendaCredito.AutoSize = true;
            this.lblVendaCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaCredito.Location = new System.Drawing.Point(166, 316);
            this.lblVendaCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaCredito.Name = "lblVendaCredito";
            this.lblVendaCredito.Size = new System.Drawing.Size(40, 18);
            this.lblVendaCredito.TabIndex = 158;
            this.lblVendaCredito.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(28, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 161;
            this.label7.Text = "Total em Fiado:";
            // 
            // lblVendaFiado
            // 
            this.lblVendaFiado.AutoSize = true;
            this.lblVendaFiado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblVendaFiado.Location = new System.Drawing.Point(166, 359);
            this.lblVendaFiado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendaFiado.Name = "lblVendaFiado";
            this.lblVendaFiado.Size = new System.Drawing.Size(40, 18);
            this.lblVendaFiado.TabIndex = 160;
            this.lblVendaFiado.Text = "0.00";
            // 
            // lblTotalEmCaixaT
            // 
            this.lblTotalEmCaixaT.AutoSize = true;
            this.lblTotalEmCaixaT.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalEmCaixaT.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalEmCaixaT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTotalEmCaixaT.Location = new System.Drawing.Point(26, 31);
            this.lblTotalEmCaixaT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEmCaixaT.Name = "lblTotalEmCaixaT";
            this.lblTotalEmCaixaT.Size = new System.Drawing.Size(190, 28);
            this.lblTotalEmCaixaT.TabIndex = 162;
            this.lblTotalEmCaixaT.Text = "Total em Caixa: ";
            // 
            // lblTotalEmCaixa
            // 
            this.lblTotalEmCaixa.AutoSize = true;
            this.lblTotalEmCaixa.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalEmCaixa.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalEmCaixa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.lblTotalEmCaixa.Location = new System.Drawing.Point(27, 90);
            this.lblTotalEmCaixa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalEmCaixa.Name = "lblTotalEmCaixa";
            this.lblTotalEmCaixa.Size = new System.Drawing.Size(87, 28);
            this.lblTotalEmCaixa.TabIndex = 163;
            this.lblTotalEmCaixa.Text = "R$0,00";
            // 
            // FormSangriaPDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(762, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSangriaPDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormValorInicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.painelDinheiro.ResumeLayout(false);
            this.painelDinheiro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtValor;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblVendaFiado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblVendaCredito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblVendaDebito;
        private System.Windows.Forms.Panel painelDinheiro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblVendaDinheiro;
        private System.Windows.Forms.Label lblTotalEmCaixaT;
        private System.Windows.Forms.Label lblTotalEmCaixa;
    }
}