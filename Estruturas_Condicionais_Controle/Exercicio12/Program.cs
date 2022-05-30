/*12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
No final do processamento, exibir o salário total e o salário excedente do operário. */


/// <summary>
/// Recebe o codigo do usuário
/// </summary>
int codigo;

/// <summary>
/// Entra com o numero de horas para ser Processada
/// </summary>
int numeroHoras;

/// <summary>
/// Valor Definido para a mutiplicação com o numero de horas
/// </summary>
float valorDahoraTrabalhada = 10;

/// <summary>
/// Valor definido a ser adicionado caso o numero de horas exceda 50 horas
/// </summary>
float horaExcedente = 20;

/// <summary>
/// Recebe a informação do salário apos as operações
/// </summary>
float salarioFinal;

/// <summary>
/// guarda ou zera as horas caso exceder o numero de horas
/// </summary>
float horaExtra ;

/// <summary>
/// Entrada de Dados
/// </summary>
Console.Write("Digite Seu Codigo: ");
codigo = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a quantidade de horas: ");
numeroHoras = int.Parse(Console.ReadLine());

   /// <summary>
   /// Processamento dos Dados
   /// </summary>
    if (numeroHoras > 50)
    {


         horaExtra = (numeroHoras - 50);
         salarioFinal = 500 + (horaExtra * horaExcedente); 

         Console.WriteLine($"Seu Salário Excedeu é o Valor é {salarioFinal:F}");

    }
    else
    {

         horaExtra = 0;
         salarioFinal = numeroHoras * valorDahoraTrabalhada;
       
         Console.WriteLine($"Não Realizou Hora Extra Seu Salário é de {salarioFinal}");
         Console.WriteLine($"Hora Extra é de {horaExtra}");
    }








