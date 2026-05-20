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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecoProduto = new System.Windows.Forms.NumericUpDown();
            this.txtDescProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imgEdiProduto = new System.Windows.Forms.PictureBox();
            this.txtImgProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btConfEdicao = new System.Windows.Forms.Button();
            this.btCancEdicao = new System.Windows.Forms.Button();
            this.btImagem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdiProduto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(410, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(413, 54);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(198, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(410, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço:";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.DecimalPlaces = 2;
            this.txtPrecoProduto.Location = new System.Drawing.Point(413, 112);
            this.txtPrecoProduto.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtPrecoProduto.Name = "txtPrecoProduto";
            this.txtPrecoProduto.Size = new System.Drawing.Size(198, 20);
            this.txtPrecoProduto.TabIndex = 2;
            // 
            // txtDescProduto
            // 
            this.txtDescProduto.Location = new System.Drawing.Point(413, 241);
            this.txtDescProduto.Multiline = true;
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(198, 53);
            this.txtDescProduto.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(410, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // imgEdiProduto
            // 
            this.imgEdiProduto.Location = new System.Drawing.Point(49, 37);
            this.imgEdiProduto.Name = "imgEdiProduto";
            this.imgEdiProduto.Size = new System.Drawing.Size(297, 305);
            this.imgEdiProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEdiProduto.TabIndex = 5;
            this.imgEdiProduto.TabStop = false;
            // 
            // txtImgProduto
            // 
            this.txtImgProduto.Location = new System.Drawing.Point(0, 0);
            this.txtImgProduto.Name = "txtImgProduto";
            this.txtImgProduto.Size = new System.Drawing.Size(192, 20);
            this.txtImgProduto.TabIndex = 7;
            this.txtImgProduto.TextChanged += new System.EventHandler(this.txtImgProduto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(410, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Imagem:";
            // 
            // btConfEdicao
            // 
            this.btConfEdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfEdicao.Location = new System.Drawing.Point(536, 319);
            this.btConfEdicao.Name = "btConfEdicao";
            this.btConfEdicao.Size = new System.Drawing.Size(75, 23);
            this.btConfEdicao.TabIndex = 8;
            this.btConfEdicao.Text = "Confirmar";
            this.btConfEdicao.UseVisualStyleBackColor = true;
            this.btConfEdicao.Click += new System.EventHandler(this.btConfEdicao_Click);
            // 
            // btCancEdicao
            // 
            this.btCancEdicao.BackColor = System.Drawing.Color.Maroon;
            this.btCancEdicao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancEdicao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancEdicao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancEdicao.Location = new System.Drawing.Point(413, 318);
            this.btCancEdicao.Name = "btCancEdicao";
            this.btCancEdicao.Size = new System.Drawing.Size(75, 23);
            this.btCancEdicao.TabIndex = 9;
            this.btCancEdicao.Text = "Cancelar";
            this.btCancEdicao.UseVisualStyleBackColor = false;
            this.btCancEdicao.Click += new System.EventHandler(this.btCancEdicao_Click);
            // 
            // btImagem
            // 
            this.btImagem.AllowDrop = true;
            this.btImagem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImagem.Location = new System.Drawing.Point(0, 0);
            this.btImagem.Name = "btImagem";
            this.btImagem.Size = new System.Drawing.Size(198, 23);
            this.btImagem.TabIndex = 10;
            this.btImagem.Text = "Anexar Imagem";
            this.btImagem.UseVisualStyleBackColor = true;
            this.btImagem.Click += new System.EventHandler(this.btImagem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(413, 163);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 46);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtImgProduto);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 20);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Link";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btImagem);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 20);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anexo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // FormEdiProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btCancEdicao);
            this.Controls.Add(this.btConfEdicao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imgEdiProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEdiProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edição de Produto";
            this.Load += new System.EventHandler(this.FormEdiProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEdiProduto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtPrecoProduto;
        private System.Windows.Forms.TextBox txtDescProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgEdiProduto;
        private System.Windows.Forms.TextBox txtImgProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btConfEdicao;
        private System.Windows.Forms.Button btCancEdicao;
        private System.Windows.Forms.Button btImagem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}