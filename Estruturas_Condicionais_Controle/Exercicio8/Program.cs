/*8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
total de vendas. */


/// <summary>
/// Entra com o codigo do usuario
/// </summary>
int codigo;

/// <summary>
/// Entra com o nome do usuario
/// </summary>
string nome;

/// <summary>
/// Entra com o saláro base do usuario
/// </summary>
double salariobase;

/// <summary>
/// Entrar com o total de Vendas
/// </summary>
double totalVendas;

/// <summary>
/// Variável Responsavel por receber a porcentagem do aumento
/// </summary>
double salarioFinal;

/// <summary>
/// adiciona a porcentagem de 5% case seja maior 500,00 R$
/// </summary>
double porcentagemVendas5 = 0.05;

/// <summary>
/// adiciona a porcentagem de 7% case seja maior 1000,00 R$
/// </summary>
double porcentagemVendas7 = 0.07;

/// <summary>
/// adiciona a porcentagem de 10% case seja maior 5000,00 R$
/// </summary>
double porcentagemVendas10 = 0.10;

//Entrada de dados
Console.Write("Digite seu codigo: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("Digite Seu Nome: ");
nome = Console.ReadLine();

Console.Write("Digite Seu Salario Base: ");
salariobase = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o total de Venda:"); 
totalVendas = double.Parse(Console.ReadLine());


//Processamento de Dados
if(totalVendas > 500 && totalVendas <= 1000)
{
    var aumento5 = totalVendas * porcentagemVendas5 ;
    salarioFinal = aumento5 + salariobase ;
    Console.WriteLine($"{nome} Seu Salário Com Comissão de 5%  é de {salarioFinal:F}");
}
else if(totalVendas > 1000 && totalVendas <= 5000)
{
    var aumento7 = totalVendas * porcentagemVendas7;
    salarioFinal = aumento7 + salariobase;
    Console.WriteLine($"{nome} Seu Salário Com Comissão de 7%  é de {salarioFinal:F}");

}
else if(totalVendas > 5000)
{
    var aumento10 = totalVendas * porcentagemVendas10;
    salarioFinal = aumento10 + salariobase;
    Console.WriteLine($"{nome} Seu Salário Com Comissão de 10%  é de {salarioFinal:F}");
}