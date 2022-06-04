// See https://aka.ms/new-console-template for more information


/* Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;
se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
da entrada e das duas prestações, de acordo com as regras acima. 
Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
conseqüente pagamento dos boletos das duas prestações. */

Console.WriteLine("");

/// <summary>
/// variável para receber a entrada da mercadoria
/// </summary>
float ValorMercadoria;

/// <summary>
/// variável responsável para fazer a divisão das parcelas
/// </summary>
int Parcelas;

//Entrada de dados
Console.Write("Informe o valor da Mercadoria: ");
ValorMercadoria = float.Parse(Console.ReadLine());
Console.WriteLine();

//processamento de dados
var Prestacao1 = ValorMercadoria / 3;
var Prestacao2 = Prestacao1;
var ValorEntrada = ValorMercadoria - (Prestacao1 + Prestacao2);

    Console.WriteLine($"O Valor de entrada  {ValorEntrada:F} \n" +
   $" Valor da primeira prestação {Prestacao1:F} \n" +
   $"valor da segunda prestação {Prestacao2:F}");









