using System;
using System.Collections.Generic;

namespace Garagemteste
{

    class Veiculo
    {

        /// <summary>
        /// Atributos para serem utilizado
        /// </summary>
        string placaveiculo;
        string dataentrada;
        int tempopermanencia;
        double valorcobrado;
        string horasaida;
        string datasaida;
        string horaentrada;


        /// <summary>
        /// Construtor dos atributos utilizado na leitura do arquivo para popular a lista
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="datahoraentrada"></param>
        /// <param name="tempopermanencia"></param>
        /// <param name="valorcobrado"></param>
        public Veiculo(string placaveiculo, string dataentrada, string horaentrada)
        {
            this.Placaveiculo = placaveiculo;
            this.Dataentrada = dataentrada;
            this.Horaentrada = horaentrada;
           

        }

        public Veiculo(string placaveiculo, string datasaida, string horasaida, int tempopermanencia, 
            double valorcobrado, string dataentrada, string horaentrada)
        {
            this.Placaveiculo = placaveiculo;
            this.Datasaida = datasaida;
            this.Horasaida = horasaida;
            this.Tempopermanencia = tempopermanencia;
            this.Valorcobrado = valorcobrado;
            this.Dataentrada = dataentrada;
            this.Horaentrada = horaentrada;

        }










        public void Gerardatahora( string tipo)
        {
            DateTime datetime = DateTime.Now;
            string[] vetorDados = datetime.ToString().Split(' ');

            switch (tipo)
            {
                case "entrada":
                    this.dataentrada = vetorDados[0];
                    this.horaentrada = vetorDados[1];
                    break;

            }

        }

       

        public Veiculo(string placa)
        {
            this.Placaveiculo = placa;
          
        }


        /// <summary>
        /// 
        /// </summary>
        public string Placaveiculo { get => placaveiculo; set => placaveiculo = value; }
        public string Dataentrada { get => dataentrada; set => dataentrada = value; }
        public string Datasaida { get => datasaida; set => datasaida = value; }
        public string Horaentrada { get => horaentrada; set => horaentrada = value; }
        public string Horasaida { get => horasaida; set => horasaida = value; }
        public double Valorcobrado { get => valorcobrado; set => valorcobrado = value; }
        public int Tempopermanencia { get => tempopermanencia; set => tempopermanencia = value; }
       




        /// <summary>
        /// Metodo Para Verificar se A placa do veiculo já estar cadastrada
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool jacdastrado(string placaveiculo, List<Veiculo> listaveiculos)
        {
            foreach (Veiculo i in listaveiculos)
            {
                if (i.Placaveiculo.Equals(placaveiculo))
                {
                    return true;
                    // .IndexOf();
                }

            }
            return false;

            //foreach (Veiculo i in listaveiculos)
            //{
            //    if (i.Placaveiculo.Equals(placaveiculo))
            //    {
            //        return listaveiculos.IndexOf(i);
            //    }
            //}
            //return -27; //codigo do ESC, ou seja, veiculo nao localizado
        }

      
    }
}
