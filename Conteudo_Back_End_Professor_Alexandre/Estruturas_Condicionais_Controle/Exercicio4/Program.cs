/*Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores
 e o valor por hora recebido por cada um deles. Mostrar na tela qual dos professores 
tem o maior salário total.*/


/// <summary>
/// Recebe a quantidade de horas trabalhadas Professor 1
/// </summary>
int horas1;

/// <summary>
/// Recebe a quantidade de horas trabalhadas Professor 2
/// </summary>
int horas2;

/// <summary>
/// Recebe o valor por horas trabalhadas
/// </summary>
float ValorPorHora;

/// <summary>
/// função para fazer o calculo do valor final do salário do professor 1
/// </summary>
float SalarioMaiorTotal1;

/// <summary>
/// função para fazer o calculo do valor final do salário do professor 2
/// </summary>
float SalarioMaiorTotal2;



//Entrada de dados
Console.Write("Digite a Quantidade De Horas Trabalhadas Pelo Professor 1: ");
horas1 = int.Parse(Console.ReadLine());

Console.Write("Digite o Valor  da  Hora Trabalhada: ");
ValorPorHora = float.Parse(Console.ReadLine());

//Processamento de dados
 SalarioMaiorTotal1 = horas1 * ValorPorHora;

Console.WriteLine($"O Salário final do Professor 1 é de : {SalarioMaiorTotal1:F} Reais");
Console.WriteLine("");
Console.WriteLine("==========================================================");

//Entrada de dados
Console.Write("Digite a Quantidade De Horas Trabalhadas Pelo Professor 2: ");
horas2 = int.Parse(Console.ReadLine());

Console.Write("Digite o Valor  da  Hora Trabalhada: ");
ValorPorHora = float.Parse(Console.ReadLine());

//Processamento de dados
SalarioMaiorTotal2 =  horas2 * ValorPorHora;

Console.WriteLine($"O Salário final do Professor 2 é de : {SalarioMaiorTotal2:F} Reais");

Console.WriteLine("==========================================================");

if (SalarioMaiorTotal1 > SalarioMaiorTotal2)
{
    Console.WriteLine($"O Professor 1  teve o Maior Salário no Mês: Seu Salário foi de; {SalarioMaiorTotal1:F}");
}
else if(SalarioMaiorTotal1 < SalarioMaiorTotal2)
{
    Console.WriteLine($"O Professor 2  teve o Maior Salário no Mês: Seu Salário foi de {SalarioMaiorTotal2:F}");
}
else if(SalarioMaiorTotal1 == SalarioMaiorTotal2)
{
    Console.WriteLine("Salário No Mês Iguais!");
}