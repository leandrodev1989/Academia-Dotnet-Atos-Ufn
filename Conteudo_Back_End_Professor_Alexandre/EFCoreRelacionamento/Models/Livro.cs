namespace EFCoreRelacionamento.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public Autor Autor { get; set; }
    }
}
