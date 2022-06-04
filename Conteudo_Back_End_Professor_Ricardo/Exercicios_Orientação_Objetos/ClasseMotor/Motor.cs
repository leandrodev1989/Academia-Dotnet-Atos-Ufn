using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMotor
{
    class Motor
    {
        /// <summary>
        /// Atributos da classe Motor
        /// </summary>
        public string NomeFabricante { get; set; }
        public double Potencia { get; set; }
        public string Tipo { get; set; }


        /// <summary>
        /// Construtor com as informações da classe Motor
        /// </summary>
        /// <param name="nomefabricante"></param>
        /// <param name="potencia"></param>
        /// <param name="tipo"></param>
        public Motor(string nomefabricante, double potencia, string tipo)
        {
            this.NomeFabricante = nomefabricante;
            this.Potencia = potencia;
            this.Tipo = tipo;

        }

        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public Motor()
        {
        }


        /// <summary>
        /// Metodo para retornar a Potência da CLASSE Motor
        /// </summary>
        public   void  RetornaPotenciaMotor()
        {
            Potencia = 100;
            Console.WriteLine($"O MOtor tem {Potencia} Cavalos de Potência");
            
        }


        /// <summary>
        /// Metodo para Retornar o Tipo do Motor Da classe Motor
        /// </summary>
        public  void RetornaTipoMotor()
        {
            Tipo = "Ferrari Raro";
            Console.WriteLine($"O Motor é do Tipo {this.Tipo} ");
        }


        /// <summary>
        /// Metodo para Exibir o Nome do fabricante
        /// </summary>
        public void ExibirDados()
        {
            NomeFabricante = "FerrariHouse";
            Console.WriteLine($"O Nome do Fabricado é {this.NomeFabricante} ");
        }


    }
}
