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
    public partial class FormCadCliente : Form
    {
        public FormCadCliente()
        {
            InitializeComponent();
        }

        private void FormCadCliente_Load(object sender, EventArgs e)
        {
            dateNascCliente.MaxDate = DateTime.Now.AddSeconds(1);
            dateNascCliente.Value = DateTime.Now;
        }

        private void btCancCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
