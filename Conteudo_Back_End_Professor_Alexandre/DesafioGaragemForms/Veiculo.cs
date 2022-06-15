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
        DateTime dataentrada;
        TimeSpan tempopermanencia;
        double valorcobrado;
        DateTime horasaida;
        DateTime datasaida;
        DateTime horaentrada;



        /// <summary>
        /// Construtor para fazer as auterações na entrada do veiculo na garagem
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="dataentrada"></param>
        /// <param name="horaentrada"></param>
        public Veiculo(string placaveiculo, DateTime dataentrada, DateTime horaentrada)
        {
            this.Placaveiculo = placaveiculo;
            this.Dataentrada = dataentrada;
            this.Horaentrada = horaentrada;
           

        }


        /// <summary>
        /// Construtor para fazer as auterações na saida do veiculo da garagem
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="tempopermanencia"></param>
        /// <param name="valorcobrado"></param>
        public Veiculo(string placaveiculo, TimeSpan tempopermanencia, double valorcobrado)
        {
            this.Placaveiculo = placaveiculo;
            this.Tempopermanencia = tempopermanencia;
            this.Valorcobrado = valorcobrado;

        }


        /// <summary>
        /// Gets Sets dos atributos recebendo as informações no construtor
        /// </summary>
        public string Placaveiculo { get => placaveiculo; set => placaveiculo = value; }
        public DateTime Dataentrada { get => dataentrada; set => dataentrada = value; }
        public DateTime Datasaida { get => datasaida; set => datasaida = value; }
        public DateTime Horaentrada { get => horaentrada; set => horaentrada = value; }
        public DateTime Horasaida { get => horasaida; set => horasaida = value; }
        public double Valorcobrado { get => valorcobrado; set => valorcobrado = value; }
        public TimeSpan Tempopermanencia { get => tempopermanencia; set => tempopermanencia = value; }




        //public void Gerardatahora( string tipo)
        //{
        //    DateTime datetime = DateTime.Now;
        //    string[] vetorDados = datetime.ToString().Split(' ');

        //    switch (tipo)
        //    {
        //        case "entrada":
        //            this.dataentrada = vetorDados[0];
        //            this.horaentrada = vetorDados[1];
        //            break;

        //    }

        //}

       



       




    }
}
