                  
using OOP;


/// <summary>
/// Entrada e Processamento de Dados
/// </summary>
Console.WriteLine("Digite o titulo");
string titulo = Console.ReadLine();
Console.WriteLine("Digite o autor");
string autor = Console.ReadLine();
Console.WriteLine("Digite a pagina");
int pagina = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano");
int ano = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o ano de edição");
int edicao = int.Parse(Console.ReadLine());
Console.WriteLine("");

ClasseLivro livro = new ClasseLivro(titulo, autor,pagina,ano,edicao);
livro.Exibir();