using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda.Model
{
    public class Cliente : PessoaFisica
    {
        public decimal Credito { get; set; }
        public string Observacao { get; set; }
    }
}
