/*15.Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
Considerar nota 7,0 como mínima para aprovação. */

/// <summary>
/// Lista Criada para guarda as informações das notas
/// </summary>
List<double> notasDoAluno = new List<double>();

/// <summary>
/// Recebe as notas 
/// </summary>
double NotasDoAluno;

/// <summary>
/// faz  o calculo da soma das notas para fazer a media final
/// </summary>
double MediaParaAprovacao;



/// <summary>
/// Processamento de Dados
/// </summary>
for (int i = 0; i < 4; i++)
{
    Console.Write("Digite Suas 4 Notas:");
    NotasDoAluno = double.Parse(Console.ReadLine());

    notasDoAluno.Add(NotasDoAluno);

}

MediaParaAprovacao = (notasDoAluno[0] * 2) + (notasDoAluno[1] * 1) + (notasDoAluno[2] * 2) + (notasDoAluno[3] * 4) / (2 + 1 + 2 + 4);

if(MediaParaAprovacao >= 7.0)
{
    Console.WriteLine("Aprovado!!");
}
else
{
    Console.WriteLine("Reprovado!!");
}

Console.WriteLine($"Sua Media: {MediaParaAprovacao:F}");

    





   




//M = P1N1 + P2N2 + P3N3
//       P1 + P2 + P3

//M = 1·7 + 3·6 + 5·4
//       1 + 3 + 5

//M = 7 + 18 + 20
//     9

//M = 45
//       9

//M = 5