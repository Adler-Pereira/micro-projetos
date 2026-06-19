using PontoDeVenda.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda
{
    public abstract class PessoaFisica : Endereco
    {
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNasc { get; set; }
    }
}
