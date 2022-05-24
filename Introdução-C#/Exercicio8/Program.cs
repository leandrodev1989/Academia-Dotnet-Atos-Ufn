Console.WriteLine("Ler uma temperatura em graus Celsius e" +
    "\napresentá-la convertida em graus Fahrenheit." +
    "\nA fórmula da conversão é F = (9 * C + 160) / 5.");

/// <summary>
/// Converter o valor da temperatura em celsius
/// </summary>
float TemperaturaCelsius;

/// <summary>
/// Temperatura em fahrenheit convertida de celsius
/// </summary>
float TemperaturaFahrenheit;


Console.Write("Digite a temperatura em graus Celsius: ");
TemperaturaCelsius = float.Parse( Console.ReadLine() );

TemperaturaFahrenheit = (9 * TemperaturaCelsius + 160) / 5;

Console.WriteLine("O valor " + temperaturaCelsius + " em graus Celsius é " +
    "em Fahrenheit: " + TemperaturaFahrenheit);