using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VendasProdutos.Model;

namespace VendasProdutos
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }


        private void btnCadastrarproduto_Click(object sender, EventArgs e)
        {

            Produto produto = new Produto(tbxNomeProduto.Text, float.Parse(txbPrecoProduto.Text), int.Parse(tbxEstoque.Text));

            if (produto.Gravarproduto())
            {
                MessageBox.Show("Produto cadastrado com sucesso.");
            }
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendas_dbDataSet1.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.vendas_dbDataSet1.produtos);


        }
    }
}
