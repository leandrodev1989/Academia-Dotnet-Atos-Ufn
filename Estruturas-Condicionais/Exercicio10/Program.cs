/*10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto. */

/// <summary>
/// entra com o nome do atleta 1
/// </summary>
string Nomeatleta1;

/// <summary>
/// entra com o nome do atleta 2
/// </summary>
string Nomeatleta2;


/// <summary>
/// entra com a idade do atleta 1
/// </summary>
int idadeatleta1;

/// <summary>
///  entra com a idade do atleta 2
/// </summary>
int idadeatleta2;

/// <summary>
///  entra com a altura do atleta 1
/// </summary>
float alturaatleta1;

/// <summary>
/// entra com a altura do atleta 2
/// </summary>
float alturaatleta2;


//entrada de dados
Console.WriteLine("Digite Seu nome atleta 1: ");
Nomeatleta1 = Console.ReadLine();

Console.WriteLine("Digite Sua idade atleta 1: ");
idadeatleta1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite Sua altura atleta 1");
alturaatleta1 = float.Parse(Console.ReadLine());

Console.WriteLine("===========================");

Console.WriteLine("Digite Seu nome atleta 2: ");
Nomeatleta2 = Console.ReadLine();

Console.WriteLine("Digite Sua idade atleta 2: ");
idadeatleta2 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite Sua altura atleta 2");
alturaatleta2 = float.Parse(Console.ReadLine());


//Processamento de dados
if(idadeatleta1 <  idadeatleta2 && alturaatleta1 > alturaatleta2)
{
    Console.WriteLine($"O atleta 1 e mais novo é mais alto: sua idade {idadeatleta1} sua altura{alturaatleta1}");
}
else
{
    Console.WriteLine($"O atleta 2 e mais novo é mais alto: sua idade {idadeatleta2} sua altura{alturaatleta2}");
}




