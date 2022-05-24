/*10.Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres. */



string nome;
char sexo;
int idade;
int IdadeMulheres = 0;
int TotalPessoasSexoM = 0;
int TotalPessoasSexoF = 0;
int IdadeMenor30Anos = 0;
int IdadeMaior60Anos = 0;
double media;



for(int i = 0; i < 2; i++)
{

    Console.Write("Digite o nome: ");
    nome = Console.ReadLine();

    Console.Write("Qual é o  seu Sexo? : ");
    sexo = char.Parse(Console.ReadLine().ToUpper());

    Console.Write("Digite sua Idade: ");
    idade = int.Parse(Console.ReadLine());

    if (sexo == 'M')
    {
        TotalPessoasSexoM++;
    }
    else
    {
        TotalPessoasSexoF++;
        IdadeMulheres += IdadeMulheres;
        
    }

    if(idade < 30)
    {
       IdadeMenor30Anos++;
    }
    else if(idade > 60)
    {
        IdadeMaior60Anos++;
    }

    Console.WriteLine("==================");



}

media =    IdadeMulheres  / TotalPessoasSexoF ;

Console.WriteLine($"Total de NUmero de Pessoas do Sexo (M) é de :{TotalPessoasSexoM}");
Console.WriteLine($"Total de NUmero de Pessoas do Sexo (F) é de :{TotalPessoasSexoF}");
Console.WriteLine($"Número de pessoas com idade inferior a 30 anos é de :{IdadeMenor30Anos}");
Console.WriteLine($"Número de pessoas com idade Superior a 60 anos é de :{IdadeMaior60Anos}");
Console.WriteLine($"Média de idade das Mulheres: {media}");