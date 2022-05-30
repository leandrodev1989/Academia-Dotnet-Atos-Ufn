/*#3
Os quatro pilares do paradigma de Orientação a Objetos são:

A - Sequenciamento, Procedimentos, Bibliotecas e Herança.
B - Herança, Polimorfismo, Classes e Objetos.
C - Classes, Atributos, Métodos e Abstração.
D - Abstração, Encapsulamento, Herança e Polimorfismo. */


/// <summary>
/// VARIAVEL PARA FAZER A ESCOLHA
/// </summary>
string opcao = "";


/// <summary>
/// EXIBIÇÃO DE DADOS E PROCESSAMENTO DE DADOS
/// </summary>
do
{
    
    Console.Clear();
    Console.WriteLine("QUAL DAS OPÇÕES É VERDADEIRA?");
    Console.WriteLine("OPÇÃO => A  Sequenciamento, Procedimentos, Bibliotecas e Herança.?");
    Console.WriteLine("OPÇÃO => B  Herança, Polimorfismo, Classes e Objetos.?");
    Console.WriteLine("OPÇÃO => C  Classes, Atributos, Métodos e Abstração.?");
    Console.WriteLine("OPÇÃO => D  Abstração, Encapsulamento, Herança e Polimorfismo.?");
    string opçao = Console.ReadLine();


    
    switch (opçao)
    {
        case "A":
            Console.WriteLine("resposta incorreta!!");
            break;

        case "B":
            Console.WriteLine("resposta incorreta!!");
            break;

        case "C":
            Console.WriteLine("resposta incorreta!!");
            break;

        case "D":
            Console.WriteLine("Parabéns Resposta Correta!!");
            break;
        default:
            Console.WriteLine("aperte enter para sair");
            break;

    }

    Console.ReadKey();

} while (opcao == "D");
