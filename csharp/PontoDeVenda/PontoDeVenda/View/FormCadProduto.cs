using PontoDeVenda.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PontoDeVenda
{
    public partial class FormCadProduto : Form
    {
        private Form1 formPrincipal;
        private string imagemProduto;
        public FormCadProduto(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void txtDescProduto_TextChanged(object sender, EventArgs e)
        {
        }

        private void btConfCadastro_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();

            produto.Nome = txtNomeProduto.Text;
            produto.Preco = txtPrecoProduto.Value;
            produto.Imagem = imagemProduto;
            produto.Descricao = txtDescProduto.Text;

            formPrincipal.AdicionarProduto(produto);

            ProdutoRepository.AddProduto(produto);

            this.Close();
        }

        private void txtImgProduto_TextChanged(object sender, EventArgs e)
        {
            imagemProduto = txtImgProduto.Text;
            imgCadProduto.ImageLocation = imagemProduto;
        }

        private void btImagem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                imagemProduto = filePath;
                imgCadProduto.ImageLocation = imagemProduto;
            }
        }

        private void btCancCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
