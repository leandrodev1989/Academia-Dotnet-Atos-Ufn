/*16.Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
(N*3; N * 3 * 3; N * 3 * 3 * 3; etc). */

/// <summary>
/// Recebe o valor para ser Multiplicado
/// </summary>
int n;


/// <summary>
/// Entrada de Dados
/// </summary>
Console.Write("Digite um Número: ");
n = int.Parse(Console.ReadLine());


/// <summary>
/// Processamento de Dados
/// </summary>
if(n > 50)
{
    Console.WriteLine("O Número tem que ser entre 0 - 50");
}

while(n < 250)
{
    n = n * 3;
}
Console.WriteLine($"Valor final: {n}");