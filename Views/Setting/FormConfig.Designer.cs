namespace Views.Produtos
{
    partial class FormConfig
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
            this.pDataGrid = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfigImagePath = new System.Windows.Forms.Button();
            this.btnImportProducts = new System.Windows.Forms.Button();
            this.pDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pDataGrid
            // 
            this.pDataGrid.Controls.Add(this.btnImportProducts);
            this.pDataGrid.Controls.Add(this.btnConfigImagePath);
            this.pDataGrid.Location = new System.Drawing.Point(41, 64);
            this.pDataGrid.Name = "pDataGrid";
            this.pDataGrid.Size = new System.Drawing.Size(1363, 743);
            this.pDataGrid.TabIndex = 175;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 17);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 44);
            this.label9.TabIndex = 173;
            this.label9.Text = "#CONFIGURAÇÕES";
            // 
            // btnConfigImagePath
            // 
            this.btnConfigImagePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigImagePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigImagePath.Location = new System.Drawing.Point(26, 34);
            this.btnConfigImagePath.Name = "btnConfigImagePath";
            this.btnConfigImagePath.Size = new System.Drawing.Size(219, 99);
            this.btnConfigImagePath.TabIndex = 163;
            this.btnConfigImagePath.Text = "SALVAR IMAGENS";
            this.btnConfigImagePath.UseVisualStyleBackColor = true;
            this.btnConfigImagePath.Click += new System.EventHandler(this.btnConfigImagePath_Click);
            // 
            // btnImportProducts
            // 
            this.btnImportProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportProducts.Location = new System.Drawing.Point(26, 149);
            this.btnImportProducts.Name = "btnImportProducts";
            this.btnImportProducts.Size = new System.Drawing.Size(219, 99);
            this.btnImportProducts.TabIndex = 164;
            this.btnImportProducts.Text = "IMPORTAR PRODUTOS";
            this.btnImportProducts.UseVisualStyleBackColor = true;
            this.btnImportProducts.Click += new System.EventHandler(this.btnImportProducts_Click);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1436, 835);
            this.Controls.Add(this.pDataGrid);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.Text = "FormNovoProduto";
            this.pDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pDataGrid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnImportProducts;
        private System.Windows.Forms.Button btnConfigImagePath;
    }
}