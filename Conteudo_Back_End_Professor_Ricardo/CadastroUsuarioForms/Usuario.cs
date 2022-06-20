using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CadastroUsuarioForms
{
    internal class Usuario
    {
        int idusuario;
        string nomecompleto;
        string email;


        public Usuario(int idusuario, string nomecompleto)
        {
            this.IdUsuario = idusuario;
            this.Nomecompleto = nomecompleto;
            GerarEmail(nomecompleto);

        }

      

        public int IdUsuario { get  => idusuario; set => idusuario = value; }
        public string Nomecompleto { get => nomecompleto; set => nomecompleto = value; }
        public string Email { get => email; set => email= value; }


        public bool gravarPessoa()
        {
        //    int IdUsuario = Convert.ToInt16(textBox_idusuario.Text);
        //    string nomecompleto = textBox_nomecompleto.Text;
        //    string email = textBoxemail.Text;

            Banco banco = new Banco();
            SqlConnection cn = banco.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = CommandType.Text;
            command.CommandText = "insert into usuario values (@IdUsuario, @nomecompleto, @email);";
            command.Parameters.Add("@IdUsuario", SqlDbType.Int);
            command.Parameters.Add("@nomecompleto", SqlDbType.VarChar);
            command.Parameters.Add("@email", SqlDbType.VarChar);
          
            command.Parameters[0].Value = this.idusuario;
            command.Parameters[1].Value = this.nomecompleto ;
            command.Parameters[2].Value = this.email;

           
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

        public void Cadastrar()
        {
            //SqlConnection conexao = new SqlConnection(conexaoString);
            //conexao.Open();
            //try
            //{
            //    //capturar valores das variáveis
            //    int idMedidaGlicemia = int.Parse(textboxid_Gicemia.Text);
            //    int valorGlicemia = int.Parse(textboxvalor_Glicemia.Text);
            //    string dataMedida = textboxdata_Medicao.Text;
            //    int idPaciente = int.Parse(textboxid_Paciente.Text);

            //    //gerar sentenças SQL
            //    string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
            //    SqlCommand comando = new SqlCommand(sqlTexto, conexao);
            //    comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
            //    comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
            //    comando.Parameters.AddWithValue("@dataMedida", dataMedida);
            //    comando.Parameters.AddWithValue("@idPaciente", idPaciente);

            //    //executar sentença SQL
            //    comando.ExecuteNonQuery();
            //}
            //catch (Exception erro)
            //{
            //}

            //conexao.Close();

            ////recarregar ListView
            //carregarListView();
            //limparTextBox();
        }

        private void  GerarEmail(string nomecompleto)
        {
            string[] vetorNome =  nomecompleto.ToLower().Split(' ');
           
            this.email = vetorNome[0] + "." + vetorNome[vetorNome.Length - 1] + "@ufn.edu.br";
            this.email = email;

        }
            
    }
}
