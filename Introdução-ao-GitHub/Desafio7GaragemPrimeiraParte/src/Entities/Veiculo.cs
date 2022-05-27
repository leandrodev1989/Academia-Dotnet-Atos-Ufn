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
        public string placa;

        /// <summary>
        /// variavel para gerar a data de entrada
        /// </summary>
        public DateTime datahoraentrada;




        /// <summary>
        /// Construtor com as insformações da placa e data
        /// </summary>
        /// <param name="placa"></param>
        /// <param name="data"></param>
        public Veiculo(string placa, DateTime data)
        {
            this.Placa = placa;
            this.datahoraentrada = data;
        }


        /// <summary>
        /// Get e set para setar e alterar a placa
        /// </summary>
        public string Placa { get => placa; set => placa = value; }


        /// <summary>
        /// get e set da data e hora
        /// </summary>
        public DateTime datahoradaentrada { get => datahoraentrada; set => datahoraentrada = value; }



        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public Veiculo()
        {

        }
    }
        
}
