/*3.Dado um limite inferior e superior, calcule a soma de todos os números pares contidos
nesse intervalo. */


/// <summary>
/// faz a contagem para verificar o total
/// </summary>
int cont;

/// <summary>
/// Recebe o valor inferior
/// </summary>
int inf;

/// <summary>
/// recebe o valor superior
/// </summary>
int sup; 

/// <summary>
/// Recebe a operação para fazer o somatorio
/// </summary>
int somatotal = 0;


/// <summary>
/// Entrada de Dados
/// </summary>
Console.Write("Digite o Limite Inferior: ");
inf = int.Parse(Console.ReadLine());



/// <summary>
/// Entrada de Dados
/// </summary>
Console.Write("Digite o Limite Superior: ");
sup = int.Parse(Console.ReadLine());



/// <summary>
/// Processamento de Dados
/// </summary>
for(cont = inf; cont < sup; cont++)
{
    if (cont % 2 == 0)
    {

        somatotal = cont + somatotal;

        Console.WriteLine($"A Soma total dos numeros pares do intervalo de {inf} de {sup} é de {somatotal}");

    }
}