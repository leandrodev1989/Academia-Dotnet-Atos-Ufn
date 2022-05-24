/*14.Mostrar as potências de 2 variando de 0 a 10. */

/// <summary>
/// Recebe a contagem da pontência elevado
/// </summary>
double PotenciaDe0A100;


/// <summary>
/// Processamento de dodos Com o i como contador
/// </summary>
for (int i = 0; i <= 10; i++)
{
    PotenciaDe0A100 = Math.Pow(2, i);
    Console.WriteLine(PotenciaDe0A100);
}