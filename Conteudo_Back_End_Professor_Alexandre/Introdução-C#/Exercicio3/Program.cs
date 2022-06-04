// See https://aka.ms/new-console-template for more information

/*Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
si os valores de duas variáveis A e B.*/

Console.WriteLine("Exercicio3: Escreva a seqüência de atribuições, em forma de programa\n" +
                 " em C# e no Visual Studio, para trocar entre\n " +
                 "si os valores de duas variáveis A e B.");
Console.WriteLine("");



Console.Write("Digite uma frase qualquer: ");
string variavelA = Console.ReadLine();

Console.Write("Digite outra frase qualquer: ");
string variavelB = Console.ReadLine();

Console.WriteLine("O conteúdo da variavelA é: " + variavelA);
Console.WriteLine("O conteúdo da variavelB é: " + variavelB);

Console.WriteLine("Processo de troca de valores entre duas variáveis");

string tmp = variavelA;
variavelA = variavelB;
variavelB = tmp;

Console.WriteLine("O conteúdo da variavelA é: " + variavelA);
Console.WriteLine("O conteúdo da variavelB é: " + variavelB);
