using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio7PrimeiraParte
{
    class Veiculo
    {

        /// <summary>
        /// variaveis declaradas para receber informações da placa
        /// </summary>
         string placa;

        /// <summary>
        /// variavel para gerar a data de entrada
        /// </summary>
         DateTime datahoraentrada;


        /// <summary>
        /// Metodo para gerar hora e gravar no historico
        /// </summary>
        private void  gerarDatahora()
        {
            this.datahoraentrada = DateTime.Now;
        }


        public Veiculo(string placa, DateTime datahoraentrada)
        {
            Placa = placa;
            this.datahoraentrada = datahoraentrada;
        }


        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public Veiculo(string placa)
        {
            this.Placa = placa;
            this.gerarDatahora();
        }


        /// <summary>
        /// Get e set para setar e alterar a placa
        /// </summary>
        public string Placa { get => placa; set => placa = value; }


        /// <summary>
        /// get e set da data e hora
        /// </summary>
        public   DateTime Datahoradaentrada { get => datahoraentrada; set => datahoraentrada = value; }



       
    }
        
}
