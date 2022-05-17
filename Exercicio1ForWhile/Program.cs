/*1.Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados 
(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

Exemplo:
Digite um número inteiro positivo: -8
Valor incorreto!
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6. */



/// <summary>
/// validadr se a informação e verdadeira ou falsa
/// </summary>
bool numeroPositivo = false;


/// <summary>
/// recebe o numero solicitado
/// </summary>
int numero;


/// <summary>
/// Processa a validação dos dados de entrada
/// </summary>


while (numeroPositivo == false)
{
    Console.Write("Digite um Número Inteiro Positivo: ");
    numero = int.Parse(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Valor Incorreto!!");
        numeroPositivo = false;

    }

    Console.WriteLine($"Número digitado {numero} ");
    Console.WriteLine($"Número inteiros pares entre 1 e {numero}: ");

    for (int i = 1; i < numero; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i + " ");


        }
        else
        {
            numeroPositivo = true;

            Console.WriteLine("");
        }

    }

}

