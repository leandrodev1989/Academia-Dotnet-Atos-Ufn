/*Escrever um algoritmo para ler duas notas de um aluno
e escrever na tela a palavra “Aprovado” se a média das duas notas for maior ou igual a 7,0.
Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final.
Se esta média for maior ou igual a 5,0, o programa deve escrever “Aprovado”,
caso contrário deve escrever “Reprovado”.*/


/// <summary>
/// Recebe a priemeira nota
/// </summary>
float nota1;


/// <summary>
/// Recebe a segunda nota
/// </summary>
float nota2;

/// <summary>
/// faz a soma das notas e divide / 2
/// </summary>
float media;


//Entrada de dados
Console.Write("Digite a Primeira Nota: ");
nota1 = float.Parse(Console.ReadLine());
Console.WriteLine("");

Console.Write("Digite a Segunda Nota: ");
nota2 = float.Parse(Console.ReadLine());
Console.WriteLine("");

//processamento
media = (nota1 + nota2 )/ 2;


Console.WriteLine($"A media é: {media:F1}");

if(media >= 7)
{
    Console.WriteLine("Aprovado");
}
else if(media < 7)
{
    Console.Write("Digite a Nota do Exame: ");
    media = float.Parse(Console.ReadLine());

    var MediaFinal = nota1 + nota2 + (media / 2);

    if(MediaFinal >= 5)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}
