using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda
{
    public class Produto
    {
        private static int numProdutos;
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }

        public Produto()
        {
            Produto.numProdutos++;
            this.Id = numProdutos;
        }
    }
}
