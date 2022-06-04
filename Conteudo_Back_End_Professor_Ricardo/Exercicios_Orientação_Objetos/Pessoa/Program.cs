


using Pessoa;

List<DadosPessoa> pessoa = new List<DadosPessoa>();


/// <summary>
/// Entrada e Processamento de Dados
/// </summary>
Console.WriteLine("Entre com os Seis Dados");
Console.WriteLine("");
Console.WriteLine("Digite seu Nome");
string nome = Console.ReadLine();
Console.WriteLine("");

Console.WriteLine("Digite sua idade");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite seu Sexo");
char sexo = char.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Digite sua altura");
double  altura = double.Parse(Console.ReadLine());
Console.WriteLine("");


/// <summary>
/// Adicionando os dados da pessoa na Lista
/// </summary>
 pessoa.Add ( new DadosPessoa(nome, idade, sexo, altura));



/// <summary>
/// Fazendo a contagem e exibindo os Dados da pessoa
/// </summary>
for(int i = 0; i < pessoa.Count; i++)
{
    pessoa[i].Exibir();
}