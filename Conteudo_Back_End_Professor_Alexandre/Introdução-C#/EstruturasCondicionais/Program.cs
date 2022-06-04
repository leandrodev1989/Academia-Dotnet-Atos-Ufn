using System;

namespace EstruturasCondicionais
{
    class Program
    {
        public static void Main(string[] argas)
        {
            //MaiorIdade();
            OperadorIgual();
            //Divisivel();
            //Se();
        }

        public static void MaiorIdade()
        {
            /// <summary
            ///  Verificar se a pessoa é maior ou menor de idade
            /// </summary>


            int idade;
            Console.WriteLine("Digite sua idade:");
            idade = int.Parse(Console.ReadLine());

            if (idade < 18)
            {
                Console.WriteLine("Voçê não é maior de idade");
            }
            else
            {
                Console.WriteLine("Voçê é maior de idade");
            }

        }

        public static void OperadorIgual()
        {
            /// <summary
            /// Verificar se os numeros são iguais ou diferentes
            /// </summary>

            int numero1;
            int numero2;

            Console.WriteLine("Digite dois numeros: ");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 == numero2)
            {
                Console.WriteLine("Os Numeros são Iguais");
            }
            else //if (numero1 != numero2)
            {
                Console.WriteLine("Os Numeros são Diferentes");
            }


        }

        public static void Divisivel()
        {
            ///<summary>
            /// Informar se o numero é divisivel por 2 ,4 ou 8
            ///</summary>

            int numero;
            Console.WriteLine("Informe um Número");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Divisivel por 2!");

            }
            if (numero % 4 == 0)
            {
                Console.WriteLine("Divisivel por 4!");
            }
            if (numero % 8 == 0)
            {
                Console.WriteLine("Divisivel por 8!");
            }

        }

        static void Se()
        {
            int num;
            Console.Write("Digite um numero: ");
            num = int.Parse(Console.ReadLine());

            if (num > 0)
            {
                Console.WriteLine("positivo");
            }
            else if (num < 0)
            {
                Console.WriteLine("negativo");
            }
            else
            {
                Console.WriteLine("Zero!");
            }


        }

        static void Teste()
        {

        }

    }
}

