using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda.Service
{
    public static class ProdutoRepository
    {
        public static void RegistrarProduto(Produto produto)
        {
            Stream dbProduto = File.Open("dbproduto.txt", FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(dbProduto);
            streamWriter.WriteLine(produto.Id + ";" +
                                   produto.Nome + ";" +
                                   produto.Preco + ";" +
                                   produto.Descricao + ";" +
                                   produto.Imagem);
            streamWriter.Close();
            dbProduto.Close();
        }
    }
}
