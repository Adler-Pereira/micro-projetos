using Biblioteca.br.com.projeto.dao;
using Biblioteca.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCadEditora_Click(object sender, EventArgs e)
        {
            Editora editora = new Editora();
            EditoraDAO editoraDAO = new EditoraDAO();

            editora.NomeEditora = txtNomeEditora.Text;

            editoraDAO.CadastrarEditora(editora);
        }
    }
}
