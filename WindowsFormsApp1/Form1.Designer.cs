namespace WindowsFormsApp1    {
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.pesquisarCidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1072, 18);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Navegar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(18, 18);
            this.txtSite.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSite.Multiline = true;
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(1044, 30);
            this.txtSite.TabIndex = 5;
            this.txtSite.Text = "https://google.com";
            // 
            // pesquisarCidade
            // 
            this.pesquisarCidade.Location = new System.Drawing.Point(708, 72);
            this.pesquisarCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pesquisarCidade.Name = "pesquisarCidade";
            this.pesquisarCidade.Size = new System.Drawing.Size(148, 26);
            this.pesquisarCidade.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 814);
            this.Controls.Add(this.pesquisarCidade);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox pesquisarCidade;
    }
}

