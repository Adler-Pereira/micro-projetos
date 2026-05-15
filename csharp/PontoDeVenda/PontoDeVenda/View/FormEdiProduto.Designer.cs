namespace PontoDeVenda.View
{
    partial class FormEdiProduto
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
            this.listBoxProduto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxProduto
            // 
            this.listBoxProduto.FormattingEnabled = true;
            this.listBoxProduto.Location = new System.Drawing.Point(62, 81);
            this.listBoxProduto.MultiColumn = true;
            this.listBoxProduto.Name = "listBoxProduto";
            this.listBoxProduto.Size = new System.Drawing.Size(544, 264);
            this.listBoxProduto.TabIndex = 0;
            // 
            // FormEdiProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.listBoxProduto);
            this.Name = "FormEdiProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormEdiProduto";
            this.Load += new System.EventHandler(this.FormEdiProduto_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProduto;
    }
}