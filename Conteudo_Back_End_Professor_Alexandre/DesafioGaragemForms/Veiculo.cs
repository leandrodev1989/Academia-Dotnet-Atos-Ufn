using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagemteste
{
    
    class Veiculo
    {

        /// <summary>
        /// Atributos para serem utilizado
        /// </summary>
        string placaveiculo;
        DateTime datahoraentrada;
        float tempopermanencia;
        float valorcobrado;


        /// <summary>
        /// Construtor dos atributos
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="datahoraentrada"></param>
        /// <param name="tempopermanencia"></param>
        /// <param name="valorcobrado"></param>
        public Veiculo(string placaveiculo, DateTime datahoraentrada)
        {
            this.Placaveiculo = placaveiculo;
            this.Datahoraentrada = datahoraentrada;
           // this.tempopermanencia = tempopermanencia;
            //this.valorcobrado = valorcobrado;

        }

        public void Gerardatahora()
        {
            this.Datahoraentrada = DateTime.Now;
        }

        public Veiculo(string placa)
        {
            Placaveiculo = placa;
            this.Gerardatahora();

        }


        /// <summary>
        /// 
        /// </summary>
        public string Placaveiculo { get => placaveiculo; set => placaveiculo = value; }
        public DateTime Datahoraentrada { get => datahoraentrada; set => datahoraentrada = value; }





        /// <summary>
        /// Metodo Para Verificar se A placa do veiculo já estar cadastrada
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool jacdastrado(string nome, List<Veiculo> listaveiculos)
        {
            foreach (Veiculo i in listaveiculos)
            {
                if (nome.Equals(i.placaveiculo))
                {
                    return true;
                }

            }
            return false;
        }

       
    }
}
