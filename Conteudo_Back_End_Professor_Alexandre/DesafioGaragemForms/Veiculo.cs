using System;
using System.Collections.Generic;

namespace Garagemteste
{

    class Veiculo
    {

        /// <summary>
        /// Atributos para serem utilizado
        /// </summary>
        string  placaveiculo;
        string dataentrada;
        double valorcobrado;
        string horasaida;
        string datasaida;
        string horaentrada;
        double valorhora = 5.00;
        int tempopermanecia;
        


        /// <summary>
        /// Construtor para fazer as auterações na entrada do veiculo na garagem
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="dataentrada"></param>
        /// <param name="horaentrada"></param>
        /// <param name="valor"></param>
        public Veiculo(string placaveiculo, string dataentrada, string horaentrada)
        {
            this.Placaveiculo = placaveiculo;
            this.Dataentrada = dataentrada;
            this.Horaentrada = horaentrada;
            
          
        }

        public Veiculo(string plaveiculo, int tempopermanencia, double valorcobrado)
        {
            this.Placaveiculo = placaveiculo;
            this.Tempopermanencia = tempopermanencia;
            this.Valorcobrado = valorcobrado;

        }


        /// <summary>
        /// Construtor para fazer as auterações na saida do veiculo da garagem
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="tempopermanencia"></param>
        /// <param name="valorcobrado"></param>
        /// <param name="valorhora"></param>
        public Veiculo(string placaveiculo , string dataentrada, string horaentrada, int tempopermanencia,
            double valorcobrado)
        {

            this.Placaveiculo = placaveiculo;
            this.Dataentrada = dataentrada;
            this.Horaentrada = horaentrada;
            this.Tempopermanencia = tempopermanencia;
            this.Valorcobrado = valorcobrado;
           

        }

        public Veiculo(string placaveiculo)
        {
            this.Placaveiculo = placaveiculo;
        }

       
      


        /// <summary>
        /// Gets Sets dos atributos recebendo as informações no construtor
        /// </summary>
        public string Placaveiculo { get => placaveiculo; set => placaveiculo = value; }
        public string Dataentrada { get => dataentrada; set => dataentrada = value; }
        public string Datasaida { get => datasaida; set => datasaida = value; }
        public string Horaentrada { get => horaentrada; set => horaentrada = value; }
        public string Horasaida { get => horasaida; set => horasaida = value; }
        public double Valorcobrado { get => valorcobrado; set => valorcobrado = value; }
        public double Valorhora  { get => valorhora; set => valorhora = value; }
        public int Tempopermanencia  { get => tempopermanecia; set => tempopermanecia = value; }
       


        



        /// <summary>
        /// Metodo para Gerar data e hora
        /// </summary>
        /// <returns></returns>
        public static string GerarDH()
        {
            DateTime date = DateTime.Now;
            string dataformato = date.ToString("dd/MM/yyyy  HH:MMM:ss");
            string[] vetordados = dataformato.Split(' ');

            return vetordados[0];
        }


        /// <summary>
        /// Metodo para Retornar o Valor cobrado pelo o tempo do veiculo no estacionamento
        /// </summary>
        /// <param name="horasaida"></param>
        /// <param name="preco"></param>
        public void  RealizaCobranca( double valorhora)
        {
            try
            {
                string[] vetorcobranca = horaentrada.Split(':');
                int hora = int.Parse(vetorcobranca[0]);
                int minutos = int.Parse(vetorcobranca[1]);
                int entrada = hora * 60 + minutos;



                vetorcobranca = horasaida.Split(':');
                hora = int.Parse(vetorcobranca[0]);
                minutos = int.Parse(vetorcobranca[1]);
                int saida = hora * 60 + minutos;


                this.Tempopermanencia = saida - entrada;
                double cobranca = (double)this.Tempopermanencia / 60;
                int tempo = (int)Math.Ceiling(cobranca);
                this.Valorcobrado = tempo * valorhora;
            }
            catch (Exception ex)
            {
                
            }
            
           
        }


        public static bool Temvagas(List<Veiculo> lista, int tamanhogaragem)
        {
            

                if (lista.Count < tamanhogaragem)
                {
                    return true;

                }
                else
                {
                    return false;
                }  

        }


    }
}
