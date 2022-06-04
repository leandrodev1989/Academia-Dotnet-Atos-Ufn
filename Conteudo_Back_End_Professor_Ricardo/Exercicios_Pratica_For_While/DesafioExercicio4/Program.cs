/*4.Faça um algoritmo que leia uma lista de números inteiros positivos terminada pelo número 0 (zero). 
Ao final, o algoritmo deve mostrar a média aritmética de todos os números lidos (excluindo o zero). */

using System.Linq;

/// <summary>
/// Criação de Uma Lista para armazenar os valores inteiros
/// </summary>
var Numeros = new List<int> { 10, 20, 30, 50, 60, 70 };

/// <summary>
/// Busca o Valor na Lista Traz  Media sem o zero 
/// </summary>
var Media = Numeros.Average().ToString().TrimEnd('0');

  

/// <summary>
/// Processamento de Dados
/// </summary>
Console.WriteLine($"A Média é: {Media} com exclusão do zero!");
foreach(var  numero in Numeros)
{
    Console.WriteLine($"Numeros Lidos: {numero}");
}





