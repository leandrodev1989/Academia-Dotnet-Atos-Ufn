using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    /// <summary>
    /// Classe Principal
    /// </summary>
    class DadosPessoa
    {

        /// <summary>
        /// Atributos da Pessoa
        /// </summary>
        string nome;
        int idade;
        char sexo;
        double altura;


        /// <summary>
        /// Construtor para iniciar e passar dados aos atributos
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="idade"></param>
        /// <param name="sexo"></param>
        /// <param name="altura"></param>
        public DadosPessoa( string nome, int idade, char sexo, double altura)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.Altura = altura;
        }

        public DadosPessoa()
        {
            
        }



        /// <summary>
        /// Atributos com os atributos get e set
        /// </summary>
        public string Nome { get => nome; set => nome  = value;}
        public int Idade { get => idade; set => idade  = value;}
        public char Sexo { get => sexo; set => sexo  = value;}
        public double Altura { get => altura; set => altura  = value;}



        /// <summary>
        /// Metodo para exibir os dados gerados pelo usuario
        /// </summary>
        public void Exibir()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Idade: {this.Idade}");
            Console.WriteLine($"Sexo: {this.Sexo}");
            Console.WriteLine($"Altura: {this.Altura}");
        }
    }




}
