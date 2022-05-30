
/*19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente. */

/// <summary>
/// Variável que recebe o tamanho da array
/// </summary>
double[] Numeros = new double [4];


//Processamento de Dados
Console.Write("Digite o Primeiro Valor: ");
Numeros[0] = double.Parse(Console.ReadLine());

Console.Write("Digite o Segundo Valor: ");
Numeros[1] = double.Parse(Console.ReadLine());

Console.Write("Digite o Terceiro Valor: ");
Numeros[2] = double.Parse(Console.ReadLine());

Console.Write("Digite o Quarto Valor: ");
Numeros[3] = double.Parse(Console.ReadLine());


/// <summary>
/// Função para fazer a busca ordenada
/// </summary>
Array.Sort(Numeros);



/// <summary>
/// Função para percorrer o array e achar o numero na sua posição
/// </summary>
for (int i = 0; i < Numeros.Length; i++)
{
    Console.WriteLine(Numeros[i]);
}

