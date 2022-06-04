/* 5.Escreva um programa em C# que gera números entre 1000 e 1999 e mostra aqueles que divididos
por 11 dão resto 5. */



/// <summary>
/// Faz a contagem de 1000 a 1999 validando e mostrando o resto da divisão por 11 == 5
/// </summary>
for(int i = 1000; i <= 1999; i++)
{
    if(i % 11 == 5)
    {
        Console.WriteLine($"Os Numeros dividos por 11 resto 5 São: {i}");
    }

    
}