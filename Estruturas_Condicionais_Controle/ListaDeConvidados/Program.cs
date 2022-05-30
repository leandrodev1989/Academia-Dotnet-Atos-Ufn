
namespace ListaDeCoovidados
{
    class Program
    {
        
        public static void Main(string[] atgs)
        {
            Console.Write("Informe o Nome do Convidado: ");
            var nome = Console.ReadLine();

            if(nome == null || string.IsNullOrEmpty(nome) || string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome não válido para seguir com o programa!");
                return;
            }

            Console.Write("Informe a Idade do Convidado: ");
            var idadeString = Console.ReadLine();
            int idade;

            bool idadeInformada = int.TryParse(idadeString, out idade);
            if(idadeInformada == false)
            {
                Console.WriteLine("Idade não Informada para seguir no Programa");
                return;
            }

            bool estaConvidado;
            switch (nome)
            {

                case "Leandro":
                    estaConvidado = true;
                    break;
                case "Evandro":
                    estaConvidado = true;
                    break;
                case "Fernando":
                    estaConvidado = true;
                    break;
                case "José":
                    estaConvidado = true;
                    break;
                case "Carlos":
                    estaConvidado = true;
                    break;
                case "Teresa":
                    estaConvidado = true;
                    break;
                case "Fernanda":
                    estaConvidado = true;
                    break;
                default:
                    estaConvidado = false;
                    break;

            }

            if(estaConvidado == true && idade > 18)
            {
                Console.WriteLine("Parabéns Seja Bem vindo a festa!");
            }
            else if(estaConvidado == false)
            {
                Console.WriteLine("Voçê não estar na Lista de Convidado, favor verificar com a pessoa que te convidou!");
            }
            else
            {
                Console.WriteLine("Voçê não tem 18 anos para entrar na festa");
            }
        }
    }
}



