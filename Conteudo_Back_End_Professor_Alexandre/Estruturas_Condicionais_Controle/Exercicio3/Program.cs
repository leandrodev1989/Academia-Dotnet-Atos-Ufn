/*Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, 
  e escrever na tela os que são superiores à média. */

/// <summary>
///  ler entrada numero1
/// </summary>
int numero1;

/// <summary>
///   ler entrada numero2
/// </summary>
int numero2;

/// <summary>
///  ler entrada numero3
/// </summary>
int numero3;

/// <summary>
///  ler entrada numero4
/// </summary>
int numero4;

/// <summary>
///  Variável Responsavel Por fazer a soma dos numeros / 2 para retornar a media
///  e validar quais numeros são superiores a media
/// </summary>
double media;

//Entrada De Dados
Console.WriteLine("Digite o primeiro Numero:");
numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro Numero:");
numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro Numero:");
numero3 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o primeiro Numero:");
numero4 = int.Parse(Console.ReadLine());

//Processamento de Dados
media = (numero1 + numero2 + numero3 + numero4) / 4;

Console.WriteLine($"A media Foi de: {media}");

if (numero1 > media)
{
    Console.WriteLine("O numero 1 é maior que a media!");
}
if (numero2 > media)
{
    Console.WriteLine("O numero 2 é maior que a media!");
}
if (numero3 > media)
{
    Console.WriteLine("O numero 3 é maior que a media:");
}
if (numero4 > media)
{
    Console.WriteLine("O numero 4 é maior que a media:");
}



