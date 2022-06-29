using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VendasProdutos.Model;

namespace VendasProdutos
{
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();
        }


        int quantidade;
        double valorunitario;
        double valorvenda;
        double operacao;

        List<Produto> listaprodutos = new List<Produto>();

        List<Venda> listavendas = new List<Venda>();

        List<Cliente> listaclientes = new List<Cliente>();

        /// <summary>
        /// Metodo para exibir os clientes na lista
        /// </summary>
        private void exibirClientes()
        {
            if(cbClienteCadastrado == null)
            {
                MessageBox.Show("Campo não pode ser vazio");
                return;
            }
            
            
                listaclientes = Cliente.GerarLista();
                cbClienteCadastrado.Items.Clear();
                foreach (Cliente i in listaclientes)
                {
                    cbClienteCadastrado.Items.Add(i.Nome);
                }
            
           

        }


        /// <summary>
        /// metodo para exibir os produtos na lista
        /// </summary>
        private void exibirProdutos()
        {
            if(cbProdutoCadastrado == null)
            {
                MessageBox.Show("Campo não pode ser vazio");
                return;
            }
            
           
                listaprodutos = Produto.Gerarproduto();

                cbProdutoCadastrado.Items.Clear();

                foreach (Produto indice in listaprodutos)
                {
                    cbProdutoCadastrado.Items.Add(indice.Nome);
                }
           
            
        }


        /// <summary>
        /// Metodo para exibir o valor unitario
        /// </summary>
        private void exibirvalorunitario()
        {
            if(cbvalorunitario == null)
            {
                MessageBox.Show("Campo não pode ser vazio");
                return;
            }
            
           
                listaprodutos = Produto.Gerarproduto();
                cbvalorunitario.Items.Clear();

                foreach (Produto i in listaprodutos)
                {
                    cbvalorunitario.Items.Add(i.Preco);
                }
           
            
        }



        private void FormVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendas_dbDataSet9.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter1.Fill(this.vendas_dbDataSet9.produtos);
            // TODO: This line of code loads data into the 'vendas_dbDataSet6.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.vendas_dbDataSet6.vendas);
            // TODO: This line of code loads data into the 'vendas_dbDataSet5.itemVenda' table. You can move, or remove it, as needed.
            this.itemVendaTableAdapter.Fill(this.vendas_dbDataSet5.itemVenda);
            // TODO: This line of code loads data into the 'vendas_dbDataSet4.produtos' table. You can move, or remove it, as needed.
            this.produtosTableAdapter.Fill(this.vendas_dbDataSet4.produtos);

            exibirClientes();
            exibirProdutos();
            exibirvalorunitario();
        }


        /// <summary>
        /// Realiza o calculo para o cliente adiconar os produtos no carrinho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnrealizavenda_Click(object sender, EventArgs e)
        {
            
            string idvenda = Guid.NewGuid().ToString().Substring(1, 10);
            int quantidade = int.Parse(cbQuantidade.Text);
            double valorunitario = double.Parse(cbvalorunitario.Text);

            double Operacao = quantidade * valorunitario;


            valorvenda = valorvenda + Operacao;

            

            listavendas.Add(new Venda(valorunitario, quantidade, Operacao));

            listViewCarrinho.Items.Add("ID VENDA: " + idvenda); 
            listViewCarrinho.Items.Add("QUANTIDADE:  " + quantidade.ToString());
            listViewCarrinho.Items.Add("VALOR UNIT:  " + valorunitario.ToString("C"));
            listViewCarrinho.Items.Add("NOME CLIENTE:  " +  cbClienteCadastrado.Text);
            listViewCarrinho.Items.Add("DESCRIÇÃO:  " +  cbProdutoCadastrado.Text);
            listViewCarrinho.Items.Add("VALOR TOTAL:  " + valorvenda.ToString("C"));

            tbvalortotal.Text = valorvenda.ToString("C");

        }


        /// <summary>
        /// Metodo para confirmar a venda dos produtos no carrinho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           

            Venda venda = new Venda(double.Parse(valorvenda.ToString()));

            if (venda.gravarvenda( valorvenda))
            { 
               

                if (venda.gravarItensVenda(listavendas))
                {
                    
                    exibirProdutos(); 
                    MessageBox.Show("Venda cadastrada com sucesso.", "Vendas");
                }
            }
        }
    }
}
