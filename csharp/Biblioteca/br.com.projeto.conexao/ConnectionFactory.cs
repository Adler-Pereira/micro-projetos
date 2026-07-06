using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.br.com.projeto.conexao
{
    public class ConnectionFactory
    {
        public SqlConnection GetConnection()
        {
            string conexao = ConfigurationManager.ConnectionStrings["Biblioteca"].ConnectionString;

            return new SqlConnection(conexao);
        }
    }
}
