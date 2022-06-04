/*Imprima uma tabela de conversão de polegadas para centímetros, de 1 a 20. Considere que
Polegada = Centímetro * 2,54. */


/// <summary>
/// VALOR DIGITADO PELO USUARIO PARA SER CONVERTIDO
/// </summary>
float centimentro = 1;

/// <summary>
/// CONTA A QUANTIDADE DE VEZES QUE O NUMERO VAI SER MULTIPLICADO
/// </summary>
int contador;

/// <summary>
/// RECEBE A CONVERSÃO DE CENTIMETRO PARA POLEGADA * 2,54
/// </summary>
double polegada;



/// <summary>
/// ENTRADA DE DADOS
/// </summary>
Console.WriteLine("NUMERO|CENTÍMETRO|POLEGADA|");

/// <summary>
/// PROCESSAMENTO DE DADOS
/// </summary>
for(contador = 0; contador < 20; centimentro++)
{
    polegada = centimentro * 2.54;
    contador++;

   
    Console.WriteLine($"  {contador}   |{contador}*2,54      |{polegada:F} ");
   
}




