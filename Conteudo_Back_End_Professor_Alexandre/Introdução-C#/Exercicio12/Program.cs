/*12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível 
  é de R$6,90, escreva um algoritmo para ler a marcação do odômetro (marcador de quilometragem) no início do dia, 
 a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebidodos passageiros.
 Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.*/

Console.WriteLine("Exercicio12 : Um motorista de taxi deseja calcular o rendimento de seu carro na praça.\n" +
    " Sabendo-se que o preço do combustível é de R$6, 90, escreva um algoritmo para ler a marcação do odômetro\n" +
    "(marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível\n" +
    " gasto e o valor total (R$) recebidodos passageiros.Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia");

Console.WriteLine("");

//Declaração das Variaveis
/// <summary>
/// variável responsavel para aplicar a media do combustivel gasto
/// </summary>
float MediaConsumo;

/// <summary>
/// recebe a entrada de combustivel
/// </summary>
float CombustivelGasto;

/// <summary>
/// recebe o lucro obtido com os passageiros
/// </summary>
float LucroPassageiro;

/// <summary>
/// retorna o lucro atraves do lucro do passageiro com o combustivel gasto
/// </summary>
float LucroLiquido;

/// <summary>
/// recebe a entrada inicial do  odômetro
/// </summary>
float OdometroInicial;

/// <summary>
/// recebe a entrada final do odômetro
/// </summary>
float OdometroFinal;

//Entrada de Dados
Console.Write("Informe o Odômetro Inicial: ");
OdometroInicial = float.Parse(Console.ReadLine());


Console.Write("Informe o Odômetro Final: ");
OdometroFinal= float.Parse(Console.ReadLine());


Console.Write("Informe a Quantidade de Litros de Combustivel Gastos: ");
CombustivelGasto = float.Parse(Console.ReadLine());


Console.Write("Informe o Valor Arrecadado no dia de Serviço: ");
LucroPassageiro = float.Parse(Console.ReadLine());

//Processamento de Dados
MediaConsumo = (OdometroFinal - OdometroInicial) / CombustivelGasto;

LucroLiquido = (float)(LucroPassageiro - (CombustivelGasto * 6.90));

Console.WriteLine($"O Consumo Médio Km/l foi: { MediaConsumo} \n" +
                  $"o Valor liquido arrecadado foi R$: {LucroLiquido:F}");


