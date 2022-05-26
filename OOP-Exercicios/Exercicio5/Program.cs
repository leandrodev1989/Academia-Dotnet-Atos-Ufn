///*#5
//Crie uma classe para representar um item de cenário, com os atributos privados de:
//    *descrição(string), 
//    *data de criação(date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
//    *altura(float).

//Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
//todos dados de um item de cenário. 
//Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
//a classe criada. */

using Exercicio5;
using System.Diagnostics;

//List<Item> items = new List<Item>();




    DateTime datacriacao = DateTime.Now;

    Console.WriteLine("[Inforções Do Item]");
    Console.WriteLine("");

    Console.WriteLine("Digite a Descrição do Item");
    string item = Console.ReadLine();
    Console.WriteLine("");
    Console.WriteLine("Digite a altura do Item");
    float altura = float.Parse(Console.ReadLine());
    Console.WriteLine("");

Item itens = new Item(item,  altura, datacriacao);
//items.Add(new Item(item, altura, datacriacao));



Console.WriteLine(itens.Imprimir());

itens.TempoCriacao();

//for (int i = 0; i < items.Count; i++)
//{
//    Console.WriteLine(items[i].Imprimir());
//    Console.WriteLine();
//}







