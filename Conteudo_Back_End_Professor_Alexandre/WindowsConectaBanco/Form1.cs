using Microsoft.Data.SqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace WindowsConectaBanco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private string conexaoString = ConfigurationManager.ConnectionStrings["GlicemiaDBString"].ConnectionString;

        private void limparTextBox()
        {
            textboxid_Gicemia.Text = "";
            textboxvalor_Glicemia.Text = "";
            textboxdata_Medicao.Text = "";
            textboxid_Paciente.Text = "";
        }
        private void carregarListView()
        {
            SqlConnection conexao = new SqlConnection(conexaoString);

            try
            {
                conexao.Open();

                string sqlTexto = "SELECT [MedidaGlicemia].idMedidaGlicemia, [MedidaGlicemia].valorGlicemia, [MedidaGlicemia].dataMedida, [MedidaGlicemia].idPaciente FROM MedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                medidasglicemia.Items.Clear();
                SqlDataReader leitor = comando.ExecuteReader();
                int i = 0;
                while (leitor.Read())
                {
                    medidasglicemia.Items.Add(leitor["idMedidaGlicemia"].ToString());
                    medidasglicemia.Items[i].SubItems.Add(leitor["valorGlicemia"].ToString());
                    medidasglicemia.Items[i].SubItems.Add(leitor["dataMedida"].ToString());
                    medidasglicemia.Items[i].SubItems.Add(leitor["idPaciente"].ToString());
                    i++;
                }

                conexao.Close();
                buttonconectar.Enabled = false;
                MessageBox.Show("Banco conectado com sucesso!", "Atenção");
            }
            catch (Exception)
            {
                MessageBox.Show("Problema de Conexão com o BD", "Alerta");
            }

           
        }
        

        private void buttonconectar_Click(object sender, System.EventArgs e)
        {

            carregarListView();
        }



        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //capturar valores das variáveis
                int idMedidaGlicemia = int.Parse(textboxid_Gicemia.Text);
                int valorGlicemia = int.Parse(textboxvalor_Glicemia.Text);
                string dataMedida = textboxdata_Medicao.Text;
                int idPaciente = int.Parse(textboxid_Paciente.Text);

                //gerar sentenças SQL
                string sqlTexto = "INSERT INTO MedidaGlicemia (idMedidaGlicemia, valorGlicemia, dataMedida, idPaciente) VALUES(@idMedidaGlicemia, @valorGlicemia, @dataMedida, @idPaciente)";
                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);
                comando.Parameters.AddWithValue("@valorGlicemia", valorGlicemia);
                comando.Parameters.AddWithValue("@dataMedida", dataMedida);
                comando.Parameters.AddWithValue("@idPaciente", idPaciente);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
            }

            conexao.Close();

            //recarregar ListView
            carregarListView();
            limparTextBox();
           
            
        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection(conexaoString);
            conexao.Open();
            try
            {
                //MessageBox.Show(listView_medidasGlicemias.SelectedItems[0].Text);
                int idMedidaGlicemia = int.Parse(medidasglicemia.SelectedItems[0].Text);

                //gerar sentenças SQL
                string sqlTexto = "DELETE FROM MedidaGlicemia WHERE idMedidaGlicemia = @idMedidaGlicemia";

                SqlCommand comando = new SqlCommand(sqlTexto, conexao);
                comando.Parameters.AddWithValue("@idMedidaGlicemia", idMedidaGlicemia);

                //executar sentença SQL
                comando.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


            conexao.Close();

            //recarregar ListView
            carregarListView();
        }
    }
}
