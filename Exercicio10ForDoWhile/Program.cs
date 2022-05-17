/*10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres. */



string nome;
string sexo;
int idade;
int cont = 0;

while (cont < 50)
{
    Console.Write("Digite o nome: ");
    nome = Console.ReadLine();

    Console.Write("Digite seu Sexo: ");
    sexo = Console.ReadLine();

    Console.Write("Digite sua Idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.Clear();
}
