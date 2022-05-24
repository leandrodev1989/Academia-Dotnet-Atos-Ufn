//Exercicio desafio de string
//fazer um programa que receba o nome completo e
//exiba em maiusculo o primeiro nome e o úiltimo sobrenome dessa pessoa

//fazer um programa que receba o nome completo e o exiba abreviado


namespace ExercicioDeFixacao
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Exercícios desafio de string
            //Fazer um programa que receba  o nome completo de uma pessoa e
            //exiba em maiúsculo o primeiro nome e o último sobrenome dessa pessoa.

            //Fazer um programa que receba o nome completo de uma pessoa e o
            //exiba abreviado

            /// <summary>
            /// armazena o nome completo informado pelo usuario
            /// </summary>
            string NomeCompleto;

            /// <summary>
            /// vetor de string que recebe o split das palavras do nomeCompleto
            /// </summary>
            string[] palavras;

            /// <summary>
            /// armazena o primeiro nome do nome completo
            /// </summary>
            string PrimeiroNome;

            /// <summary>
            /// armazena o último sobrenome de um nome completo
            /// </summary>
            string UltimoSobreNome;


            //receber um nome completo
            Console.Write("Digite um nome completo: ");
            NomeCompleto = Console.ReadLine();
            NomeCompleto = NomeCompleto.ToUpper();

            //splitar o nome completo por espaço em branco
            palavras = NomeCompleto.Split(" ");

            PrimeiroNome = palavras[0];
            UltimoSobreNome = palavras[palavras.Length - 1];

            Console.WriteLine("Seu primeiro nome: " + PrimeiroNome);
            Console.WriteLine("Seu último sobrenome: " + UltimoSobreNome);






        }
    }
}
