using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda
{
    abstract class Pessoa
    {
        public string CpfCnpj { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNasc { get; set; }
    }
}
