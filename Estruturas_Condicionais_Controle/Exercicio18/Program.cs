/* 18-Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.*/

/// <summary>
/// recebe a entrada do primeiro valor e faz a validação se e maior
/// </summary>
int valor1;

/// <summary>
/// recebe a entrada do segundo valor e faz a validação se e maior
/// </summary>
int valor2;

/// <summary>
/// recebe a entrada do terceiro valor e faz a validação se e maior
/// </summary>
int valor3;


//entrada de dados
Console.Write("Digite o primeiro Valor: ");
valor1 = int.Parse(Console.ReadLine());

Console.Write("Digite o Segundo Valor: ");
valor2 = int.Parse(Console.ReadLine());

Console.Write("Digite o Terceiro Valor: ");
valor3 = int.Parse(Console.ReadLine());


//processamento de dados
if( valor1 > valor2 && valor1 > valor3)
{
    Console.WriteLine("O Primeiro Valor é Maior.");
}
else if( valor2 > valor1 && valor2 > valor3)
{
    Console.WriteLine("O Segundo Valor é Maior.");
}
else
{
    Console.WriteLine("O Terceiro Valor é Maior");
}

