// See https://aka.ms/new-console-template for more information

/*Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
notas de menor valor fossem distribuídas em número mínimo possível. 
Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00,
três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
de acordo com o critério da “distribuição ótima”.
*/


Console.WriteLine("Exercicio10: Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo \n" +
                 "para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que\n" +
                 "realizou o saque.Um possível critério seria o da “distribuição ótima” no sentido de que as\n " +
                 "notas de menor valor fossem distribuídas em número mínimo possível. Por exemplo, se a quantia \n" +
                 "solicitada fosse R$ 87, 00 o programa deveria indicar uma nota de R$ 50, 00,três notas de R$ 10, 00,\n" +
                 " uma nota de R$ 5, 00 e duas notas de R$ 1, 00.Escreva um programa que receba o valor da quantia \n" +
                 "solicitada e retorne a distribuição das notas de acordo com o critério da “distribuição ótima”.");

Console.WriteLine("");

//Decraração da Variavel
decimal valor;


//Entrada de Dados
Console.WriteLine("Digite o valor do saque");
valor = decimal.Parse(Console.ReadLine());


//Processamento de Dados
Console.WriteLine("NOTAS:");
Console.WriteLine("{0} nota(s) de R$ 100.00", (int)valor / 100);

valor = valor % 100;
Console.WriteLine("{0} nota(s) de R$ 50.00", (int)valor / 50);

valor = valor % 50;
Console.WriteLine("{0} nota(s) de R$ 20.00", (int)valor / 20);

valor = valor % 20;
Console.WriteLine("{0} nota(s) de R$ 10.00", (int)valor / 10);

valor = valor % 10;
Console.WriteLine("{0} nota(s) de R$ 5.00", (int)valor / 5);

valor = valor % 5;
Console.WriteLine("{0} nota(s) de R$ 2.00", (int)valor / 2);




