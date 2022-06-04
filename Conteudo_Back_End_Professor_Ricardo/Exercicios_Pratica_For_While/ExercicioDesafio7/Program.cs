
/*7.Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa 
sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros
números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo 
que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci. */



/// <summary>
/// recebe o termo anterior valendo 0
/// </summary>
int termoAnterior = 0;

/// <summary>
/// recebe o termo atual valendo 1
/// </summary>
int termoAtual = 1;

/// <summary>
/// faz a soma recebendo o termo anterior +  o termo atual
/// </summary>
int soma = termoAnterior + termoAtual;


/// <summary>
/// enxibião de dados
/// </summary>
Console.Write(0 + ", " + 1 + ", ");



/// <summary>
/// Processamento de dados
/// </summary>
for(int i = 1; i < 20; i++)
{
    
    Console.Write(soma + ", ");
    termoAnterior = termoAtual;
    termoAtual = soma;
    soma = termoAnterior + termoAtual;
}