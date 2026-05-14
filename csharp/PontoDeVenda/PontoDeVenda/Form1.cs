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
        private List<Produto> produtos = new List<Produto>();
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
            produtos.Add(produto);
        }
    }
}
