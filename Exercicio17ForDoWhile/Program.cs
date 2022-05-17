/*Apresentar os quadrados dos números inteiros de 15 a 200*/


int x;

for(x = 15; x <= 200; x++)
{
    if(x % 4 == 0)
    {
       
        Console.WriteLine($"Número divisível por 4 de 0 a 200 {x}");
    }
}