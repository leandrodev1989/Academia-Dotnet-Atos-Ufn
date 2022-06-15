using System;
using System.Collections.Generic;
using System.IO;
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
        /// Referenciando o construtor para para dar entrada na garagem
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void LerdoArquivoEntrada(List<Veiculo> listaveiculos)
        {
            StreamReader leitor; 
            string linha;
            string[] vetorDados;

            if (File.Exists("veiculosEntrada.txt"))
            {
                leitor = new StreamReader("veiculosEntrada.txt");
                do
                {
                    linha = leitor.ReadLine();
                    if (linha != null)
                    {
                        vetorDados = linha.Split(';');

                        listaveiculos.Add(new Veiculo(vetorDados[0], Convert.ToDateTime(vetorDados[1]), 
                        Convert.ToDateTime(vetorDados[2])));
                    }

                } while (!leitor.EndOfStream);

                leitor.Close();
            }
            else
            {
               
            }                                
        }

        /// <summary>
        /// Metodo Para gravar no arquivo de Saida Referenciando o construtor para realizar a cobrança
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void GravarNoarquivoSaida(List<Veiculo> listaveiculos)
        {
            StreamWriter escritor = new StreamWriter("veiculosSaida.txt");

            foreach (Veiculo i in listaveiculos)
            {
                escritor.WriteLine(i.Placaveiculo + ";" + i.Tempopermanencia + ";" + i.Valorcobrado);
                escritor.Flush();
            }
            escritor.Close();
        }




        /// <summary>
        /// Metodo para ler os Dados para Popular a text box lista veiculos Saindo da garagem
        /// </summary>
        /// <param name="listaveiculosSaida"></param>
        public static void LerdoArquivoSaida(List<Veiculo> listaveiculos)
        {
            StreamReader leitor2;
            string linha;
            string[] vetorDadosSaida;

            if (File.Exists("veiculosSaida.txt"))
            {
                leitor2 = new StreamReader("veiculosSaida.txt");
                do
                {
                     linha = leitor2.ReadLine();
                    if(linha != null)
                    {
                        vetorDadosSaida = linha.Split(';');

                        listaveiculos.Add(new Veiculo(vetorDadosSaida[0], TimeSpan.Parse(vetorDadosSaida[1]),
                        Convert.ToDouble(vetorDadosSaida[2])));
                    }             
                } while (!leitor2.EndOfStream);
            }
            else
            {
               
            }
                       
        }
     }
}
