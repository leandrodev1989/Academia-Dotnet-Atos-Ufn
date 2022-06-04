/*19.A prefeitura de uma cidade fez uma pesquisa entre seus habitantes,
coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$ 100,00.
O final da leitura de dados se dará com a entrada de um salário negativo.*/


/// <summary>
/// Criação da lista de Salario para armazenar os dados fornecidos
/// </summary>
List<double> listaSalario = new List<double>();

/// <summary>
///  Criação da lsita de Filhos para armazenar os dados fornecidos
/// </summary>
List<int> listaFilhos = new List<int>();


/// <summary>
/// Recebe o salario fornecido pelo usuario
/// </summary>
double salario;

/// <summary>
/// Recebe a quantidade de filhos informada pelo usuario
/// </summary>
int filhos;

/// <summary>
/// faz a operação para retornar a media geral do salario da população
/// </summary>
double MediaSalario = 0;

/// <summary>
/// faz a operação para retornar a media geral dos filhos
/// </summary>
double MediaFilhos =  0;

/// <summary>
/// faz a operaão do maior salario geral
/// </summary>
double MaiorSalario = 0;

/// <summary>
/// retorna o percentual de pessoas com osalario até 100,00
/// </summary>
double PercentualPor100;



/// <summary>
/// Entrada de Dados
/// </summary>
do
{
    Console.Write("Digite o Salário dos Habitante: ");
    salario = double.Parse(Console.ReadLine());
    listaSalario.Add(salario);

    Console.Write("Digite o Número de Filhos: ");
    filhos = int.Parse(Console.ReadLine());
    listaFilhos.Add(filhos);



}while(salario > 0);


/// <summary>
/// Processamento de Dados
/// </summary>
for(int i = 0; i < listaSalario.Count; i++)
{
    MediaSalario += listaSalario[i];
}

MediaSalario /= listaSalario.Count;
Console.WriteLine($"Media Do Sálario Da População: {MediaSalario:F}");

for(int i = 0; i < listaSalario.Count; i++)
{
    MediaSalario += listaFilhos[i];
}

MediaFilhos /= listaFilhos.Count;
Console.WriteLine($"Media de Filhos da População: {MediaFilhos}");

for (int i = 0; i < listaSalario.Count; i++)
{
    if (listaSalario[i] > MaiorSalario)
    {
        MaiorSalario = listaSalario[i];
    }
}
Console.WriteLine($"Maior Salário: {MaiorSalario:F}");

int count = 0;
for (int i = 0; i < listaSalario.Count; i++)
{
    if (listaSalario[i] <= 100)
    {
        count++;
    }
}
PercentualPor100 = (count * 100) / listaSalario.Count;
Console.WriteLine($"Percentual de pessoas com salário até R$100,00: {PercentualPor100}"  );