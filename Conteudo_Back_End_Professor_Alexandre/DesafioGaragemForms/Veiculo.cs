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
        double valorhora;
        int tempopermanenciaminuto;
        int tempopermanenciahora;


        /// <summary>
        /// Construtor para fazer as auterações na entrada do veiculo na garagem
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="dataentrada"></param>
        /// <param name="horaentrada"></param>
        /// <param name="valor"></param>
        public Veiculo(string placaveiculo, string dataentrada, string horaentrada, double valorhora)
        {
            this.Placaveiculo = placaveiculo;
            this.Dataentrada = dataentrada;
            this.Horaentrada = horaentrada;
            this.Valorhora = valorhora;
           

        }


        /// <summary>
        /// Construtor para fazer as auterações na saida do veiculo da garagem
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="tempopermanencia"></param>
        /// <param name="valorcobrado"></param>
        /// <param name="valorhora"></param>
        public Veiculo(string placaveiculo,string horasaida, string datasaida, int
            tempopermanenciaminuto, int tempopermanenciahora, double valorcobrado, double valorhora)
        {

            this.Placaveiculo = placaveiculo;
            this.Datasaida = datasaida;
            this.Horasaida = horasaida;
            this.Tempopermanenciaminuto = tempopermanenciaminuto;
            this.Tempopermanenciahora = tempopermanenciahora;
            this.Valorcobrado = valorcobrado;
            this.Valorhora = valorhora;



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
        public int Tempopermanenciaminuto  { get => tempopermanenciaminuto; set => tempopermanenciaminuto = value; }
        public int Tempopermanenciahora  { get => tempopermanenciaminuto; set => tempopermanenciahora = value; }
       

        public static string RetornaDatahoraE(string placaveiculo, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placaveiculo.Equals(placaveiculo))
                {
                    return i.Dataentrada + " - " + i.Horaentrada;
                }

            }
            return null;
        }

        public static double Retornavalorhora(string placa, List<Veiculo> lista)
        {
            foreach(Veiculo i in lista)
            {
                if (i.Placaveiculo.Equals(placa))
                {
                    return i.valorhora;
                }

            }
            return 0;
        }
    }
}
