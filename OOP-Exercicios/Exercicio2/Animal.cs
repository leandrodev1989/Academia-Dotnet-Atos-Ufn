using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
     class Animal
     {
        private int contadorgato = 0;
        private int contadorcachorro = 0;
        private int contadorpeixe = 0;

        private string Nome { get;  set; }
        private string Tipo { get;  set; }

        public Animal(string nome, string tipo, int contadorgato, int contadorcachorro, int contadorpeixe)
        {

            this.Nome = nome;
            this.Tipo = tipo;
            this.contadorgato = contadorgato;
            this.contadorcachorro = contadorcachorro;
            this.contadorpeixe = contadorpeixe;
            
        }

        public Animal()
        {

        }



     }

    
}
