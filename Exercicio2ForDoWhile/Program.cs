/*2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido.
 
Exemplo:
Digite um número inteiro positivo: 8
Numero digitado: 8
Números inteiros pares entre 1 e 8: 2, 4, 6.


Deseja informar outro número (s/n)? S
 
Digite um número inteiro positivo: 12
Numero digitado: 20
Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.


Deseja informar outro número (s/n)? N */

/// <summary>
/// validadr se a informação e verdadeira ou falsa
/// </summary>
bool numeroPositivo = false;


/// <summary>
/// recebe o numero solicitado
/// </summary>
int numero;


/// <summary>
/// valida se o usuario quer fazer outra operação
/// </summary>
string op;


/// <summary>
/// Processa a validação dos dados de entrada
/// </summary>
while (numeroPositivo == false)
{
    Console.Write("Digite um Número Inteiro Positivo: ");
    numero = int.Parse(Console.ReadLine());

    if (numero < 0)
    {
        Console.WriteLine("Valor Incorreto!!");
        numeroPositivo = false;

    }

    Console.WriteLine($"Número digitado {numero} ");
    Console.WriteLine($"Número inteiros pares entre 1 e {numero}: ");

    for (int i = 1; i < numero; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i + " ");


        }
        else
        {
            numeroPositivo = true;

        } 

    }
 
        Console.WriteLine("Deseja informar outro numero? (S / N)");
        op = Console.ReadLine();
        

        if (op == "N".ToLower())
        {
            Console.WriteLine("Saindo do Programa");
             
        }
        else
        {
          numeroPositivo = false;
        }    
       
}


