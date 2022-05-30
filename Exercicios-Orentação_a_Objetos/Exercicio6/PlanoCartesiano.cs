using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    /// <summary>
    /// Classe para Representar um objetos no Plano Cartesiano
    /// </summary>
    class PlanoCartesiano
    {
        /// <summary>
        /// Declaração da s variaveis
        /// </summary>
        int PosicaoX;
        int PosicaoY;


        /// <summary>
        /// Construtor Padrão
        /// </summary>
        public PlanoCartesiano()
        {

        }


        /// <summary>
        /// Construtor Recebendo as informações dos atributos
        /// </summary>
        /// <param name="posicaox"></param>
        /// <param name="posicaoy"></param>
        public PlanoCartesiano(int posicaox , int posicaoy)
        {
            this.PosicaoX = posicaox;
            this.PosicaoY = posicaoy;
        }


        /// <summary>
        /// Atributos com os gets e sets da posição x
        /// </summary>
        public int posicaox { get => PosicaoX; set => PosicaoX = value; }

        /// <summary>
        ///  Atributos com os gets e sets da posição Y
        /// </summary>
        public int posicaoY { get => PosicaoY; set => PosicaoY = value; }


        /// <summary>
        /// Metodo para exibir informações  do objeto
        /// </summary>
        public void ExibibirObjeto()
        {
            Console.WriteLine($"Ponto X: {this.PosicaoX}\nPonto Y: {this.PosicaoY}");
        }

    }
}
