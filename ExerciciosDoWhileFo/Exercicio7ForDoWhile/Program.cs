/*7.Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 
A cada solicitação, teste se o usuário informou um valor válido. 
Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
informe que ele está incorreto e saia do programa em VS. 
Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
informe que está errada e saia. Se estiver correta, solicite o salário. 
Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
Se estiver correto, mostre todos os valores lidos. */





/// <summary>
/// variável para receber o nome
/// </summary>
string nome;

/// <summary>
/// variável para receber o idade
/// </summary>
int idade;


/// <summary>
/// variável para receber  o Salário
/// </summary>
float salario;

/// <summary>
/// Entrada de Dados
/// </summary>
    Console.Write("Digite Seu Nome: ");
    nome = Console.ReadLine();

/// <summary>
/// Processamento e validação de dados
/// </summary>
    if (nome == "" &&  string.IsNullOrEmpty(nome))
    {
        Console.Write("Nome não válido para seguir com o programa!");
        return;
        
        
    }
    else
    {
       Console.Write("Digite Sua Idade: ");
       idade = int.Parse(Console.ReadLine());

        if (idade <= 0)
        {
            Console.WriteLine("Idade incorreta! para seguir com o programa");
            return;
        }
        else
        {
            Console.Write("Digite Seu Salário: ");
            salario = float.Parse(Console.ReadLine());

            if(salario <= 0)
            {
                Console.WriteLine("Salário inválido.");
                return;
            }
            else
            {
               Console.WriteLine($"Nome: {nome} Idade: {idade} Anos Salário: {salario:F}");
            }

        }

    }

      


