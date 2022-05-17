/*6.Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada. */





/// <summary>
/// Recebe a idade do usuario
/// </summary>
int idade;

/// <summary>
/// Verifica se a informação é verdadeira ou false
/// </summary>
bool escolheuIdade = false;


/// <summary>
/// Processamento de Dados
/// </summary>
while (escolheuIdade == false)
{
    Console.Write("Digite Sua Idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade > 0)
    {
        Console.WriteLine($"Dados informados Correto sua Idade: {idade} anos");
        Console.WriteLine("Saindo da Aplicação.");
        escolheuIdade = true;
    }
    else if(idade <= 0)
    {
        Console.WriteLine("Idade Inválida!!");
        escolheuIdade = false;
    }
}