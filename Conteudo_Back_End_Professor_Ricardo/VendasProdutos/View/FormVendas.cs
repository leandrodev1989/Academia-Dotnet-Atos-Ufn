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
        float valortotalvenda;
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
                    cbClienteCadastrado.Items.Add(i.IdCliente);
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
            // TODO: This line of code loads data into the 'vendas_dbDataSet2.vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.Fill(this.vendas_dbDataSet2.vendas);


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
            float valorunitario = float.Parse(cbvalorunitario.Text);

            float Operacao = quantidade * valorunitario;


            valortotalvenda = valortotalvenda + Operacao;

            

            listavendas.Add(new Venda(valorunitario, quantidade, Operacao));

            listViewCarrinho.Items.Add("ID VENDA: " + idvenda); 
            listViewCarrinho.Items.Add("QUANTIDADE:  " + quantidade.ToString());
            listViewCarrinho.Items.Add("VALOR UNIT:  " + valorunitario.ToString("C"));
            listViewCarrinho.Items.Add("ID CLIENTE:  " +  cbClienteCadastrado.Text);
            listViewCarrinho.Items.Add("DESCRIÇÃO:  " +  cbProdutoCadastrado.Text);
            listViewCarrinho.Items.Add("VALOR TOTAL:  " + valortotalvenda.ToString("C"));

            tbvalortotal.Text = valortotalvenda.ToString("C");

        }


        /// <summary>
        /// Metodo para confirmar a venda dos produtos no carrinho
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int.Parse(cbClienteCadastrado.Text);
            string idvenda = Guid.NewGuid().ToString().Substring(1, 10);

            Venda venda = new Venda(int.Parse(idvenda), int.Parse(cbClienteCadastrado.Text),float.Parse(tbvalortotal.Text));

            if(venda.gravarvenda(int.Parse(idvenda), cbClienteCadastrado.Text, float.Parse(tbvalortotal.Text)))
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
