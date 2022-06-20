using Garagemteste.ConfigGaragem;
using Garagemteste.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagemteste
{
    public partial class FrmCadastroVeiculos : Form
    {
        
          static  List<Veiculo> listaEntrada = new List<Veiculo>();
          static List<Veiculo> listaSaida = new List<Veiculo>();

       

        /// <summary>
        /// Metodo para popular a list box de Saida
        /// </summary>
        /// <param name="listaveiculos"></param>
        private void PopularListatextBoxListaSaida(List<Veiculo> listaveiculos)
        {
            textBox_listaveiculosSaida.Text = "";
            foreach (Veiculo i in listaveiculos)
            {
                textBox_listaveiculosSaida.AppendText(i.Placaveiculo + "  -  " + i.Datasaida + " - " + i.Horasaida + " - "
                + i.Tempopermanencia+ "horas " + i.Valorcobrado.ToString("c") + Environment.NewLine);
            }
        }


        /// <summary>
        /// Metodo para Popular a text box lista veiculos entrada
        /// </summary>
        /// <param name="listaveiculosEntrada"></param>
        private void PopularListatextBoxListagaragem(List<Veiculo> listaveiculos)
        {
            textBox_listaVeiculosEntrada.Text = "";
            foreach (Veiculo i in listaveiculos)
            {
                textBox_listaVeiculosEntrada.AppendText(i.Placaveiculo + "   -   " + i.Dataentrada + "  -  " + i.Horaentrada +
                " - " + i.Valorhora.ToString("C") + Environment.NewLine);
            }
        }

        public FrmCadastroVeiculos()
        {
            InitializeComponent();
           
            
            EntityDados.LerdoArquivoEntrada(listaEntrada);
            PopularListatextBoxListagaragem(listaEntrada);

            EntityDados.LerdoArquivoSaida(listaSaida);
            PopularListatextBoxListaSaida(listaSaida);

            

            ConfigVaga configura = new ConfigVaga();
            configura.Lergravados();

            DateTime data = DateTime.Now;
            tbData.Text = data.ToShortDateString();
            tbHora.Text = data.ToShortTimeString();

            tbvagas.Text = configura.Tamanhogaragem.ToString();
            tbvalor.Text = configura.Valorhora.ToString("C");

        }


        /// <summary>
        /// Botão para fechar a plicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncadastrar_Click(object sender, EventArgs e)
        {
           

            ConfigVaga configura = new ConfigVaga();
            configura.Lergravados();
            if (listaEntrada.Count >= configura.Tamanhogaragem)
            {
                MessageBox.Show("A garagem está cheia. \nNão há vagas disponíveis", "Lotação");
                return;
            }

            // Validando o campo para que não fique vazio
            if (tbplaca.Text.Equals(""))
            {
                MessageBox.Show("É preciso digitar a Placa e escolher uma opção!", "Alerta");
                return;
            }

            if (tbplaca.Text.Length != 7 )
            {
                MessageBox.Show("É preciso digitar a Placa Com 7 Caracteres!", "Alerta");
                return;
            }

              
            //Alterando a fonta para Maiusculo
            tbplaca.Text = tbplaca.Text.ToUpper();

            //gravar na lista desde que não estave na lista
            if (UtilVeiculo.jacdastrado(tbplaca.Text, listaEntrada))
            {
                MessageBox.Show("Veiculo já Cadastrado!", "Alerta");
            }
            else
            {

                DateTime data = DateTime.Now;
                string dataentrada = data.ToShortDateString();
                string horaentrada = data.ToShortTimeString();

                Veiculo.GerarDH();

                //Adiciona os Dados na Lista
                listaEntrada.Add(new Veiculo(tbplaca.Text, dataentrada, horaentrada));

                EntityDados.GravarNoarquivoEntrada(listaEntrada);

                //escreve os dados na lista e arquivo fazendo o append escrevendo um em baixo do outro
                textBox_listaVeiculosEntrada.AppendText(tbplaca.Text + " - " + dataentrada + " - "
                + horaentrada + " - "  + configura.Valorhora  + Environment.NewLine);

             
                tbplaca.Text = "";
              

              
            }
        }


       

        /// <summary>
        /// Função para exibir na tela os os dados escritos no arquivo de Entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListarEntrada_Click(object sender, EventArgs e)
        {

            if (listaEntrada.Count == 0 )
            {
               
                MessageBox.Show("Garagem Vazia!", "Alerta!");
            }
            else if(listaEntrada.Count >= 1)
            {
                
            }
            


            try
            {

                //Verifica se o arquivo existe
                if (File.Exists("veiculosEntrada.txt"))
                {
                    using (StreamReader sr = File.OpenText("veiculosEntrada.txt"))
                    {
                        textBox_listaVeiculosEntrada.Text = sr.ReadToEnd();
                    }

                }
                else
                {
                    MessageBox.Show("O Arquivo Não Foi Localizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado!\n\n" + ex.Message);

            }


        }

      

        private void btnsaida_Click(object sender, EventArgs e)
        {
            

            //Alterando a fonta para Maiusculo
            tbplaca.Text = tbplaca.Text.ToUpper();


            // Validando o campo para que não fique vazio
            if (tbplaca.Text.Equals(""))
            {
                MessageBox.Show("É preciso digitar a Placa e escolher uma opção!", "Alerta");
                return;
            }

            if (tbplaca.Text.Length != 7)
            {
                MessageBox.Show("É preciso digitar a Placa Com 7 Caracteres!", "Alerta");
                return;
            }


            int procuraveiculo = UtilVeiculo.Localizado(tbplaca.Text, listaEntrada);

            if (procuraveiculo == -27)
            {
                MessageBox.Show("Veiculo não estar na garagem", "Alerta");
                return;
            }

            

           

            Veiculo veiculoTP = listaEntrada[procuraveiculo];
         
            veiculoTP.RealizaCobranca(5);

            listaSaida.Add(veiculoTP);
            Veiculo.GerarDH();
            EntityDados.GravarNoarquivoSaida(listaSaida);
            PopularListatextBoxListaSaida(listaSaida);

            listaEntrada.RemoveAt(procuraveiculo);
            EntityDados.GravarNoarquivoEntrada(listaEntrada);

            Saidagaragem();
            

            tbplaca.Text = "";
        }

        private void Saidagaragem()
        {

        }

        private void btnlistarsaida_Click(object sender, EventArgs e)
        {

            try
            {

                //Verifica se o arquivo existe
                if (File.Exists("veiculosSaida.txt"))
                {
                    using (StreamReader sr = File.OpenText("veiculosSaida.txt"))
                    {
                         textBox_listaveiculosSaida.Text = sr.ReadToEnd();
                    }

                }
                else
                {
                    MessageBox.Show("O Arquivo Não Foi Localizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado!\n\n" + ex.Message);

            }
        }

        /// <summary>
        /// Metodo que Confirmar a quantidade de vagas para o estacionamento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            bool confirmarvaga = true;

            if(tb_numerovagas.Text.Equals("") && tb_valorporhora.Text.Equals(""))
            {
                MessageBox.Show("Os Campos Numero de vagas e valor hora não podem ser vazios", "alerta");
                confirmarvaga = false;
                return;
            }
            if(confirmarvaga)
            {

                ConfigVaga configurar = new ConfigVaga(int.Parse(tb_numerovagas.Text), double.Parse(tb_valorporhora.Text));
                configurar.GravarVagas();

            }

            tb_numerovagas.Text = "";
            tb_valorporhora.Text = "";
        }
    }
}
