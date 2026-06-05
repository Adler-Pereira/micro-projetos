namespace PontoDeVenda.View
{
    partial class FormCadCliente
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
            this.btCancCadastro = new System.Windows.Forms.Button();
            this.btConfCadastro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObsCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateNascCliente = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreditoCliente = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btCancCadastro
            // 
            this.btCancCadastro.BackColor = System.Drawing.Color.Maroon;
            this.btCancCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancCadastro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCancCadastro.Location = new System.Drawing.Point(413, 318);
            this.btCancCadastro.Name = "btCancCadastro";
            this.btCancCadastro.Size = new System.Drawing.Size(75, 23);
            this.btCancCadastro.TabIndex = 21;
            this.btCancCadastro.Text = "Cancelar";
            this.btCancCadastro.UseVisualStyleBackColor = false;
            this.btCancCadastro.Click += new System.EventHandler(this.btCancCadastro_Click);
            // 
            // btConfCadastro
            // 
            this.btConfCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfCadastro.Location = new System.Drawing.Point(536, 319);
            this.btConfCadastro.Name = "btConfCadastro";
            this.btConfCadastro.Size = new System.Drawing.Size(75, 23);
            this.btConfCadastro.TabIndex = 20;
            this.btConfCadastro.Text = "Confirmar";
            this.btConfCadastro.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(54, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Observação:";
            // 
            // txtObsCliente
            // 
            this.txtObsCliente.Location = new System.Drawing.Point(57, 151);
            this.txtObsCliente.Multiline = true;
            this.txtObsCliente.Name = "txtObsCliente";
            this.txtObsCliente.Size = new System.Drawing.Size(555, 139);
            this.txtObsCliente.TabIndex = 16;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(57, 55);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(422, 20);
            this.txtNomeCliente.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(527, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(527, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "CPF:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(530, 55);
            this.maskedTextBox1.Mask = "99.999.999-9";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBox1.TabIndex = 25;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(530, 101);
            this.maskedTextBox2.Mask = "999.999.999-99";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(82, 20);
            this.maskedTextBox2.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(54, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Data de Nascimento:";
            // 
            // dateNascCliente
            // 
            this.dateNascCliente.CustomFormat = "";
            this.dateNascCliente.Location = new System.Drawing.Point(57, 102);
            this.dateNascCliente.MaxDate = new System.DateTime(2026, 6, 3, 0, 0, 0, 0);
            this.dateNascCliente.Name = "dateNascCliente";
            this.dateNascCliente.Size = new System.Drawing.Size(240, 20);
            this.dateNascCliente.TabIndex = 28;
            this.dateNascCliente.Value = new System.DateTime(2026, 6, 3, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(349, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Crédito:";
            // 
            // txtCreditoCliente
            // 
            this.txtCreditoCliente.DecimalPlaces = 2;
            this.txtCreditoCliente.Location = new System.Drawing.Point(352, 101);
            this.txtCreditoCliente.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtCreditoCliente.Name = "txtCreditoCliente";
            this.txtCreditoCliente.Size = new System.Drawing.Size(127, 20);
            this.txtCreditoCliente.TabIndex = 31;
            this.txtCreditoCliente.ThousandsSeparator = true;
            // 
            // FormCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(664, 381);
            this.Controls.Add(this.txtCreditoCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateNascCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancCadastro);
            this.Controls.Add(this.btConfCadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtObsCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label1);
            this.Name = "FormCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadCliente";
            this.Load += new System.EventHandler(this.FormCadCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCancCadastro;
        private System.Windows.Forms.Button btConfCadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtObsCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateNascCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtCreditoCliente;
    }
}