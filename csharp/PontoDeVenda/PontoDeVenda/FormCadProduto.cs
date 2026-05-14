using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PontoDeVenda
{
    public partial class FormCadProduto : Form
    {
        private Form1 formPrincipal;
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
            produto.Imagem = txtImgProduto.Text;
            produto.Descricao = txtDescProduto.Text;

            formPrincipal.AdicionarProduto(produto);

            this.Close();
        }

        private void txtImgProduto_TextChanged(object sender, EventArgs e)
        {
            imgCadProduto.ImageLocation = txtImgProduto.Text;
        }
    }
}
