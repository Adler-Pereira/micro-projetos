using PontoDeVenda.View;
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
    public partial class Form1 : Form
    {
        public List<Produto> Produtos { get; private set; } = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadProduto_Click(object sender, EventArgs e)
        {
            FormCadProduto formCadProduto = new FormCadProduto(this);
            formCadProduto.ShowDialog();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void EditarProduto(Produto prodEditado, Produto prodAntigo)
        {
            Produtos[prodAntigo.Id] = prodEditado;
        }

        private void btEdiProduto_Click(object sender, EventArgs e)
        {
            FormEdiListProduto formEdiListProduto = new FormEdiListProduto(this);
            formEdiListProduto.ShowDialog();
        }
    }
}
