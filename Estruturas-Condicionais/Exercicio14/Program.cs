/*14-Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
do arquivo usando este link (em minutos)*/

/// <summary>
/// Entra com o tamanho do arquivo em MB
/// </summary>
float TamanhoDoArquivo;

/// <summary>
/// Entra com a velocidade da internet
/// </summary>
float velocidade;

/// <summary>
/// recebe o segundos / 60
/// </summary>
int minutos;

/// <summary>
/// recebe segundos % 60
/// </summary>
float segundos;

//Entrada de Dados
Console.Write("Digite o tamanho do arquivo para download: ");
TamanhoDoArquivo= float.Parse(Console.ReadLine());
Console.Write("Digite a velocidade de um link de internet: ");
velocidade = float.Parse(Console.ReadLine());

//Processamento de Dados
segundos = (int)TamanhoDoArquivo / velocidade;
minutos = (int)(segundos / 60);
segundos = segundos % 60;

Console.WriteLine($"Tempo aproximado para download: {minutos} minutos e {segundos:F} segundos");