/*13.Elaborar um programa que apresente o somatório dos valores pares existentes 
entre 1 e 500. */



/// <summary>
/// variavel responsavel por iniciar a soma
/// </summary>
int n1 = 0;

/// <summary>
/// recebe o contador
/// </summary>
int i;

for (i = 1; i <= 500; i++)
{
    if (i % 2 == 0)
        n1 = n1 + i;

    Console.WriteLine($" A soma dos cem primeiros números é {n1}");
}