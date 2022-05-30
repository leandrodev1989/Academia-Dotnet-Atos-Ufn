/*7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.*/

/// <summary>
/// Recebeo  nome de qualquer frase
/// </summary>
string frase;

/// <summary>
/// nome que o sistema tem que comparar
/// </summary>
string palavra = "sistema";


//entrada de dados
Console.Write("Digite uma frase qualquer: ");
frase = Console.ReadLine();


//processamento de Dados
if(frase == palavra)
{
    Console.WriteLine("A palavra encontra-se na frase.");
}
else
{
    Console.WriteLine("A palavra não se encontra na frase.");
}
