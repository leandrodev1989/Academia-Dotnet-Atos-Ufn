/*#4
Imagine um jogo com asteroides e uma nave de ataque, que deve destruir os asteróides que voam em todas as direções. Dessa forma, crie um programa em C# que represente
uma lista de asteroides que deveriam ser 'inseridos' no jogo. Para isso, faça uma classe que contenha os atributos (privados) posição x, posição y (do asteroide em
um plano cartesiano), tamanho do asteroide(1 a 10), velocidade do asteroide(1 a 5) e energia(1 a 5).Para esses atributos privados, gerar os métodos de acesso
(propriedades getter e setter). Além disso, implementar 3 construtores (sobrecarga): um vazio, outro passando todos os parâmetros de um objeto tipo Asteroide, e um 
terceiro que constrói um asteroide com posição x e posição y. 
O programa principal (main) deve conter a lista de Asteroides, preenchida pelo usuário. Nesse programa principal, construir um método de classe que exiba todos os
asteróides da lista. */


using Exercicio4;

 List<Asteroide> asteroides = new List<Asteroide>();

/// <summary>
///  1 a 10
/// </summary>
int tamanhodoasteroide = 0;

/// <summary>
/// 1 a 5
/// </summary>
int energia = 0;

/// <summary>
/// 1 a 5
/// </summary>
int velocidadeasteroide = 0;

/// <summary>
/// simulação dentro do plano cartesiano posião X
/// </summary>
int  posicaoxasteroide = 0;

/// <summary>
///  simulação dentro do plano cartesiano posião Y
/// </summary>
int posicaoyasteroide = 0;


/// <summary>
/// Entrada e Processamento de Dados
/// </summary>
for (int i = 0; i < 2; i++)
{

    
    Console.Clear();
    Console.WriteLine("[Bem Vindo, Ao Space Asteroides.]");
    Console.WriteLine("");
    Console.WriteLine("Escreva o Nome do Asteroide");
    string nome = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Escreva o Tamanho do Asteroide");
    tamanhodoasteroide = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Escreva a Energia  do Asteroide");
    energia = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Escreva a  Velocidade do Asteroide");
    velocidadeasteroide = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Escreva A Posição (X) do Asteroide");
    posicaoxasteroide = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    Console.WriteLine("Escreva A Posição (Y) do Asteroide");
    posicaoyasteroide = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    
    asteroides.Add(new Asteroide (nome,tamanhodoasteroide, energia,velocidadeasteroide, posicaoxasteroide, posicaoyasteroide));
}


/// <summary>
/// Exibir Tipos de Asteroides na Lista
/// </summary>
for(int i = 0; i <asteroides.Count; i++)
{
    Console.WriteLine(asteroides[i].ExibirDadosAsteroides());
    Console.WriteLine("==================");
}
