namespace PontoDeVenda
{
    partial class FormCadProduto
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
            this.imgCadProduto = new System.Windows.Forms.PictureBox();
            this.txtImgProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btConfCadastro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadProduto)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(410, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Preço:";
            // 
            // txtPrecoProduto
            // 
            this.txtPrecoProduto.DecimalPlaces = 2;
            this.txtPrecoProduto.Location = new System.Drawing.Point(413, 101);
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
            this.txtDescProduto.Location = new System.Drawing.Point(413, 206);
            this.txtDescProduto.Multiline = true;
            this.txtDescProduto.Name = "txtDescProduto";
            this.txtDescProduto.Size = new System.Drawing.Size(198, 91);
            this.txtDescProduto.TabIndex = 3;
            this.txtDescProduto.TextChanged += new System.EventHandler(this.txtDescProduto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(410, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // imgCadProduto
            // 
            this.imgCadProduto.Location = new System.Drawing.Point(49, 37);
            this.imgCadProduto.Name = "imgCadProduto";
            this.imgCadProduto.Size = new System.Drawing.Size(297, 305);
            this.imgCadProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgCadProduto.TabIndex = 5;
            this.imgCadProduto.TabStop = false;
            // 
            // txtImgProduto
            // 
            this.txtImgProduto.Location = new System.Drawing.Point(413, 153);
            this.txtImgProduto.Name = "txtImgProduto";
            this.txtImgProduto.Size = new System.Drawing.Size(198, 20);
            this.txtImgProduto.TabIndex = 7;
            this.txtImgProduto.TextChanged += new System.EventHandler(this.txtImgProduto_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(410, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Link da imagem:";
            // 
            // btConfCadastro
            // 
            this.btConfCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfCadastro.Location = new System.Drawing.Point(536, 319);
            this.btConfCadastro.Name = "btConfCadastro";
            this.btConfCadastro.Size = new System.Drawing.Size(75, 23);
            this.btConfCadastro.TabIndex = 8;
            this.btConfCadastro.Text = "Confirmar";
            this.btConfCadastro.UseVisualStyleBackColor = true;
            this.btConfCadastro.Click += new System.EventHandler(this.btConfCadastro_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(413, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // FormCadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(665, 381);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btConfCadastro);
            this.Controls.Add(this.txtImgProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imgCadProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescProduto);
            this.Controls.Add(this.txtPrecoProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCadProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Produto";
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecoProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCadProduto)).EndInit();
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
        private System.Windows.Forms.PictureBox imgCadProduto;
        private System.Windows.Forms.TextBox txtImgProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btConfCadastro;
        private System.Windows.Forms.Button button2;
    }
}