/*12 Apresentar o total da soma dos cem primeiros números inteiros.*/







/// <summary>
/// variavel que faz a inicialização
/// </summary>
int x; 

/// <summary>
/// variavel responsavel por fazer o somatoria
/// </summary>
int  soma = 0;


for (x = 1; x <= 100; x++)
{
    soma = soma + x;

    Console.WriteLine($"A soma dos 100 primeiros numeros inteiros é {soma}");
}