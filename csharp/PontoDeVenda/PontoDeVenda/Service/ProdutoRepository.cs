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

        public static List<Produto> GetProdutos()
        {
            Produto produto = new Produto();
            Produto.numProdutos--;
            List<Produto> listaProdutos = new List<Produto>();

            Stream dbProduto = File.Open("dbproduto.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(dbProduto);
            string linha = streamReader.ReadLine();

            while (linha != null)
            {
                string[] dadosProduto = linha.Split(';');

                produto.Id = Convert.ToInt32(dadosProduto[0]);
                produto.Nome = dadosProduto[1];
                produto.Preco = Convert.ToDecimal(dadosProduto[2]);
                produto.Descricao = dadosProduto[3];
                produto.Imagem = dadosProduto[4];

                listaProdutos.Add(produto);
                produto = new Produto();
                Produto.numProdutos--;
                linha = streamReader.ReadLine();
            }
            streamReader.Close();
            dbProduto.Close();

            return listaProdutos;
        }
    }
}
