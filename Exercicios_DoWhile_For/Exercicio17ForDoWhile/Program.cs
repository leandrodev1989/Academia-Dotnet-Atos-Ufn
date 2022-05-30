/*Apresentar os quadrados dos números inteiros de 15 a 200*/
/*exercicio 17*/



/// <summary>
///  variável que recebe  o mutiplicador para fazer a contagem
/// </summary>
int x;


/// <summary>
/// Processamento de Dados
/// </summary>
for(x = 15; x <= 200; x++)
{
  
    if(x % 4 == 0)
    {
       
        Console.WriteLine($"Número divisível por 4 de 0 a 200 {x}");
    }
}