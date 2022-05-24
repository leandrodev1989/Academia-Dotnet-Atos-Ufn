namespace ListasLINQ
{
    public class Pacote
    {
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Codigo { get; set; }
        public DateTime DataPostagem { get; set; }
        public string Status { get; set; }


        public Pacote(string titulo, string descricao)
        {
            Titulo = titulo;
            Descricao = descricao;

            Codigo = GerarCodigo();
            DataPostagem = DateTime.Now;
            Status = "Postado";


        }

        private string GerarCodigo()
        {
            return Guid.NewGuid().ToString();
        }

        public void AtualizarStatus(string status)
        {
            Status = status;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Pacote {Titulo} Com o Código {Codigo} estar com status {Status}");
        }
    }

    public class PacotePremium : Pacote
    {
        public PacotePremium(string titulo, string descricao, string voo) : base (titulo, descricao)
        {
            
        }

        public string Voo { get; set; }

        public override void ExibirDetalhes()
        {
            base.ExibirDetalhes();
            Console.Write($"Com voo ABC {Voo}");
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {

            var pacotes = new List<Pacote>();

            Console.WriteLine("===== DevTrack - Serviço de Postagem =====");

            ExibirMensagem();

            var opcao = Console.ReadLine();

            while (opcao != "0")
            {
                switch (opcao)
                {
                    case "1":
                        CadastrarPacote();
                        break;
                    case "2":
                        AtualizarPacote();
                        break;
                    case "3":
                        ConsultarPacote();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;

                }

                ExibirMensagem();
                opcao = Console.ReadLine();
            }

            void ExibirMensagem()
            {
                Console.WriteLine("Digite o código de acordo com o que voçê quer.");
                Console.WriteLine("");
                Console.WriteLine("1- Cadastro de Pacote");
                Console.WriteLine("2- Atualizar Pacote");
                Console.WriteLine("3- Consultar Pacote");
                Console.WriteLine("4- Sair da Aplicação");
                Console.WriteLine("");
            }

            void CadastrarPacote()
            {
                Console.WriteLine($"Digite o titulo.");
                var titulo = Console.ReadLine();

                Console.WriteLine($"Digite a Descrição.");
                var descricao = Console.ReadLine();

                var pacote = new Pacote(titulo, descricao);

                pacotes.Add(pacote);

                Console.WriteLine($"Pacote com o Código  {pacote.Codigo} foi cadastrado com sucesso!");
            }

            void AtualizarPacote()
            {
                Console.WriteLine($"Digite o Código do pacote.");
                var codigo = Console.ReadLine();

                var pacote = pacotes.SingleOrDefault(p => p.Codigo == codigo);

                if(pacote == null)
                {
                    Console.WriteLine("Pacote não encontrado!");
                    return;
                }

                Console.WriteLine("Digite o status atual.");
                var status = Console.ReadLine();

                pacote.AtualizarStatus(status);
                Console.WriteLine("Pacote Atualizado com sucesso.");


            }

            void ConsultarPacote()
            {
                Console.WriteLine("Digite o código do pacote");
                var codigo = Console.ReadLine();

                var pacote = pacotes.SingleOrDefault(p => p.Codigo == codigo);

                if(pacote == null)
                {
                    Console.WriteLine("Pacote não encontrado!");
                    return;
                }

                pacote.ExibirDetalhes();
            }

            var pacotePremium = new PacotePremium("Pacote premium", "Um pacote premium", "Voo ABC");
            var pacote = new Pacote("Pacote Normal", "Um Pacote Normal.");

            var conjuntoPacotes = new List<Pacote> { pacotePremium, pacote };

            foreach(var item in conjuntoPacotes)
            {
                item.ExibirDetalhes();
            }



        }
        
         
    }

       
    
}