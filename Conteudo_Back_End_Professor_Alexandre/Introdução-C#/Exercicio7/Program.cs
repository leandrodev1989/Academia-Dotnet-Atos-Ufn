// See https://aka.ms/new-console-template for more information

/*Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.*/

Console.WriteLine("Exercicio7: Escreva um programa em C# e no Visual Studio que leia o número de um vendedor,\n" +
    " o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. \n" +
    "Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.");

Console.WriteLine("");


//Declaração das Variáveis
/// <summary>
/// variavel para dar entrada nos dados do vendedor pelo numero de id
/// </summary>
int NumeroVendedor;

/// <summary>
/// variável para receber o salário do vendedor
/// </summary>
float SalarioFixo;

/// <summary>
/// variavel para  entrar com o total de vendas do vendedor
/// </summary>
int TotalDeVendas;

/// <summary>
/// variável respnsavel para atribuir a porcentagem por vendas ao vendedor
/// </summary>
float PercentualComissao ;

//Entrada De Dados
Console.Write("Digite Seu Numero de Vendedor: ");
NumeroVendedor = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Digite Seu Salario Fixo: ");
SalarioFixo = float.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Digite o Numero de Vendas efetuadas: ");
TotalDeVendas = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Digite Seu Percentual sobre o Numero de vendas: ");
PercentualComissao = float.Parse(Console.ReadLine());
Console.WriteLine("");

//Processamento
var SalarioTotal = (TotalDeVendas * PercentualComissao) + SalarioFixo;

Console.WriteLine($"Numero do Vendor: {NumeroVendedor}");
Console.WriteLine($"Salario total {SalarioTotal:F}");
