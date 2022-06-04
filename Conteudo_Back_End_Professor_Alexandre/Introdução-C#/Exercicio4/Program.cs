// See https://aka.ms/new-console-template for more information

/*4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes. */

Console.WriteLine("Exercico4: 4) Faça um programa em C# e no Visual Studio que receba a data\n" +
                 " na forma DDMMAAAA e imprima na \n " +
                 "forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.");

//solução não clássica -> string
string dia;
string mes;
string ano;

Console.Write("Informe o dia: ");
dia = Console.ReadLine();

Console.Write("Informe o mês: ");
mes = Console.ReadLine();

Console.Write("Informe o ano: ");
ano = Console.ReadLine();

Console.WriteLine("DD/MM/AAAA: " + dia + "/" + mes + "/" + ano);
Console.WriteLine("AAAA/MM/DD: " + ano + "/" + mes + "/" + dia);

Console.WriteLine("AA/MM/DD: " + ano[2] + ano[3] + "/" + mes + "/" + dia);


// Outra Opção de Formatação de Datas
var Data = DateTime.Now;

var formatada1 = String.Format("{0:yyyy-MM-dd}", Data);
var formatada2 = String.Format("{0:dd-MM-yyyy}", Data);
var formatada3 = String.Format("{0:yy-MM-dd}", Data);

Console.WriteLine($"YYYY/MM/DD:{formatada1}");
Console.WriteLine($"DD/MM/AAAA:{formatada2}");
Console.WriteLine($"YY/MM/DD:{formatada3}");
