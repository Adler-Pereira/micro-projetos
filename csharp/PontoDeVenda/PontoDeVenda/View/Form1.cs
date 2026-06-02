using PontoDeVenda.View;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (Stream saida = File.Open("produtos.svg", FileMode.Create))
            using (StreamWriter escritor = new StreamWriter(saida))
            {
                foreach (var produto in Produtos)
                {
                    escritor.WriteLine("{0};{1};{2};{3};{4}",
                        produto.Id,
                        produto.Nome,
                        produto.Preco,
                        produto.Descricao,
                        produto.Imagem
                    );

                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (Stream entrada = File.Open("produtos.svg", FileMode.Open))
            using (StreamReader leitor = new StreamReader(entrada))
            {
                while (true)
                {
                    string linha = leitor.ReadLine();

                    if (linha == null) break;

                    string[] dadosProduto = linha.Split(';');

                    Produtos.Add(new Produto(int.Parse(dadosProduto[0]), dadosProduto[1], decimal.Parse(dadosProduto[2]), dadosProduto[3], dadosProduto[4]));
                }
            }
        }
    }
}
