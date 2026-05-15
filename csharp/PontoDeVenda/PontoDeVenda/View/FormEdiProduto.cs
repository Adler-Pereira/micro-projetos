using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PontoDeVenda.View
{
    public partial class FormEdiProduto : Form
    {
        private Form1 formPrincipal;
        public FormEdiProduto(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEdiProduto_Load(object sender, EventArgs e)
        {
            foreach (Produto produto in formPrincipal.Produtos)
            {
                listBoxProduto.Items.Add(produto);
            }
        }
    }
}
