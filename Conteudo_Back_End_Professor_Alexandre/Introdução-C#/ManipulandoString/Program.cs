namespace ManupulandoString
{
    class Program
    {
        public static void Main(string[] args)
        {
            // string nome = "Leandro josé"; 
            //int sobrenome = nome.IndexOf("josé");

            /// <summary>
            ///  O método IndexOf é ultilizado para localizar
            /// uma determinada palavra dentro da string
            /// esse método retorna a posição da string desejada
            /// </summary>


            /// <summary
            ///  ToUpper passa de minusculo para maiusculo
            ///  
            /// </summary>


            /// <summary
            ///  ToLower passa Maiusculo para  minusculo 
            ///  string nome = " Leandro";
            ///  nome = nome.ToLower();
            ///  Console.WriteLine(nome);
            /// </summary>


            /// <summary>
            /// A função Split serve para quebrar uma string em um array de string de 
            /// acordo com um separador.  
            /// </summary>


            ///<summary>
            /// ao contrário da função split a função Join concatena um array de 
            /// string inserindo um separtador.
            ///</summary>

            //string linha = "Carlos, Pablo, Pedro";

            //string[] campos = linha.Split(',');

            //Console.WriteLine(campos[2]);

            //string linhanova = String.Join(";", campos);

            //Console.WriteLine(linhanova);


            //int idade = 17;
            //string teste = String.Format("Vou colocar o {0} aqui.", idade);
            //Console.WriteLine(teste);

            Executar();
        }

        static void Executar()
        {
            //Console.WriteLine("Escreva o primeiro numero");
            //int numero = int.Parse(Console.ReadLine());

            //Console.WriteLine("Escreva o segundo numero");
            //int numero2 = int.Parse(Console.ReadLine());

            //if (numero == numero2)
            //{
            //    Console.WriteLine("O numeros são iguais");
            //}
            //else
            //{
            //    Console.WriteLine("são diferentes");
            //}

            //Console.WriteLine("=======================");

            //Console.WriteLine("Digite um número");
            //int n = int.Parse(Console.ReadLine());

            //if (n > 0)
            //{
            //    Console.WriteLine("Positivo!");
            //}

            //Console.WriteLine("=======================");

            //Console.WriteLine("Digite um número");
            //int n1 = int.Parse(Console.ReadLine());

            //if (n1 % 2 == 0)
            //{
            //    Console.WriteLine("Positivo!");
            //}
            //else
            //{
            //    Console.WriteLine("Negativo");
            //}

            //Console.WriteLine("=======================");
            //Console.WriteLine("=======================");
            //int numerador;

            //Console.WriteLine("Escreva um numero");
            //numerador = int.Parse(Console.ReadLine());

            //if (numerador % 2 == 0)
            //{
            //    Console.WriteLine("Divisivel por 2");

            //}
            //else if (numerador % 4 == 0)
            //{
            //    Console.WriteLine("Divisivel por 4");

            //}
            //else if (numerador % 8 == 0)
            //{
            //    Console.WriteLine("Divisivel por 8");
            //}

            //Console.WriteLine("=======================");
            //Console.WriteLine("=======================");
            //Console.WriteLine("=======================");

            //int valor;
            //Console.WriteLine("Digite o valor");
            //valor = int.Parse(Console.ReadLine());

            //if (valor > 0 && valor % 2 == 0)
            //{
            //    Console.WriteLine("O numero é par e positivo");
            //}
            bool escolha = false;
            while (escolha == false)
            {
                Console.Clear();
                Console.WriteLine("escolha uma opção");
                Console.WriteLine($"1-soma\n2-subtrai\n3-multiplica\n4-dividir\n5-Petência\n6-Sair");
                int op = int.Parse(Console.ReadLine());

                
                if (op > 0 && op < 6)
                {

                    if (op == 1)
                    {
                        Console.Write($"Digite um numero: ");
                        int numero0 = int.Parse(Console.ReadLine());

                        Console.Write($"Digite o segundo numero: ");
                        int numeral = int.Parse(Console.ReadLine());

                        int soma = numero0 + numeral;

                        Console.Write($"O resultado da soma é: {soma}");

                    }
                    else if (op == 2)
                    {
                        Console.Write($"Digite um numero: ");
                        int numero0 = int.Parse(Console.ReadLine());

                        Console.Write($"Digite o segundo numero: ");
                        int numeral = int.Parse(Console.ReadLine());

                        int subtra = numero0 - numeral;

                        Console.Write($"O resultado da soma é: {subtra}");

                    }
                    else if (op == 3)
                    {
                        Console.Write($"Digite um numero: ");
                        int numero0 = int.Parse(Console.ReadLine());

                        Console.Write($"Digite o segundo numero: ");
                        int numeral = int.Parse(Console.ReadLine());

                        int mult = numero0 * numeral;

                        Console.Write($"O resultado da soma é: {mult}");


                    }
                    else if (op == 4)
                    {
                        Console.Write($"Digite um numero: ");
                        int numero0 = int.Parse(Console.ReadLine());

                        Console.Write($"Digite o segundo numero: ");
                        int numeral = int.Parse(Console.ReadLine());

                        int div = numero0 / numeral;

                        Console.Write($"O resultado da soma é: {div}");

                    }
                    else if(op == 5)
                    {
                        
                        int resultado1 = Math.Pow(numero0, numeral);
                        Console.WriteLine($"Potencia = : {resultado1}");
                    }
                }
                else
                {
                    escolha = true;
                }


                Console.ReadLine();
            }


            /// <summary>
            /// Considere que será concedido um bônus aos trabalhadores de uma empresa
            /// conforme o salário atual do vendedor, descrito abaixo. Desenvolva o
            /// algoritmo para ler o salário e calcular o valor em reais do aumento.
            /// exibir na tela, o salário atual, o aumento (% e R$) eo novo salário.
            /// 
            /// .Salários                                  %aumento
            /// .Até R$ 900,00 (inclusive).............................5%
            /// .De R$ 900,00 a R$ 1.400,00............................8%
            /// .Acima de 1.400,00 (inclusive).........................10%
            /// </summary>

            //float salario;

            //float aumento;
            //Console.WriteLine("Digite o Salário:");
            //salario = float.Parse(Console.ReadLine());
            //if(salario < 900)
            //{
               
            //    aumento = 5;
            //}
            //else if(salario >= 900 && salario < 1400)
            //{
                
            //    aumento = 8;
            //}
            //else if(salario >= 1400)
            //{
               
            //    aumento = 10;
            //}

          
            //var novoSalario = salario + salario * (aumento / 100);
            //Console.WriteLine($"O Salário e de {aumento} porcento eo salario final de {novoSalario}");

            
            



        }
    }
}
