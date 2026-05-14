using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda.Model
{
    class Venda
    {
        public long Id { get; set; }
        public List<Produto> Produtos { get; set; }
        public decimal valToltal { get; set; }
    }
}
