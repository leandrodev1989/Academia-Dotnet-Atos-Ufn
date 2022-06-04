/*1.Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte
soma: S = 1 + 1 / 2 + 1 / 3 + 1 / 4 + 1 / 5....1/n */



/// <summary>
/// Recebe a entrada do numero que será feito a soma
/// </summary>
int n;

/// <summary>
/// Recebe a Soma + o contador;
/// </summary>
float soma = 0;

/// <summary>
/// inicia o contador apartir do 1
/// </summary>
int i = 1;



/// <summary>
/// Entrada de Dados
/// </summary>
Console.Write("Digite um Número: ");
n = int.Parse(Console.ReadLine());


/// <summary>
/// Recebe a condição de controlar caso o seja menor o numero digitado.
/// </summary>
while(i <= n)
{
    soma =  soma + i;
    i++;

    Console.WriteLine($"A Soma dos {n} primeiros inteiros positivos é {soma}");
}

