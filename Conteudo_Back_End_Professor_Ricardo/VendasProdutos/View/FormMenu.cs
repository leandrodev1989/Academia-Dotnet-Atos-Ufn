using System;
using System.Windows.Forms;

namespace VendasProdutos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cADASTRODECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroClientes cadastro = new FormCadastroClientes();
            cadastro.ShowDialog();
        }

        private void cADASTRODEPRODUTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroProduto produto = new FormCadastroProduto();
            produto.ShowDialog();
        }

        private void vENDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVendas venda = new FormVendas();
            venda.ShowDialog();
        }

       
    }
}
