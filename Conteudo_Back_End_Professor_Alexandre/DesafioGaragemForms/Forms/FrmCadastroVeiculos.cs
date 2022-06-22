using Garagemteste.ConfigGaragem;
using Garagemteste.Util;
using System;
using System.Collections.Generic;
using System.IO;
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
                textBox_listaveiculosSaida.AppendText(i.Placaveiculo + "  -  "  + i.Datasaida + " - "  + tbhorasaida.Text + " - " + i.Horaentrada + " - "
                + i.Tempopermanencia + " Minutos " + i.Valorcobrado.ToString("c") + Environment.NewLine);
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
           
            
            PersistenciaDados.LerdoArquivoEntrada(listaEntrada);
            PopularListatextBoxListagaragem(listaEntrada);

            PersistenciaDados.LerdoArquivoSaida(listaSaida);
            PopularListatextBoxListaSaida(listaSaida);

            

            ConfigVaga configura = new ConfigVaga();
            configura.Lergravados();


            
            tbData.Text = DateTime.Now.ToShortDateString();
            tbHora.Text = DateTime.Now.ToShortTimeString();

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
           
            /// foi criada uma classe de Configuração para registrar a quntidade de vagas disponivel na garagem
            ConfigVaga configura = new ConfigVaga();
            configura.Lergravados();

            ///Verificar a hora de funcionamento
            Veiculo.Horafuncionamento(tbplaca.Text);


            ///Vefifica o tamanho de espaço na garagem
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

            ///validando a quantidade limite de de caracteres da placa
            if (tbplaca.Text.Length != 7 )
            {
                MessageBox.Show("É preciso digitar a Placa Com 7 Caracteres!", "Alerta");
                return;
            }

              
            //Alterando a fonta para Maiusculo
            tbplaca.Text = tbplaca.Text.ToUpper();

            //Verifica se o veiculo já foi Cadastrado
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
                listaEntrada.Add(new Veiculo(tbplaca.Text, dataentrada, horaentrada, configura.Valorhora));

                PersistenciaDados.GravarNoarquivoEntrada(listaEntrada);

                //Registra os dados na lista de arquivo fazendo o Append escrevendo uma linha abaixo da outra
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
                if (File.Exists("veiculosEntrada.dat"))
                {
                    using (StreamReader sr = File.OpenText("veiculosEntrada.dat"))
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
      
        /// <summary>
        /// Botão para fazer toda a logica de saida da garagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnsaida_Click(object sender, EventArgs e)
        {
            ConfigVaga configura = new ConfigVaga();
            configura.Lergravados();

            double valorhora = 5.00;
            
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

            
            /// verifica se tem algum veiculo na lista de entrada para sair
            int procuraveiculo = UtilVeiculo.Localizado(tbplaca.Text, listaEntrada);

            if (procuraveiculo == -27)
            {
                MessageBox.Show("Veiculo não estar na garagem", "Alerta");
                return;
            }
            else
            {
                
                /// criando e transferindo   da lista de entrada para uma lista temporaria
                Veiculo veiculoTP = listaEntrada[procuraveiculo];
                //Adiciona os Dados na Lista
               
                ///removendo da lista de entrada o veiculo encontrado
                listaEntrada.RemoveAt(procuraveiculo);

                /// realizando a cobrança do tempo que passou dentro da garagem
                veiculoTP.RealizaCobranca(tbhorasaida.Text, valorhora);

                ///Exibe o Relatorio de Saida
                veiculoTP.ExibirRelatorio();
               
                ///adicionando na lista  o veiculo atraves da lista temporaria
                listaSaida.Add(veiculoTP);

                ///atualiza a listbox de saida
                PopularListatextBoxListaSaida(listaSaida);

                
                ///grava no arquivo a lista atualizada
                PersistenciaDados.GravarNoarquivoSaida(listaSaida);
               

                ///atualiza a listbox de entrada
                PopularListatextBoxListagaragem(listaEntrada);

                ///grava no arquivo de entrada alista atualizada
                PersistenciaDados.GravarNoarquivoEntrada(listaEntrada);
            }

            ///limpa o textbox
            tbplaca.Text = "";
        }

        


        /// <summary>
        /// Botão pra atualizar na textbox os dados no arquivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlistarsaida_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica se o arquivo existe
                if (File.Exists("veiculosSaida.dat"))
                {
                    using (StreamReader sr = File.OpenText("veiculosSaida.dat"))
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

            ///limpa o textbox 
            tb_numerovagas.Text = "";
            tb_valorporhora.Text = "";
        }
    }
}
