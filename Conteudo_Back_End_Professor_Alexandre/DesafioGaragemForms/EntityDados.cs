using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garagemteste
{
     class EntityDados
     {
        




        /// <summary>
        /// Metodo com o construtor para gravar no arquivo entrada
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void GravarNoarquivoEntrada(List<Veiculo> listaveiculos)
        {
              StreamWriter escritor = new StreamWriter("veiculosEntrada.txt");

                foreach (Veiculo i in listaveiculos)
                {
                    escritor.WriteLine(i.Placaveiculo + ";" + i.Dataentrada + ";" + i.Horaentrada);
                    escritor.Flush();


                }
               escritor.Close();                   
        }

     
        /// <summary>
        /// Metodo para Trazer do arquivo as informações e Popular a TexBox Lista de entrada na garagem
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void LerdoArquivoEntrada(List<Veiculo> listaveiculos)
        {
            StreamReader leitor; 
            string linha;
            string[] vetorDados;

            try
            {
                leitor = new StreamReader("veiculosEntrada.txt");

                do
                {
                    linha = leitor.ReadLine();
                    vetorDados = linha.Split(';');

                    listaveiculos.Add(new Veiculo(vetorDados[0], vetorDados[1], vetorDados[2]));
                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            catch(Exception e)
            {
                if(listaveiculos.Count == 0)
                {
                    MessageBox.Show("Estacionamento Vazio Continue Para Dar Entrada!");
                }
                    MessageBox.Show($"Continue Para Cadastrar Entrada na Garagem", "Alerta" );             
            }         
        }


        public static void GravarNoarquivoSaida(List<Veiculo> listaveiculos)
        {
            StreamWriter escritor = new StreamWriter("veiculosSaida.txt");

            foreach (Veiculo i in listaveiculos)
            {
                escritor.WriteLine(i.Placaveiculo + ";" + i.Datasaida + ";" + i.Horasaida + ";" 
                    + i.Tempopermanencia + ";" + i.Valorcobrado + ";" + i.Dataentrada + ";" + i.Horaentrada);
                escritor.Flush();


            }
            escritor.Close();
        }




        /// <summary>
        /// Metodo para ler os Dados para Popular a text box lista veiculos saida no arquivo e listaveiculosSaida
        /// </summary>
        /// <param name="listaveiculosSaida"></param>
        public static void LerdoArquivoSaida(List<Veiculo> listaveiculos)
        {
            StreamReader leitor2;
            string linha;
            string[] vetorDadosSaida;

            try
            {
                leitor2 = new StreamReader("veiculosSaida.txt");

                do
                {
                    linha = leitor2.ReadLine();
                    vetorDadosSaida = linha.Split(';');

                    listaveiculos.Add(new Veiculo(vetorDadosSaida[0], vetorDadosSaida[1], vetorDadosSaida[2], int.Parse(vetorDadosSaida[3]), 
                        double.Parse(vetorDadosSaida[4]), vetorDadosSaida[5], vetorDadosSaida[6]));
                } while (!leitor2.EndOfStream);

                leitor2.Close();
            }
            catch (Exception e)
            {
                if (listaveiculos.Count == 0)
                {
                    MessageBox.Show("Estacionamento Vazio Continue Para Dar Entrada!");
                }
                MessageBox.Show($"Continue Para Cadastrar Saida da Garagem", "Alerta");


            }
        }
     }
}
