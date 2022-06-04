// See https://aka.ms/new-console-template for more information


/*
 * Escreva um programa em C# e no Visual Studio para calcular a média 
 * aritmética entre quatro números quaisquer.
 */

Console.WriteLine("Exercício 2: Escreva um programa em C# e no Visual Studio\n" +
    "para calcular a média aritmética entre quatro números quaisquer.");

//Declaração das Variáveis
float numero1;
float numero2;
float numero3;
float numero4;
float mediaAritmetica;

//Entrada de Dados
Console.Write("Informe o 1o número: ");
numero1 = float.Parse(Console.ReadLine());

Console.Write("Informe o 2o número: ");
numero2 = float.Parse(Console.ReadLine());

Console.Write("Informe o 3o número: ");
numero3 = float.Parse(Console.ReadLine());

Console.Write("Informe o 4o número: ");
numero4 = float.Parse(Console.ReadLine());

//Processamento de Dados
mediaAritmetica = (numero1 + numero2 + numero3 + numero4) / 4;

Console.WriteLine("A média dos 4 valores é: " + mediaAritmetica);

