namespace Loja.UI
{
    partial class frmProdutosEmFalta
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
            this.dgvProdutosEmFalta = new System.Windows.Forms.DataGridView();
            this.lblProdutosEmFalta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEmFalta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProdutosEmFalta
            // 
            this.dgvProdutosEmFalta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutosEmFalta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutosEmFalta.Location = new System.Drawing.Point(12, 58);
            this.dgvProdutosEmFalta.Name = "dgvProdutosEmFalta";
            this.dgvProdutosEmFalta.Size = new System.Drawing.Size(474, 206);
            this.dgvProdutosEmFalta.TabIndex = 0;
            // 
            // lblProdutosEmFalta
            // 
            this.lblProdutosEmFalta.AutoSize = true;
            this.lblProdutosEmFalta.Location = new System.Drawing.Point(9, 21);
            this.lblProdutosEmFalta.Name = "lblProdutosEmFalta";
            this.lblProdutosEmFalta.Size = new System.Drawing.Size(155, 13);
            this.lblProdutosEmFalta.TabIndex = 1;
            this.lblProdutosEmFalta.Text = "Relatório de Produtos em Falta:";
            // 
            // frmProdutosEmFalta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 271);
            this.Controls.Add(this.lblProdutosEmFalta);
            this.Controls.Add(this.dgvProdutosEmFalta);
            this.Name = "frmProdutosEmFalta";
            this.Text = "Produtos Em Falta";
            this.Load += new System.EventHandler(this.frmProdutosEmFalta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutosEmFalta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdutosEmFalta;
        private System.Windows.Forms.Label lblProdutosEmFalta;
    }
}