/*3.Fazer um laço(repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo. */




/// <summary>
/// Recebe o numero para validação
/// </summary>
int numero;


/// <summary>
/// Variável para Validar se a opção escolhida é Verdadeira ou falsa
/// </summary>
bool escolheunumero = false;

/// <summary>
/// Processamento de Dados
/// </summary>
while (escolheunumero == false)
{
    //entrada de Dados
    Console.Write("Digite um numero: ");
    numero = int.Parse(Console.ReadLine());

    if(numero == 0)
    {
       
        Console.WriteLine("Saindo do Programa!!");
        Console.WriteLine("Aperte ENTER.");
        escolheunumero = true;


    }
    else if (numero % 2 == 1)
    {
        Console.WriteLine("o Numero é Impar.");
        escolheunumero = false;
    }
    else if(numero % 2 == 0)
    {
        Console.WriteLine($"O numero é Par {numero} e Primo." );
        escolheunumero = true;

    }
    

}