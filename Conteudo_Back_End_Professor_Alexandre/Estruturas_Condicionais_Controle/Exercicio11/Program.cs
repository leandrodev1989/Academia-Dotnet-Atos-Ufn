/*11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
O programa deve exibir se a hora digitada está ou não válida. 
Lembre que usaremos o padrão de hora com 24h, de 0 a 23. */


int hora;
decimal minutos;

Console.Write("Entre com a hora: ");
hora = int.Parse(Console.ReadLine());

Console.Write("Entre com os Minutos: ");
minutos = decimal.Parse(Console.ReadLine());

if(hora <= 24 && minutos <= 60)
{
    Console.WriteLine($"O Hora no Formato Correto: {hora}:{minutos}");
}
else
{
    Console.WriteLine("Formato Incorreto de Hora");
}
