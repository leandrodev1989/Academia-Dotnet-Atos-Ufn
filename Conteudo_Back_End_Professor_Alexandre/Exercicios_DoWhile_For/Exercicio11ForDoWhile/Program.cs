/*11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12. */
 
/// <summary>
/// inicia a contagem das notas
/// </summary>
double notaAlta = 0;

/// <summary>
/// usar como base a nota 12
/// </summary>
double notaBaixa = 12;

/// <summary>
/// recebe a nota da media geral da turma
/// </summary>
double mediaTurma ;

/// <summary>
/// armazena a total dos alunos
/// </summary>
int totalAlunos;

/// <summary>
/// recebe a notas da turma
/// </summary>
double notasTurmas;

/// <summary>
/// recebe  o somatorio das notas
/// </summary>
double SomaNotas =  0;


/// <summary>
/// entrada de dados
/// </summary>
Console.WriteLine("Qantidade de alunos na turma: ");
totalAlunos = int.Parse(Console.ReadLine());

for(int i = 0; i < totalAlunos; i++ )
{
    Console.WriteLine("Digite a Nota dos Alunos: ");
    notasTurmas = double.Parse(Console.ReadLine());

    SomaNotas += notasTurmas;

    if(notasTurmas > notaAlta)
    {
        notaAlta = notasTurmas;
    }

    if(notasTurmas < notaBaixa)
    {
        notaBaixa = notasTurmas;
    }

    
}
mediaTurma = SomaNotas / totalAlunos;
Console.WriteLine($"Nota Mais Alta: {notaAlta}");
Console.WriteLine($"Nota Mais baixa: {notaBaixa}");
Console.WriteLine($"Media Geral: {mediaTurma}");
Console.WriteLine($"Quantidade de Alunos da Turma: {totalAlunos}");