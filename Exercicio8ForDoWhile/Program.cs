/*8.Faça um programa em VS que solicite um numero inteiro. S
e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS. */



/// <summary>
/// recebe o numero para verificar se é par ou impar
/// </summary>

int numero ;

/// <summary>
/// valida a opção de sim ou não
/// </summary>
string op;


/// <summary>
/// Valida se o verdadeiro ou falso
/// </summary>
bool escolheu = false;


/// <summary>
/// Processamento de Dados
/// </summary>


while (escolheu == false)
{
    Console.WriteLine("Digite um numero inteiro: ");
    numero = int.Parse(Console.ReadLine());

    if (numero % 2 == 0)
    {
        Console.WriteLine($"O numero é par: {numero}");

    }
    else if (numero % 2 == 1)
    {
        Console.WriteLine($"O numero é Impar:{numero} ");
    }

    Console.WriteLine("Deseja informar outro numero? (S / N)");
    op = Console.ReadLine();


    if (op == "N".ToLower())
    {
        Console.WriteLine("Saindo do Programa");
        break;

    }
    else
    {
        escolheu = false;
    }
}




