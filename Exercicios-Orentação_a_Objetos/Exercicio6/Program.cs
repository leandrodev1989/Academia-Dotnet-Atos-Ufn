/*#6
Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
um método para exibir um objeto (x, y).
Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
os objetos da lista. */



using Exercicio6;

List<PlanoCartesiano> cartesianolista = new List<PlanoCartesiano>();


/// <summary>
/// informações de entrada para receber valores
/// </summary>
int n;
int posicaox = 0;
int posicaoy = 0;



/// <summary>
/// Entrada de dados
/// </summary>
Console.WriteLine("Bem Vindo quantos objetos deseja cadastrar?");
n = int.Parse(Console.ReadLine());


/// <summary>
/// entrada e processamento de dados
/// </summary>
for(int i = 0; i < n; i++)
{
    Console.Clear();

    Console.WriteLine("Digite a posição X");
    posicaox = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    Console.WriteLine("Digite a posição Y");
    posicaoy = int.Parse(Console.ReadLine());
    Console.WriteLine("");

    cartesianolista.Add(new PlanoCartesiano(posicaox, posicaoy));
}


/// <summary>
/// Metodo para exibir as informações da entrada
/// </summary>
for(int i = 0; i < cartesianolista.Count; i++)
{
    
    cartesianolista[i].ExibibirObjeto();
    Console.WriteLine("===========");
}