// See https://aka.ms/new-console-template for more information



/*
 * 1) Escreva um programa em C# e no Visual Studio para 
 * calcular a média aritmética entre dois números quaisquer.
 * */

Console.WriteLine("Exercício 1: Escreva um programa em C# e no Visual\n" +
                  "Studio para calcular a média aritmética entre dois\n " +
                  "números quaisquer");

// Decraração de Variáveis
float numero1;
float numero2;
float media_aritmetica;

//Entrada de Dados
Console.Write("Digite o primeiro número : ");
numero1 = float.Parse(Console.ReadLine());

Console.Write("Digite o segundo número : ");
numero2 = float.Parse(Console.ReadLine());

//Processamento de Dados
media_aritmetica = (numero1 + numero2) / 2;

Console.WriteLine("A média aritmética dos valores é de: " + media_aritmetica);

