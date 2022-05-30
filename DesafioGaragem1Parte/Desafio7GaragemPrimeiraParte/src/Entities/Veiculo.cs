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
         string Placa;

        /// <summary>
        /// variavel para gerar a data de entrada
        /// </summary>
         DateTime datahoraentrada;




        public Veiculo(string placa, DateTime  data)
        {
            this.Placa = placa;
            this.datahoraentrada = data;
        }


        /// <summary>
        /// Get e set para setar e alterar a placa
        /// </summary>
        public string placa { get => Placa; set => Placa = value; }


        /// <summary>
        /// get e set da data e hora
        /// </summary>
        public  DateTime Datahoradaentrada { get => datahoraentrada; set => datahoraentrada = value; }



        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public Veiculo()
        {

        }
    }
        
}
