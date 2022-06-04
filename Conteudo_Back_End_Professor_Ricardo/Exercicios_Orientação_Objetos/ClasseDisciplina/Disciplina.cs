using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseDisciplina
{
    public class Disciplina
    {
        /// <summary>
        /// Atributos da classe
        /// </summary>
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }

        /// <summary>
        /// Construtor da classe
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cargahoraria"></param>
        public Disciplina(string nome, int cargahoraria)
        {
            this.Nome = nome;
            this.CargaHoraria = cargahoraria;

        }


        /// <summary>
        /// Metodo para exibir as informações passadas pelo usuario
        /// </summary>
        public void ExibirDados()
        {
            Console.WriteLine("Exibindo Dados");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Carga Horaria: {CargaHoraria}");

        }
    }
}
