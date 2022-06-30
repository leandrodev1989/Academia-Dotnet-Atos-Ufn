using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VendasProdutos.Model
{
    class Cliente
    {
        int idcliente;
        string cpf;
        string nome;
        string telefone;
        string email;


        /// <summary>
        /// Construtor responsavel por receber as  informações do cadastro dos clientes
        /// </summary>
        /// <param name="idcliente"></param>
        /// <param name="cpf"></param>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        public Cliente( int idcliente, string cpf, string nome, string telefone, string email)
        {
            this.IdCliente = idcliente;
            this.Cpf = cpf;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;

        }


        /// <summary>
        /// Construtor sem o id do cliente
        /// </summary>
        /// <param name="cpf"></param>
        /// <param name="nome"></param>
        /// <param name="telefone"></param>
        /// <param name="email"></param>
        public Cliente(string cpf, string nome, string telefone, string email)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Email = email;
        }

        public int IdCliente { get => idcliente; set => idcliente = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }


        /// <summary>
        /// Metodo responsavel por gravar no banco as informaões do cadastro do cliente
        /// </summary>
        /// <returns></returns>
        public bool gravarCliente()
        {
            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into clientes values (@cpf, @Nome, @telefone, @email);";
            command.Parameters.Add("@cpf", SqlDbType.VarChar);
            command.Parameters.Add("@nome", SqlDbType.VarChar);
            command.Parameters.Add("@telefone", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
            command.Parameters[0].Value = cpf;
            command.Parameters[1].Value = nome;
            command.Parameters[2].Value = telefone;
            command.Parameters[3].Value = email;
            

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
        /// Metodo para listar e gravar na lista as informaçês dos clientes a serem comsultada
        /// </summary>
        /// <returns></returns>
        public static List<Cliente> GerarLista()
        {
            List<Cliente> listaclientes = new List<Cliente>();


            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;


            command.CommandText = "select * from clientes order by idCliente;";




            try
            {
                SqlDataReader leitor = command.ExecuteReader();

                while (leitor.Read())
                {
                    listaclientes.Add(new Cliente(int.Parse(leitor["idCliente"].ToString()), leitor["cpf"].ToString(), leitor["nome"].ToString(),
                    leitor["telefone"].ToString(), leitor["email"].ToString()));
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
            return listaclientes;

        }
    }
}
