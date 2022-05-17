/*5.Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram.*/


string voto; //ZECA, JOAO, BRANCO
int totalVotosZeca = 0;
int totalVotosJoao = 0;
int totalVotosBranco = 0;
int totalVotosNulos = 0;
int NumeroDePessoas = 0;
do
{
    Console.Clear();
    Console.Write("Digite o nome do seu candidato, ou BRANCO e NULO ou APERTE QUALQUER TECLAR para encerrar: ");
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
        case "NULO":
            totalVotosNulos++;
            break;
        case "FIM OU qualquer tecla":
            Console.WriteLine("Programa encerrado");
            break;
        default:
            Console.WriteLine("Candidato inexistente");
            break;
    }
    Console.WriteLine("Obrigado por votar nessas eleições");
    Console.ReadKey();
} while (voto == "Qualquer Tecla Sair");

NumeroDePessoas = totalVotosNulos + totalVotosBranco + totalVotosZeca + totalVotosJoao ;

if (totalVotosZeca > totalVotosJoao)
{
    Console.WriteLine("Zeca ganhou a Eleição!!");
}
else if(totalVotosJoao == totalVotosNulos || totalVotosJoao > totalVotosBranco)
{
    Console.WriteLine("Não houve vencedor!!");
}
else
{
    Console.WriteLine("João ganhou eleição");
}

Console.WriteLine("Total de votos para o Zeca: " + totalVotosZeca);
Console.WriteLine("Total de votos para o João: " + totalVotosJoao);
Console.WriteLine("Total de votos em Branco: " + totalVotosBranco);
Console.WriteLine("Total de votos Nulos: " + totalVotosNulos);
Console.WriteLine("Total de Pessoas que votaram: " + NumeroDePessoas);