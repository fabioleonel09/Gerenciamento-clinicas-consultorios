
namespace segmentoOtoneurologia
{
    partial class frmFinanceiroEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinanceiroEstoque));
            this.btnAbreEstoque = new System.Windows.Forms.Button();
            this.btnAbreFinanceiro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbreEstoque
            // 
            this.btnAbreEstoque.BackColor = System.Drawing.Color.SandyBrown;
            this.btnAbreEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbreEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbreEstoque.Image = global::segmentoOtoneurologia.Properties.Resources.Estoque;
            this.btnAbreEstoque.Location = new System.Drawing.Point(110, 59);
            this.btnAbreEstoque.Name = "btnAbreEstoque";
            this.btnAbreEstoque.Size = new System.Drawing.Size(191, 146);
            this.btnAbreEstoque.TabIndex = 0;
            this.btnAbreEstoque.UseVisualStyleBackColor = false;
            this.btnAbreEstoque.Click += new System.EventHandler(this.btnAbreEstoque_Click);
            // 
            // btnAbreFinanceiro
            // 
            this.btnAbreFinanceiro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbreFinanceiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbreFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbreFinanceiro.Image = global::segmentoOtoneurologia.Properties.Resources.financeiro;
            this.btnAbreFinanceiro.Location = new System.Drawing.Point(316, 59);
            this.btnAbreFinanceiro.Name = "btnAbreFinanceiro";
            this.btnAbreFinanceiro.Size = new System.Drawing.Size(191, 146);
            this.btnAbreFinanceiro.TabIndex = 1;
            this.btnAbreFinanceiro.UseVisualStyleBackColor = false;
            this.btnAbreFinanceiro.Click += new System.EventHandler(this.btnAbreFinanceiro_Click);
            // 
            // frmFinanceiroEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(618, 261);
            this.Controls.Add(this.btnAbreFinanceiro);
            this.Controls.Add(this.btnAbreEstoque);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmFinanceiroEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Escolha entre \"Estoque\" ou \"Financeiro\"";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbreEstoque;
        private System.Windows.Forms.Button btnAbreFinanceiro;
    }
}