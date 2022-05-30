using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
     class Animal
     {

        /// <summary>
        /// atributos com get e set privados
        /// </summary>
        private int contadorgato ;
        private int contadorcachorro;
        private int contadorpeixe ;
        private string Nome { get;  set; }
        private string Tipo { get;  set; }


        /// <summary>
        /// Construtores recebendo os atributos
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="tipo"></param>
        /// <param name="contadorgato"></param>
        /// <param name="contadorcachorro"></param>
        /// <param name="contadorpeixe"></param>
        public Animal(string nome, string tipo, int contadorgato, int contadorcachorro, int contadorpeixe)
        {

            this.Nome = nome;
            this.Tipo = tipo;
            this.contadorgato = contadorgato;
            this.contadorcachorro = contadorcachorro;
            this.contadorpeixe = contadorpeixe;
            
        }


        /// <summary>
        /// Construtor vazio padrão
        /// </summary>
        public Animal()
        {

        }


        /// <summary>
        /// Metodo para exibir na Main os dados da lista
        /// </summary>
        /// <returns></returns>
        public string Exibir()
        {
            return $" Nome: {this.Nome} \n Tipo: {this.Tipo}";

        }


     }

    
}
