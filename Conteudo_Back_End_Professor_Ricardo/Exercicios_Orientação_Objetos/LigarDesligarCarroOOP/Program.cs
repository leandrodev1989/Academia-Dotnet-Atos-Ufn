
/*  Introdução a Orientação a Objetos Aprendendo a criar Atributos metodos e intânciar o objeto*/

Carro carro = new Carro();

  carro.modelo = "Celta";
  carro.marca = "Fiat";
  carro.placa = "pks3315";
  carro.cor = "Preta";


  Console.WriteLine($"O carro modelo: {carro.modelo}");
  Console.WriteLine($"Marca: {carro.marca}");
  Console.WriteLine($"Placa: {carro.placa}");
  Console.WriteLine($"Cor: {carro.cor}");
  carro.LigarCarro();
  Console.WriteLine($"O CARRO ESTA LIGADO? {carro.ligado}");



/// <summary>
/// Classe
/// </summary>
public class Carro
{

    /// <summary>
    /// Atributos
    /// </summary>
    public bool ligado;

    public string modelo;

    public string marca;

    public string cor;

    public string placa;


    /// <summary>
    /// Metodos
    /// </summary>
    /// <returns></returns>
    public bool estaLigado()
    {

        return ligado;
    }

    public void esataDesligado()
    {
        Console.WriteLine("O Carro estar Desligado");
        ligado = false;
    }


    public void LigarCarro()
    {
        Console.WriteLine("O carro estar Ligado");
        ligado = true;
    }

    public void desligar()
    {
        Console.WriteLine("O Carro estar sendo Desligado ");
        ligado = false;
    }


    public Carro()
    {

    }

}



