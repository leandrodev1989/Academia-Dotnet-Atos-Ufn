
var pessoa = new List<Pessoa>
{
   new Pessoa () {Nome = "Carlos", Idade = 24, Nota = 8.0},
   new Pessoa () {Nome = "Alex", Idade = 33, Nota = 10},
   new Pessoa () {Nome = "Felipe", Idade = 31, Nota = 7.5},
   new Pessoa () {Nome = "João", Idade = 32, Nota = 8.2},
   new Pessoa () {Nome = "Douglas", Idade = 29, Nota = 6.5},
   new Pessoa () {Nome = "Lucas", Idade = 25, Nota = 7},
   new Pessoa () {Nome = "Daniel", Idade = 20, Nota = 8.2}
};


Console.WriteLine("== Aprovados ==========================");
var aprovados = pessoa.Where(a => a.Nota > 7)
    .OrderBy(a => a.Nome);
foreach (var aluno in aprovados)
{
    Console.WriteLine(aluno.Nome);
}

Console.WriteLine("\n== Chamada ===========================");

var chamada = pessoa.OrderBy(a => a.Nome).Select(a => a.Nome);

public class Pessoa
{
    public string Nome;
    public int Idade;
    public double Nota;

}

