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
        /// Metodo para confirmar a venda dos produtos no carrinho na listview
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
                    
<<<<<<< HEAD
                    exibirProdutos();
=======
                    exibirProdutos(); 
>>>>>>> d6372789f30cbe42556c1da3879cc758c8c62efb
                    MessageBox.Show("Venda cadastrada com sucesso.", "Vendas");
                }
            }
        }



        ///pesquisa o produto pelo Id
         private void btnpesquisar_Click(object sender, EventArgs e)
        {
            tbBuscarId.Focus();
            strSql = "select * from Produtos where Id=@Id";

            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = tbBuscarId.Text;

            try
            {
                if(tbBuscarId.Text == string.Empty)
                {
                    throw new Exception("Voçê precisa Digitar um Id");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                if(dr.HasRows == false)
                {
                    throw new Exception("Id não Cadastrado");
                }

                dr.Read();

                tbid.Text = Convert.ToString(dr["Id"]);
                tbcodean.Text = Convert.ToString(dr["codEAN"]);
                tbnome.Text = Convert.ToString(dr["nome"]);
                tbpreco.Text = Convert.ToString(dr["precoUnitario"]);
                tbestoque.Text = Convert.ToString(dr["estoque"]);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }



        }
         

         ///faz alteração nos produtos
        private void btnalterar_Click(object sender, EventArgs e)
        {
            strSql = "update Produtos set Id=@Id, codEAN=@codEAN, nome=@nome, precoUnitario=@precoUnitario, estoque=@estoque where Id=@IdBuscar";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value =  tbBuscarId.Text;

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = tbid.Text;
            comando.Parameters.Add("@codEAN", SqlDbType.Char).Value = tbcodean.Text;
            comando.Parameters.Add("@nome", SqlDbType.Char).Value = tbnome.Text;
            comando.Parameters.Add("@precoUnitario", SqlDbType.Float).Value = tbpreco.Text;
            comando.Parameters.Add("@estoque", SqlDbType.Int).Value = tbestoque.Text;


            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro Atualizado");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        

        ///excluir caso o usuario queira
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja Realmente Excluir Esse Produto?", "Cuidado", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                MessageBox.Show("Operação Cancelada");
            }
            else
            {
                strSql = "delete from Produtos where Id=@Id";
                sqlCon = new SqlConnection(strCon);
                SqlCommand comando = new SqlCommand(strSql, sqlCon);

                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tbBuscarId.Text;

                try
                {
                    sqlCon.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Produto Deletado");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    sqlCon.Close();
                }

            }
                    
        }

        float total ;

        ///adiciona produtos do estoque para ser vendido no carrinho
        private void btncarrinho_Click(object sender, EventArgs e)
        {
            if(tbquantidade.Text == string.Empty)
            {
                MessageBox.Show("Voçê precisa digitar uma quantidade") ;
            }
            else
            {
                List<Produtos> list = new List<Produtos>();

                foreach(DataGridViewRow row in dgvprodutos.Rows)
                {
                    Produtos pro = new Produtos();

                    pro.Id = (int)row.Cells["Id"].Value;
                    pro.Codean = row.Cells["Codean"].Value.ToString();
                    pro.Name = row.Cells["Nome"].Value.ToString();
                    pro.Precounitario = float.Parse(row.Cells["PrecoUnitario"].Value.ToString());
                    pro.Estoque = (int)row.Cells["Estoque"].Value;

                    list.Add(pro);


                }

                Produtos p = new Produtos();
                p.Id = int.Parse(tbid.Text);
                p.Codean = tbcodean.Text;
                p.Name = tbnome.Text;
                p.Precounitario = float.Parse(tbpreco.Text);
                p.Estoque = int.Parse(tbestoque.Text);

                int quantidade = int.Parse(tbquantidade.Text);
                float precounitario = float.Parse(tbpreco.Text);

                total = total + (precounitario * quantidade);

                lbltotal.Text = total.ToString("C");

                list.Add(p);
                dgvprodutos.DataSource = list;

                
            }
        }

        float troco;
        
        ///responsavel por finalizar a compra adicionada no carrinho
        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand("select * from Produtos where Id=@IdBuscar", sqlCon);
            comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value = tbBuscarId.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();

                float dinheiro = float.Parse(tbdinheiro.Text);
                troco = dinheiro - total;
                lbltroco.Text = troco.ToString("C");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                Pesquisar();
            }
            Atualizar();
        }

        ///pesquisa o produto pelo Id
        public void Pesquisar()
        {
            strSql = "select * from Produtos where Id=@Id";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Id", SqlDbType.Int).Value = tbBuscarId.Text;

            try
            {
                if(int.Parse(tbestoque.Text) == 0)
                {
                    throw new Exception("Descupa, produto indisponivel");
                }

                sqlCon.Open();

                SqlDataReader dr = comando.ExecuteReader();

                dr.Read();



                tbid.Text = Convert.ToString(dr["Id"]);
                tbcodean.Text = Convert.ToString(dr["codEAN"]);
                tbnome.Text = Convert.ToString(dr["nome"]);
                tbpreco.Text = Convert.ToString(dr["precoUnitario"]);
                tbestoque.Text = Convert.ToString(dr["estoque"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        ///atualiza o estoque apos a venda
        public void Atualizar()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand("update Produtos set estoque = estoque-'" + tbquantidade.Text + "' where Id=@IdBuscar", sqlCon);

            comando.Parameters.Add("@IdBuscar", SqlDbType.Int).Value = tbBuscarId.Text;

            try
            {

                sqlCon.Open();
                comando.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                Pesquisar();
            }
        }
    }
}
