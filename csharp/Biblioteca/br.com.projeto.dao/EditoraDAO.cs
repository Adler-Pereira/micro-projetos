using Biblioteca.br.com.projeto.conexao;
using Biblioteca.br.com.projeto.model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.br.com.projeto.dao
{
    public class EditoraDAO
    {
        private readonly SqlConnection conexao;

        public EditoraDAO()
        {
            conexao = new ConnectionFactory().GetConnection();
        }

        #region CadastrarEditora
        public void CadastrarEditora(Editora editora)
        {
            try
            {
                string sql = @"INSERT INTO Editora(NomeEditora)
                           VALUES(@editora)";

                SqlCommand executacmd = new SqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@editora", editora.NomeEditora);

                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Editora cadastrada com sucesso!");
                conexao.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao cadastrar editora: " + erro);
            }
        }
        #endregion
    }
}
