double salario;
double aumento = 0;

Console.Write("Entre com o salário: ");
salario = double.Parse(Console.ReadLine());

if(salario < 900)
{
    aumento = 5;
}
else if(salario >= 900 && salario < 1400)
{
    aumento = 8;
}
else if(salario >= 1400)
{
    aumento = 10;
}

salario = salario + salario * (aumento / 100);
Console.WriteLine($"O aumento é de {aumento} porcento e o salario final de { salario}");
