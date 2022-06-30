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
    class Produto
    {
        
        string codean;
        string nome;
        float preco;
        int estoque;

        /// <summary>
        /// Construtor que recebe a informaões do cadastro do produto
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="preco"></param>
        /// <param name="estoque"></param>
        public Produto( string nome, float preco, int estoque)
        {
            
            this.CodEan = Guid.NewGuid().ToString().Substring(1, 10);
            this.Nome = nome;
            this.Preco = preco;
            this.Estoque = estoque;
        }

        public Produto()
        {
           
        }

   


        /// <summary>
        /// Metodo para gravar no banco de dados o cadstro do produto
        /// </summary>
        /// <returns></returns>
        public   bool Gravarproduto()
        {
            

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into produtos values (@CodEAN, @nome, @preco, @estoque);";
            command.Parameters.Add("@CodEAN", SqlDbType.VarChar);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@preco", SqlDbType.Real);
            command.Parameters.Add("@estoque", SqlDbType.Int);
            command.Parameters[0].Value = CodEan;
            command.Parameters[1].Value = Nome;
            command.Parameters[2].Value = Preco;
            command.Parameters[3].Value = Estoque;


            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }


        /// <summary>
        /// Metodo para gravar na lista o produto ordenado por nome
        /// </summary>
        /// <returns></returns>
        public static List<Produto> Gerarproduto()
        {
            List<Produto> listaprodutos = new List<Produto>();
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;


            command.CommandText = "select * from produtos order by nome;";




            try
            {
                SqlDataReader leitorprodutos = command.ExecuteReader();

                while (leitorprodutos.Read())
                {
                    listaprodutos.Add(new Produto(leitorprodutos["nome"].ToString(),
                    float.Parse(leitorprodutos["preco"].ToString()), int.Parse(leitorprodutos["estoque"].ToString())));
                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                banco.fecharConexao();
            }
            return listaprodutos;
        }




        //public int IdProduto { get => idproduto; set => idproduto = value; }
        public string CodEan { get => codean; set => codean = value; }
        public string Nome { get => nome; set => nome = value; }
        public float Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }


    }
}
