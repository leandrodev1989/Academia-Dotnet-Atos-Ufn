/*Trabalho para entender e aplicar a teoria de Orientação a Objetos (terceirização), uso adequado de Listas e Arquivos.
Além disso, aplicar a ideia de menu de opções.

Construir um programa em VS que gerencie veículos em garagem. O programa deve ter um menu de operação. Os dados dos
veículos devem ser persistidos em arquivo e manipulados em uma lista dinâmica em memória.
Os dados dos veículos são : string placa; DateTime dataHoraEntrada.

MENU
1 - Cadastrar veículo entrando na garagem
2 - Exibir veículos cadastrados
3 - Sair
Opção: 

Observações: Criar a classe Veiculo (placa, dataHoraEntrada); usar as classes List, StreamReader, StreamWriter, DateTime
Use como base de dados o arquivo 'garagem.dat'. */

using Desafio7PrimeiraParte;


/// <summary>
/// Lista do OBjeto Veiculo
/// </summary>
List<Veiculo> listaveiculos = new List<Veiculo>();


/// <summary>
/// Classe de Serviços para chamar os metodos
/// </summary>
UtilServico.carregarListas(listaveiculos);



/// <summary>
/// variavél da opção do Menu
/// </summary>
string opcao = "";


/// <summary>
/// Criaçâo do menu 
/// </summary>
do
{
    
    Console.BackgroundColor = ConsoleColor.Blue;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("====================================------------- MENU-------------------------==================================");
    Console.WriteLine("==================================== BEM VINDO, SISTEMA GESTÃO DE GARAGEM      ==================================");
    Console.WriteLine("==================================== 1 - CADASTRAR VEÍCULO ENTRANDO NA GARAGEM ==================================");
    Console.WriteLine("==================================== 2 - EXIBIR VEÍCULOS CADASTRADOS           ==================================");
    Console.WriteLine("==================================== 3 - SAIR                                  ==================================");
    Console.WriteLine("==================================== OPÇÃO ------------------------------------==================================");
    opcao = Console.ReadLine();


    switch (opcao)
    {
        case "1":
           UtilServico.CadastrarVeiculos("Cadastrando Veículo", listaveiculos);
            break;
        case "2":
            UtilServico.exibirLista("Exibindo a lista de Veiculos Cadastrados", listaveiculos);
            break;
        case "3":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;


    }

    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();

} while (opcao != "3");
