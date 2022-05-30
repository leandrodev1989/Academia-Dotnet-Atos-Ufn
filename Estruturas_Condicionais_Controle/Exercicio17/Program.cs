/*17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
os lados iguais), isoceles(somente 2 lados são iguais) ou escaleno(os 3 lados são diferentes).*/


/// <summary>
/// recebe o valor de A para fazer a validação
/// </summary>
int a;

/// <summary>
/// recebe o valor de B para fazer a validação
/// </summary>
int b;

/// <summary>
/// recebe o valor de C para fazer a validação
/// </summary>
int c;


//Entrada de dados
Console.WriteLine("Digite O Valor de A Primeiro Valor: ");
a = int.Parse(Console.ReadLine());

Console.WriteLine("Digite O Valor de B Primeiro Valor: ");
b = int.Parse(Console.ReadLine());


Console.WriteLine("Digite O Valor de C Primeiro Valor: ");
c = int.Parse(Console.ReadLine());


//processamento de dados
if(a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("O 3 Lados formam um triangulo!");
    if(a == b && a == c)
    {
        Console.WriteLine("Equilatero");

    }
    else if( a == b || a == c || b == c)
    {
        Console.WriteLine("Isósceles");
    }
    else
    {
        Console.WriteLine("Escaleno");
    }
}
else
{
    Console.WriteLine("Os 3 Lados não Formam um Triângulo");
}



