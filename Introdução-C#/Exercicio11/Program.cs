/*Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um 
representa em relação ao total de eleitores. */

Console.WriteLine("Exercicio11: Escreva um algoritmo para ler o número de eleitores de um município,\n" +
                 " o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um\n" +
                 "representa em relação ao total de eleitores.");

Console.WriteLine("");

//Declaração das Variáveis
/// <summary>
/// variável responsavel por receber a quntidade de votos dos eleitores
/// </summary>
int totaldeVotos;

/// <summary>
/// recebe a quantidade de votos brancos em porcentagem
/// </summary>
int branco;

/// <summary>
/// recebe a quantidade de votos nulos por porcentagem
/// </summary>
int nulo;

/// <summary>
/// recebe a qunatidade de votos validos por porcentagem
/// </summary>
int valido;

//Entrada de Dados
Console.WriteLine("Total de Eleitores: ");
totaldeVotos = int.Parse(Console.ReadLine());

Console.Write("Votos validos: ");
valido = int.Parse(Console.ReadLine());

Console.Write("Votos em branco: ");
branco = int.Parse(Console.ReadLine());

Console.Write("Votos nulos: ");
nulo = int.Parse(Console.ReadLine());

Console.WriteLine("");

//Processamento de Dados
var TotaldeValidos = valido * 100 / totaldeVotos;

Console.WriteLine($"Porcentagem de votos validos: {TotaldeValidos} % " );
Console.WriteLine("");

var TotalDeBranco = branco * 100 / totaldeVotos;  

Console.WriteLine($"Porcentagem de votos brancos: {TotalDeBranco} % " );
Console.WriteLine("");

var TotalNulo = nulo * 100 / totaldeVotos;  

Console.WriteLine($"Porcentagem de votos nulo: {TotalNulo} %" );






