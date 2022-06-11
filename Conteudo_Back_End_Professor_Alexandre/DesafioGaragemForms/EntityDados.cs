using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagemteste
{
     class EntityDados
     {
        




        /// <summary>
        /// Metodo com o construtor para gravar no arquivo entrada
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void gravarNoarquivoEntrada(List<Veiculo> listaveiculos)
        {

            StreamWriter escritor = new StreamWriter("veiculosEntrada.txt");

            foreach (Veiculo i in listaveiculos)
            {
                escritor.WriteLine(i.Placaveiculo + " - " + i.Dataentrada + " - " + i.Horaentrada);
                escritor.Flush();
               
                
            }
            escritor.Close();

        }

        /// <summary>
        /// método que a partir da lista persiste os dados no arquivo dos veículos que passaram pela garagem
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void gravarNoArquivoSaida(List<Veiculo> listaveiculos)
        {
            StreamWriter escritor = new StreamWriter("veiculosSaida.dat");

            foreach (Veiculo i in listaveiculos)
            {
                escritor.WriteLine(i.Placaveiculo+ ";" + i.Dataentrada + ";" + i.Horaentrada + ";" + i.Datasaida + ";" + i.Horasaida + ";" + i.Tempopermanencia + ";" + i.Valorcobrado);
                escritor.Flush();
            }
            escritor.Close();
        }
    }
}
