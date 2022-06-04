namespace ExercicioLINQ
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;

    }
    class Program
    {
        public static void Main(string[] args)
        {
            var alunos = new List<Aluno>
            {
                new Aluno() {Nome = "Carlos", Idade = 24, Nota = 8.0},
                new Aluno() {Nome = "Leandro", Idade = 33, Nota = 9.0},
                new Aluno() {Nome = "Lucas", Idade = 21, Nota = 6.0},
                new Aluno() {Nome = "Fred", Idade = 26, Nota = 7.0},
                new Aluno() {Nome = "Lima", Idade = 20, Nota = 8.0},
                new Aluno() {Nome = "Julia", Idade = 22, Nota = 7.8},
                new Aluno() {Nome = "Lima", Idade = 23, Nota = 7.5}
                
            };

            Console.WriteLine("== Aprovados ==========================");
            var aprovados = alunos.Where(a => a.Nota > 7)
                .OrderBy(a => a.Nome);
            foreach(var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\n== Chamada ===========================");

            var chamada = alunos.OrderBy(a => a.Nome).Select(a => a.Nome);
        }

    }
}






