using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Asteroide
    {

        /// <summary>
        /// Atributo privado para setar nome
        /// </summary>
        private string nome { get; set; }

        /// <summary>
        ///  Atributo privado para setar Posição X
        /// </summary>
        private int posicaoX { get; set; }

        /// <summary>
        /// Atributo privado para setar Posição Y
        /// </summary>
        private int posicaoY { get; set; }

        /// <summary>
        /// Atributo privado para setar Tamanho dp Asteroide
        /// </summary>
        private int tamanhoAsteroioe { get; set; }

        /// <summary>
        /// Atributo privado para setar Velocidade dp asteroide
        /// </summary>
        private int velocidadeAsteroide{ get; set; }

        /// <summary>
        /// Atributo privado para setar energia do asteroide
        /// </summary>
        private int energia { get; set; }


        /// <summary>
        /// Construtor padrão de inicio
        /// </summary>
        public Asteroide()
        {

        }


        /// <summary>
        /// Construtor geral para futura modificações
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="posicaox"></param>
        /// <param name="posicaoy"></param>
        /// <param name="tamanhoasteroide"></param>
        /// <param name="velocidadeasteroide"></param>
        /// <param name="energia"></param>
        public Asteroide(string nome,int posicaox, int posicaoy, int tamanhoasteroide, int velocidadeasteroide, int energia)
        {
            this.nome = nome;
            this.posicaoX = posicaox;
            this.posicaoY = posicaoy;
            this.tamanhoAsteroioe = tamanhoasteroide;
            this.velocidadeAsteroide = velocidadeasteroide;
            this.energia = energia;
        }

        /// <summary>
        /// Construtor Posição do Asteroide
        /// </summary>
        /// <param name="posicaox"></param>
        /// <param name="posicaoy"></param>
        public Asteroide( int posicaox, int posicaoy)
        {
            this.posicaoX = posicaox;
            this.posicaoY = posicaoy;
        }


        /// <summary>
        /// Construtor do asteroide
        /// </summary>
        /// <param name="tamanhoasteroide"></param>
        /// <param name="velocidadeasteroide"></param>
        /// <param name="energia"></param>
        public Asteroide(int tamanhoasteroide, int velocidadeasteroide, int energia)
        {
            this.tamanhoAsteroioe = tamanhoasteroide;
            this.velocidadeAsteroide = velocidadeasteroide;
            this.energia = energia;
        }


        /// <summary>
        /// Exibi as Informaões passada para o Usuario
        /// </summary>
        /// <returns></returns>
        public string ExibirDadosAsteroides()
        {
            return $" Nome do Asteroide: {this.nome} \n Posiçõa X: {this.posicaoX} \n Posição Y: {this.posicaoY} \n Tamanho do Asteroide: {this.tamanhoAsteroioe} \n Velocidade: {this.velocidadeAsteroide} \n Energia: {this.energia}";

        }
    }
}
