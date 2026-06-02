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
    public partial class FormEdiListProduto : Form
    {
        private Form1 formPrincipal;
        public Produto ProdSelecionado { get; set; }
        public FormEdiListProduto(Form1 formPrincipal)
        {
            InitializeComponent();
            this.formPrincipal = formPrincipal;
        }

        private void FormEdiProduto_Load(object sender, EventArgs e)
        {
            CarregarPagina();
        }

        public void CarregarPagina()
        {
            listViewProduto.Items.Clear();
            foreach (Produto produto in formPrincipal.Produtos)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(produto.Id));
                item.SubItems.Add(produto.Nome);
                item.SubItems.Add(Convert.ToString(produto.Preco));
                item.SubItems.Add(produto.Descricao);

                listViewProduto.Items.Add(item);
            }
        }

        private void listViewProduto_DoubleClick(object sender, EventArgs e)
        {
            int indiceProduto = Convert.ToInt32(listViewProduto.FocusedItem.Index);
            ProdSelecionado = formPrincipal.Produtos[indiceProduto];

            FormEdiProduto formEdiProduto = new FormEdiProduto(this.formPrincipal, this);
            formEdiProduto.ShowDialog();
        }
    }
}
