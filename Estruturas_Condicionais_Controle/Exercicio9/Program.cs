/*9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.*/



/// <summary>
/// recebe o valor da primeira dose
/// </summary>
int valorDiarioGlicemia1;


/// <summary>
/// recebe o valor da segunda dose
/// </summary>
int valorDiarioGlicemia2;

/// <summary>
/// recebe o valor da terceira dose
/// </summary>
int valorDiarioGlicemia3;

/// <summary>
/// Valida se todas as doses foram tomadas e se estão dentro das exigências
/// </summary>
float valordiariofinal;


//Entrada de Dados
Console.Write("Informe o Valor da Primeira Dose: ");
valorDiarioGlicemia1 = int.Parse(Console.ReadLine());

Console.Write("Informe o Valor da Segunda Dose: ");
valorDiarioGlicemia2 = int.Parse(Console.ReadLine());

Console.Write("Informe o Valor da Terceira Dose: ");
valorDiarioGlicemia3 = int.Parse(Console.ReadLine());

//Processamento de dados
valordiariofinal = (valorDiarioGlicemia1 + valorDiarioGlicemia2 + valorDiarioGlicemia3) / 3;

if (valordiariofinal < 65)
{    
    Console.WriteLine($"Valor Diário Final: {valordiariofinal}");
    Console.WriteLine("Voçê corre o risco de hipoglicemia!");
}
else if(valordiariofinal > 250)
{
    
    Console.WriteLine($"Valor Diário Final: {valordiariofinal}");
    Console.WriteLine("Voçê corre o risco de hiperglicemia!");
}