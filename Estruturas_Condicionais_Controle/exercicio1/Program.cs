/*Faça um algoritmo para calcular e mostrar a área de um triângulo a partir 
 * dos valores da base e da altura lidos pelo teclado: Área do triangulo = (base * altura) / 2;
   Teste se a base ou a altura digitada não foi igual a zero.*/



/// <summary>
///  Variável para receber a informação da base do triângulo
/// </summary>
double basedotriangulo = 0;

/// <summary>
///  Vaariável para receber a informação da altura do triângulo
/// </summary>
double alturadotringulo = 0;

/// <summary>
/// Variável resposanvel por fazer a operação do calculo da Area do Triângulo
/// </summary>
double AreadoTriangulo;


//Entrada de Dados
Console.WriteLine("Calculo Área do Triângulo");
Console.WriteLine("");

Console.Write("Digite a Base do Triângulo: ");
basedotriangulo = double.Parse(Console.ReadLine());

Console.Write("Digite a Altura do Triângulo: ");
alturadotringulo = double.Parse(Console.ReadLine());


//Processamento de Dados
if (basedotriangulo == 0)
{
    Console.WriteLine("A Base não pode receber valor 0");
}
else if (alturadotringulo == 0)
{
    Console.WriteLine("A Altura não pode receber o valor 0");
}

AreadoTriangulo = (basedotriangulo * alturadotringulo) / 2;

Console.WriteLine($"A Área do Triangulo é: {AreadoTriangulo}");