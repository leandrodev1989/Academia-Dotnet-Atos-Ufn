// See https://aka.ms/new-console-template for more information

// Exercicio5: Escreva um algoritmo para calcular o consumo
//            medio de um automovel (km/l), dados a distan-
//            cia total percorrida (km) e o consumo de com-
//            bustivel (l) consumido para percorre-la.

Console.WriteLine("Exercicio5: 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel \n" +
                "(medido em Km / l), sendo que são conhecidos a distância total percorrida e o volume de combustível" +
                "\nconsumido para percorrê - la(medido em l).");
Console.WriteLine("");

//Declaração das Variáveis
/// <summary>
/// recebe a informação da distância percorrida
/// </summary>
float distancia;

/// <summary>
/// rebece a quantidade de combustivel consumido pelo carro
/// </summary>
float combustivelGasto;

/// <summary>
/// retorna o consumo Médio através da distância / combustivel ultilizado
/// </summary>
float consumoMedio;

//Entrada de dados
Console.WriteLine("Digite a  distância percorrida");
distancia = float.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de combustivel ");
combustivelGasto = float.Parse(Console.ReadLine());

//Processamento de Dados
consumoMedio = distancia / combustivelGasto;

Console.WriteLine("Consumo Médio é: {0:N} Km/l", consumoMedio);


