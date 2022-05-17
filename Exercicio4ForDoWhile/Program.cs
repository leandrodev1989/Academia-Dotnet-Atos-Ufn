/*4.Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
de votos em branco. */

string voto; //ZECA, JOAO, BRANCO
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBranco = 0;

do
{
    Console.Clear();
    Console.Write("Digite o nome do seu candidato, ou BRANCO, ou FIM para encerrar: ");
    voto = Console.ReadLine().ToUpper();

    switch (voto)
    {
        case "JOAO":
            totalVotosJoao++;
            break;
        case "ZECA":
            totalVotosZeca++;
            break;
        case "BRANCO":
            totalVotosBranco++;
            break;
        case "FIM":
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Candidato inexistente");
            break;
    }
    Console.WriteLine("Obrigado por votar nessas eleições");
    Console.ReadKey();
} while (voto != "FIM");

Console.WriteLine("Total de votos para o Zeca: " + totalVotosZeca);
Console.WriteLine("Total de votos para o João: " + totalVotosJoao);
Console.WriteLine("Total de votos em Branco: " + totalVotosBranco);