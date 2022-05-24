/*13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
vendidas pelo vendedor, calcule e mostre: o salário do empregado*/

Console.WriteLine("Exercicio13: 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo.\n" +
    " Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o preço de custo de\n" +
    " cada bicicleta vendida.Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de \n" +
    "cada bicicleta e o número de bicicletas vendidas pelo vendedor, calcule e mostre: o salário do empregado");

Console.WriteLine("");

//Declaração das Variaveis
/// <summary>
/// recebe a entrada do salário minimo
/// </summary>
float SalarioMinimo;

/// <summary>
/// recebe a entrada do preço de custo
/// </summary>
float PrecoDeCustoBicicleta;

/// <summary>
/// recebe a quantidade de bicicletas
/// </summary>
int NumeroBicicletaVendida;

/// <summary>
/// recebe o preço da bicicleta + preço de custo da bicicleta * 0.5 * numero de bicicletas vendidas
/// </summary>
float ValorTotalBicicletaVendida;

/// <summary>
///  recebe 2 * o salario minimo + a commissão
/// </summary>
float SalarioFinal;

/// <summary>
/// recebe preco de custo da bicicleta * 0.15 * numero de bicicletas vendidas
/// </summary>
float Comissao;

//Entrada de Dados
Console.Write("Informe o Valor do Salário Minimo: ");
SalarioMinimo = float.Parse(Console.ReadLine());

Console.Write("Informe o Valor de Custo de Cada bicicleta: ");
PrecoDeCustoBicicleta = float.Parse(Console.ReadLine());

Console.Write("Informe o Numero de Bicicletas Vendidas: ");
NumeroBicicletaVendida = int.Parse(Console.ReadLine());


//Processamento de Dados
 ValorTotalBicicletaVendida = (float)(PrecoDeCustoBicicleta + (PrecoDeCustoBicicleta * 0.5)) * NumeroBicicletaVendida;
 Comissao = (float) (PrecoDeCustoBicicleta * 0.15 * NumeroBicicletaVendida);
 SalarioFinal = 2 * SalarioMinimo + Comissao;

Console.WriteLine($"O Seu Sálario é de: {SalarioFinal:F2}");




