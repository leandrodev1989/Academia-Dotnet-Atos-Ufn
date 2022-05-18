/*20.Foi realizada uma pesquisa de algumas características físicas da população de uma 
certa região, a qual coletou os seguintes dados referentes a cada habitante para 
serem analisados:
-sexo(masculino e feminino)
- cor dos olhos(azuis, verdes ou castanhos)
-cor dos cabelos(louros, castanhos, pretos)
-idade


Faça um algoritmo que determine e escreva: 
 
-a maior idade dos habitantes
- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
e que tenham olhos verdes e cabelos louros.
O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade. */

/// <summary>
/// Lista Criada para armazenar dodos dos sexo
/// </summary>
List<char> ListaSexo = new List<char>();


/// <summary>
/// Lista Criada para armazenar dodos cor dos olhos
/// </summary>
List<string> listaOlhos = new List<string>();


/// <summary>
/// Lista Criada para armazenar cor de cabelos
/// </summary>
List<string> listaCabelo = new List<string>();


/// <summary>
/// Lista Criada para armazenar dodos maior idade
/// </summary>
List<int> ListaIdade = new List<int>(); int idade;

int maiorIdade = 0, qtdMulheres = 0;


/// <summary>
/// Entrada de Dados
/// </summary>
do
{
    Console.WriteLine("Sexo: ");
    ListaSexo.Add(char.Parse(Console.ReadLine()));

    Console.WriteLine("Cor dos olhos: ");
    listaOlhos.Add(Console.ReadLine());

    Console.WriteLine("Cor do cabelo: ");
    listaCabelo.Add(Console.ReadLine());

    Console.WriteLine("Idade: ");
    idade = int.Parse(Console.ReadLine());
    ListaIdade.Add(idade);
} while (idade != -1);


/// <summary>
/// Processamento de Dados
/// </summary>
for (int i = 0; i < ListaIdade.Count; i++)
{
    if (ListaIdade[i] > maiorIdade)
    {
        maiorIdade = ListaIdade[i];
    }
}
Console.WriteLine($"Maior idade dos habitantes: {maiorIdade} ");

for (int i = 0; i < ListaSexo.Count; i++)
{
    if (ListaSexo[i] == 'F' || ListaSexo[i] == 'f')
    {
        if (ListaIdade[i] >= 18 && ListaIdade[i] <= 35)
        {
            if (listaOlhos[i] == "verdes" && listaCabelo[i] == "louros")
            {
                qtdMulheres++;
            }
        }
    }
}
Console.WriteLine($"quantidade de Indivíduos do Sexo Feminino cuja Idade está entre 18 e 35 anos inclusive\n" +
    $" e que tenham olhos verdes e cabelos louros: {qtdMulheres}");
