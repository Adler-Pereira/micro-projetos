using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PontoDeVenda.View
{
    public partial class FormEdiProduto : Form
    {
        private Form1 formPrincipal;
        private FormEdiListProduto formListProduto;
        private string imagemProduto;
        public FormEdiProduto(Form1 formPrincipal, FormEdiListProduto formListProduto)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
            this.formListProduto = formListProduto;
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja remover o produto?",
                "Confirmação de exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                formPrincipal.Produtos.Remove(formListProduto.ProdSelecionado);
                formListProduto.CarregarPagina();
                this.Close();
            }
        }

        private void btCancEdicao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btConfEdicao_Click(object sender, EventArgs e)
        {
            formListProduto.ProdSelecionado.Nome = txtNomeProduto.Text;
            formListProduto.ProdSelecionado.Preco = txtPrecoProduto.Value;
            formListProduto.ProdSelecionado.Imagem = imagemProduto;
            formListProduto.ProdSelecionado.Descricao = txtDescProduto.Text;

            formListProduto.CarregarPagina();
            this.Close();
        }

        private void FormEdiProduto_Load(object sender, EventArgs e)
        {
            txtNomeProduto.Text = formListProduto.ProdSelecionado.Nome;
            txtPrecoProduto.Value = formListProduto.ProdSelecionado.Preco;
            txtImgProduto.Text = formListProduto.ProdSelecionado.Imagem;
            txtDescProduto.Text = formListProduto.ProdSelecionado.Descricao;

            imgEdiProduto.ImageLocation = formListProduto.ProdSelecionado.Imagem;
        }

        private void txtImgProduto_TextChanged(object sender, EventArgs e)
        {
            imagemProduto = txtImgProduto.Text;
            imgEdiProduto.ImageLocation = imagemProduto;
        }

        private void btImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                imagemProduto = filePath;
                imgEdiProduto.ImageLocation = imagemProduto;
            }
        }
    }
}
