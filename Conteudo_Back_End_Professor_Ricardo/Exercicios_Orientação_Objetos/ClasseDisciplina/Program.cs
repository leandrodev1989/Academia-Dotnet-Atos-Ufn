using ClasseDisciplina;


/// <summary>
/// Entrada de Dados e Processamento
/// </summary>
Console.WriteLine("Escreva Seu Nome");
string nome = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Escreva a Carga Horaria");
int  cargahoraria = int.Parse(Console.ReadLine());
Console.WriteLine("");

Disciplina disciplina = new Disciplina(nome, cargahoraria);

disciplina.ExibirDados();