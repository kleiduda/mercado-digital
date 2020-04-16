namespace Views.PDV
{
    partial class FormCpfNota
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
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirma = new System.Windows.Forms.Button();
            this.lblSuc = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCpf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCpf.Font = new System.Drawing.Font("Arial", 30F);
            this.txtCpf.ForeColor = System.Drawing.Color.Black;
            this.txtCpf.Location = new System.Drawing.Point(61, 146);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpf.MaxLength = 150;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(653, 65);
            this.txtCpf.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(56, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 29);
            this.label1.TabIndex = 152;
            this.label1.Text = "CADASTRO CPF";
            // 
            // btnConfirma
            // 
            this.btnConfirma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(171)))), ((int)(((byte)(226)))));
            this.btnConfirma.FlatAppearance.BorderSize = 0;
            this.btnConfirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirma.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirma.ForeColor = System.Drawing.Color.White;
            this.btnConfirma.Location = new System.Drawing.Point(61, 304);
            this.btnConfirma.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirma.Name = "btnConfirma";
            this.btnConfirma.Size = new System.Drawing.Size(653, 57);
            this.btnConfirma.TabIndex = 158;
            this.btnConfirma.Text = "CONFIRMA";
            this.btnConfirma.UseVisualStyleBackColor = false;
            this.btnConfirma.Click += new System.EventHandler(this.btnConfirma_Click);
            // 
            // lblSuc
            // 
            this.lblSuc.AutoSize = true;
            this.lblSuc.BackColor = System.Drawing.Color.Transparent;
            this.lblSuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(175)))), ((int)(((byte)(115)))));
            this.lblSuc.Image = global::Views.Properties.Resources.sucesso;
            this.lblSuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSuc.Location = new System.Drawing.Point(72, 250);
            this.lblSuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(234, 20);
            this.lblSuc.TabIndex = 164;
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
            this.lblError.Location = new System.Drawing.Point(72, 250);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(234, 20);
            this.lblError.TabIndex = 163;
            this.lblError.Text = "         erro ao fazer o login";
            this.lblError.Visible = false;
            // 
            // FormCpfNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 390);
            this.Controls.Add(this.lblSuc);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnConfirma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCpf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCpfNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCpfNota";
            this.Load += new System.EventHandler(this.FormCpfNota_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirma;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.Label lblError;
    }
}