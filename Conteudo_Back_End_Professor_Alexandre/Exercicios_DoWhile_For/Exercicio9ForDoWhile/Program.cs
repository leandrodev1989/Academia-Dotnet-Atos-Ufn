/*9.Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo:
Quantas pessoas tem entre 1 e 3 filhos.
Quantas pessoas tem entre 4 e 7 filhos.
Quantas pessoas tem mais de 8 filhos.
Quantas pessoas não tem filhos. */



/// <summary>
/// variável recebe a contagem dos filhos
/// </summary>
int QunatidadeFilhos = 0;

/// <summary>
/// variavel que adiciona a quantidade de filhos entre 1 e 3
/// </summary>
int Entre1e3Filhos = 0;

/// <summary>
/// variavel que adiciona a quantidade de filhos entre 4 e 7
/// </summary>
int Entre4e7Filhos = 0;

/// <summary>
/// variavel que adiciona a quantidade de filhos mais de 8
/// </summary>
int Mais8Filhos = 0;

/// <summary>
/// variavel que não adiciona filhos
/// </summary>
int NaoteFilhos = 0;



/// <summary>
/// Processamento de Dados
/// </summary>
for (int i = 0; i < 30; i++)
{
    Console.Write("Quantos Filhos Voçê Tem? ");
    QunatidadeFilhos = int.Parse(Console.ReadLine());

    if (QunatidadeFilhos > 0 && QunatidadeFilhos <= 3)
    {
        Entre1e3Filhos++;
    }
    else if (QunatidadeFilhos > 3 && QunatidadeFilhos <= 7)
    {
        Entre4e7Filhos++;
    }
    else if (QunatidadeFilhos > 7)
    {
        Mais8Filhos++;
    }
    else
    {
        NaoteFilhos++;
    }
}

/// <summary>
/// Exibição dos Dados inserido pelo usuario
/// </summary>
Console.WriteLine($"Quantidade de Pessoas que tem entre 1 e 3 filhos: {Entre1e3Filhos}\nQuantidade de Pessoas que tem entre 4 e 7 filhos: {Entre4e7Filhos}\n" +
    $"Quantidade de Pessoas que tem Mais de 8 filhos: {Mais8Filhos}\nQuantidade de Pessoas que não tem filhos: {NaoteFilhos}");