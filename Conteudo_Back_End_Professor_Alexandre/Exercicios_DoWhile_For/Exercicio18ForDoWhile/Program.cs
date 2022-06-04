/*18.Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
elevada a um expoente qualquer, ou seja, NM. */



/// <summary>
/// Recebe a entrada do numero 1
/// </summary>
double n1;

/// <summary>
/// Recebe a Entrada do numero 2
/// </summary>
double n2;

/// <summary>
/// faz o operação da Potência com o função Math.Pow
/// </summary>
double resultado;


/// <summary>
/// Entrada de Dados
/// </summary>
Console.Write("Digite Um Número: ");
n1 = double.Parse(Console.ReadLine());

Console.Write("Digite Outro Número: ");
n2 = double.Parse(Console.ReadLine());

/// <summary>
/// Processamento de Dados
/// </summary>
resultado = Math.Pow(n1, n2);

Console.WriteLine($"O Valor da Potência é:{resultado}");