/* 6.Faça um programa que leia um número n e imprima se ele é primo ou não. 
(um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!) */


/// <summary>
/// Recebe a entrada do numero para fazer a verificação
/// </summary>
int numero;

/// <summary>
/// faz a contagem do numero
/// </summary>
int i;

/// <summary>
/// recebe a validação do numero fazendo para verificar se é primo ou não
/// </summary>
int resultado = 0;



/// <summary>
/// Entrada de Dados
/// </summary>
Console.Write("Digite um Numero: ");
numero = int.Parse(Console.ReadLine());


/// <summary>
/// Processamento de Dados
/// </summary>
for(i =  2; i <= numero / 2; i++)
{
    if(numero % i == 0)
    {
        resultado++;
    }
}

if (resultado == 0)
{
    Console.WriteLine($"O numero {numero} é Primo! ");
}
else
{
    Console.WriteLine($"O numero {numero} não é Primo! ");
}
    
