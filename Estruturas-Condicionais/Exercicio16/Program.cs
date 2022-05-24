/*16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
enfrentar novamente em um novo jogo.
ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.*/



/// <summary>
/// variavel para validar o placar do jogo
/// </summary>
string placar;

//entrada de dados
Console.WriteLine("Bem Vindo A Copa do Brasil");
Console.WriteLine("");
Console.Write("Entre Com O Placar da Partida: ");
placar = Console.ReadLine();


//processamento de dodos
if(placar  == "0 x 2" || placar ==  "1 x 3" || placar == "2 x 4" || placar == "3 x 5" && placar == "4 x 6")
{
    Console.WriteLine("Time Visitante classificado para a Proxíma fase! ganhou por 2 fols de diferença"); ;
}
else
{
    Console.WriteLine("Os Dois Times ainda vão se enfrentar no jogo de volta");
}