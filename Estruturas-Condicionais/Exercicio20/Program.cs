/*20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
plus: você pode gerar o número de forma randomica (função random c#) */

/// <summary>
/// Inicia o  palpite em 0
/// </summary>
int Palpite = 0;

/// <summary>
/// Gera um numero aleátorio
/// </summary>
 Random random= new Random();

/// <summary>
/// Numero gerado entre 1 e 10
/// </summary>
int NumeroSecreto = random.Next(1, 15);

/// <summary>
/// numero so é encontardo se for verdade
/// </summary>
bool numeroEncontrado = false;

/// <summary>
/// numero definido de tentativas pelo usuario
/// </summary>
int TentativasRestantes = 3;

/// <summary>
/// tentativas inicia com zero
/// </summary>
int tentativas = 0;
//Processamento de Dados
while(TentativasRestantes > 0 && !numeroEncontrado)
{
    Console.Write("Insira Seu Palpite: ");
    string entrada = Console.ReadLine();
    int.TryParse(entrada, out Palpite);
    Console.WriteLine("");

    tentativas++;
    TentativasRestantes--;

    if(NumeroSecreto == Palpite)
    {
        numeroEncontrado = true;
        Console.WriteLine("Numero encontrado em {0} tentivas", tentativas);
        Console.WriteLine("Parabéns!!");
        Console.WriteLine("");
    }
    else if(Palpite > NumeroSecreto)
    {
        Console.WriteLine("Menor.. Tente novamente!");
        Console.WriteLine("Tentativas restantes: {0}", TentativasRestantes);
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("Maior.. Tente novamente!");
        Console.WriteLine("Tentativas restantes {0}", TentativasRestantes);
       
    }
    
}

