using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendasProdutos.Model
{
    class Venda
    {
        /// <summary>
        /// atributos
        /// </summary>
        int iditemvenda;
        double valorunitario;
        int quantidade;
        int idproduto;
        double valortotalvenda;
        double valortotalitem;
        int idvenda;
        int idcliente;
       
       
        /// <summary>
        /// Construtos para retornar as informações dos dados passados
        /// </summary>
        /// <param name="iditemvenda"></param>
        /// <param name="valorunitario"></param>
        /// <param name="quantidade"></param>
        /// <param name="idproduto"></param>
        /// <param name="valortotalvenda"></param>
        /// <param name="valortotalitem"></param>
        /// <param name="idvenda"></param>
        /// <param name="idcliente"></param>
        public Venda(int iditemvenda, double valorunitario, int quantidade,int idproduto, double valortotalvenda,double valortotalitem,int idvenda, int idcliente)
        {

            this.Iditemvenda = iditemvenda;
            this.Valorunitario = valorunitario;
            this.Quantidade = quantidade;
            this.IdProduto = idproduto;

            this.Valortotalvenda = valortotalvenda;
            this.valortotalitem = valortotalitem;
            this.IdVenda = idvenda;
            this.IdCliente = idcliente;

        }


        /// <summary>
        /// Construtor só para a operação de venda
        /// </summary>
        /// <param name="valorunitario"></param>
        /// <param name="quantidade"></param>
        /// <param name="valortotalvenda"></param>
        public Venda(double valorunitario, int quantidade, double valortotalvenda)
        {
            this.Valorunitario = valorunitario;
            this.Quantidade = quantidade;
            this.Valortotalvenda = valortotalvenda;
        }

        /// <summary>
        /// construtor para a operação  que salva  o id da venda o id do cliente e o valor total
        /// </summary>
        /// <param name="valortotalvenda"></param>
        public Venda(double valortotalvenda)
        {
            
            this.Valortotalvenda = valortotalvenda;
        }


        /// <summary>
        /// Metodo para gravar no banco e salvar o valor total da venda
        /// </summary>
        /// <param name="valortotalvenda"></param>
        /// <returns></returns>
        public  bool gravarvenda(double valortotalvenda)
        {

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;


            command.CommandText = "Insert into vendas values  @valorTotal;";

           
            command.Parameters.Add("@valorTotal", SqlDbType.Real);

           
            command.Parameters[0].Value = valortotalvenda;
            

            try
            {
                command.ExecuteNonQuery();

                tran.Commit();
            }
            catch (Exception erro)
            {
                tran.Rollback();
          
                MessageBox.Show("erro ao  gravarItensVenda: " + erro);
               

            }

            finally
            {
                banco.fecharConexao();
            }
            return false;

        }



        /// <summary>
        /// Metodo para persistir na lista e guardar no carrinho os items adicionados na compra
        /// </summary>
        /// <param name="listaItensvenda"></param>
        /// <returns></returns>
        public bool gravarItensVenda(List<Venda> listaItensvenda)
        {

            foreach (Venda indice in listaItensvenda)
            {

                Banco banco = new Banco();
                SqlConnection cn = banco.abrirConexao();

                SqlTransaction tran = cn.BeginTransaction();
                SqlCommand command = new SqlCommand();

                command.Connection = cn;
                command.Transaction = tran;
                command.CommandType = CommandType.Text;


                command.CommandText = "Insert into itemVenda values (@idVenda, @idProduto, @valorUnitario, @quantidade, @valorTotal);";

                command.Parameters.Add("@idVenda", SqlDbType.Int);
                command.Parameters.Add("@idProduto", SqlDbType.Int);
                command.Parameters.Add("@valorUnitario", SqlDbType.Real);
                command.Parameters.Add("@quantidade", SqlDbType.Int);
                command.Parameters.Add("@valorTotal", SqlDbType.Real);


                command.Parameters[0].Value = this.IdVenda;
                command.Parameters[1].Value = indice.IdProduto;
                command.Parameters[2].Value = indice.Valorunitario;
                command.Parameters[3].Value = indice.Quantidade;
                command.Parameters[4].Value = indice.valortotalitem;

                try
                {
                    command.ExecuteNonQuery();

                    tran.Commit();
                }
                catch (Exception erro)
                {
                    tran.Rollback();

                   
                    MessageBox.Show("IdVenda: "+  this.IdVenda.ToString());
                    MessageBox.Show("erro gravarItensVenda: " + erro);

                }

                finally
                {
                    banco.fecharConexao();
                }

            }
         
            return true;

        }

       

        public int Iditemvenda { get => iditemvenda; set => iditemvenda = value; }
        public double Valorunitario { get => valorunitario; set => valorunitario = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public int IdProduto { get => idproduto; set => idproduto = value; }
        public double ValorTotalitem { get => valortotalitem; set => valortotalitem = value; }
        public double Valortotalvenda { get => valortotalvenda; set => valortotalvenda = value; }
        public int IdVenda { get => idvenda; set => idvenda = value; }
        public int IdCliente { get => idcliente; set => idcliente = value; }

    }
}
