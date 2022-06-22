using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Garagemteste
{

    class Veiculo
    {

        /// <summary>
        /// Atributos para serem utilizado
        /// </summary>
        string placaveiculo;
        string dataentrada;
        double valorcobrado;
        string horasaida;
        string datasaida;
        string horaentrada;
        double valorhora;
        int tempopermanencia;

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
        public Veiculo(string placaveiculo, string horasaida, int tempopermanencia,
            double valorcobrado)
        {

            this.Placaveiculo = placaveiculo;        
            this.Horasaida = horasaida;
            this.Tempopermanencia = tempopermanencia;
            this.Valorcobrado = valorcobrado;


        }

        /// <summary>
        /// Construtor da placa do veiculo
        /// </summary>
        /// <param name="placaveiculo"></param>
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
        public double Valorhora { get => valorhora; set => valorhora = value; }
        public int Tempopermanencia { get => tempopermanencia; set => tempopermanencia = value; }

        /// <summary>
        /// Metodo para Gerar data e hora
        /// </summary>
        /// <returns></returns>
        public static string GerarDH()
        {
            DateTime date = DateTime.Now;
            string dataformato = date.ToString("dd/MM/yyyy HH:mm");
            string[] vetordados = dataformato.Split(':');

            return vetordados[0];
        }


        /// <summary>
        /// Metodo para Retornar o Valor cobrado pelo o tempo do veiculo no estacionamento
        /// </summary>
        /// <param name="horasaida"></param>
        /// <param name="preco"></param>
        public void RealizaCobranca(string horasaida, double valorhora)
        {
            try
            {
                string[] vetorcobranca = Horaentrada.Split(':');
                int hora = int.Parse(vetorcobranca[0]);
                int minutos = int.Parse(vetorcobranca[1]);
                int entrada = hora * 60 + minutos;



                vetorcobranca = horasaida.Split(':');
                hora = int.Parse(vetorcobranca[0]);
                minutos = int.Parse(vetorcobranca[1]);
                int saida = hora * 60 + minutos;


                this.Tempopermanencia = saida - entrada;
                double cobranca = (double) this.Tempopermanencia / 60;
                int tempo = (int)Math.Ceiling(cobranca);
                this.Valorcobrado = tempo * valorhora;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no Processo.", ex.Message);
                return;
            }


        }




    }
}
