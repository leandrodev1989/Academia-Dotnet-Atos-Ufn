/*13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
seu peso ideal, utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7 */


/// <summary>
/// Variável para receber altura do usuário
/// </summary>
float altura;

/// <summary>
/// Variável  para calcular o peso ideal do homem (72.7 * h) - 58
/// </summary>
double pesoIdealH;

/// <summary>
/// Variável  para calcular o peso ideal da mulher (62.1 * h) - 44.7
/// </summary>
double pesoIdealM;

/// <summary>
/// Recebe o nome do usuário
/// </summary>
string nome;

/// <summary>
/// Recebe o sexo do usuário
/// </summary>
string sexo;


//Entrada De Dados
Console.Write("Informe Seu Nome: ");
nome = Console.ReadLine();

Console.Write("Informe Sua Altura: ");
altura = float.Parse(Console.ReadLine());


Console.Write("Informe o Sexo M-(Masculino)  F-(Feminino): ");
sexo = Console.ReadLine();
Console.WriteLine("");

//Processamento de Dados 
if(sexo == "M".ToLower())
{
    pesoIdealH = (72.7 * altura) - 58;

    Console.WriteLine($"O Seu peso Ídeal {nome} é {pesoIdealH:F1}");

}
else if (sexo == "F".ToLower())
{
    pesoIdealM = (62.1 * altura) - 44.7;

    Console.WriteLine($"O Seu peso Ídeal {nome} é {pesoIdealM:F1}");
}







