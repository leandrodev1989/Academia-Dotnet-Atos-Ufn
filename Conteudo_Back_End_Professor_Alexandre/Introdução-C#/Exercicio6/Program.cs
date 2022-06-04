// See https://aka.ms/new-console-template for more information

/* 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
de IPI (única) a ser acrescentada. */

Console.WriteLine("");
Console.WriteLine("Exercicio6:  Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A\n" +
                 " e para o parafuso B, isto é, o código, a quantidade de peças \n" +
                 "e o valor unitário de cada \n" +"parafuso e a porcentagem " +
                 "de IPI (única) a ser acrescentada.");

Console.WriteLine("");

//Decraração das variáveis
/// <summary>
/// variável para ler os dados do parafuso A
/// </summary>
int ParafusoA;

/// <summary>
/// variável para receber os dados do parafuso B
/// </summary>
int ParafusoB;

/// <summary>
/// dar entrada na qunatidade de peças
/// </summary>
int QuantidadePecas;

/// <summary>
/// recebe o valor unitário das peças
/// </summary>
float valorUnitario;

/// <summary>
///  aplica o imposto sobre o produto
/// </summary>
double  IPI = 10;  // Imposto aplicado de 10% ao Produto


//Entrada dos Dados do Produto A
Console.Write("Digite o Codigo do Parafuso A: ");
ParafusoA = int.Parse(Console.ReadLine());
Console.Write("Digite a Quantidade de Peças: ");
QuantidadePecas = int.Parse(Console.ReadLine());
Console.Write("Digite O valor unitário do Parafuso A: ");
valorUnitario = float.Parse(Console.ReadLine());

//Processamento dos Dados do Produto A
var ImpostoAdicionado1 = (QuantidadePecas * valorUnitario * IPI) / 100 + valorUnitario;
Console.WriteLine("");

Console.WriteLine($"O Codigo do parafuso A: {ParafusoA}");
Console.WriteLine($"Quantidade do parafuso A: {QuantidadePecas}");
Console.WriteLine($"O Valor  do parafuso A: {valorUnitario:F} R$");
Console.WriteLine($"Valor Com Imposto: {ImpostoAdicionado1:F2} R$");
Console.WriteLine("");

//Fim da Instruçao
Console.WriteLine("==========================================");
Console.WriteLine("");

//Entrada dos Dados do Produto B
Console.Write("Digite o Codigo do Parafuso B: ");
ParafusoB = int.Parse(Console.ReadLine());
Console.Write("Digite a Quantidade de Peças: ");
QuantidadePecas = int.Parse(Console.ReadLine());
Console.Write("Digite O valor unitário do Parafuso B: ");
valorUnitario = float.Parse(Console.ReadLine());


Console.WriteLine("");

//Processamento dos Dados do Produto B
var ImpostoAdicionado = (QuantidadePecas * valorUnitario * IPI) / 100 + valorUnitario;

Console.WriteLine($"O Codigo do parafuso B: {ParafusoB}");
Console.WriteLine($"Quantidade do parafuso A: {QuantidadePecas}");
Console.WriteLine($"O Valor unitário do parafuso A: {valorUnitario:F} R$");
Console.WriteLine($"Valor Com Imposto: {ImpostoAdicionado:F2} R$");

//Fim da Instrução
Console.WriteLine("==========================================");













