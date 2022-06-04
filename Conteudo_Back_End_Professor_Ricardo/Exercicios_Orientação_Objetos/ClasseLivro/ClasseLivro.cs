using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    /// <summary>
    /// Classe Principal
    /// </summary>
    public class ClasseLivro
    {
        /// <summary>
        /// Declaração dos atributos
        /// </summary>
        public string titulo;
        public string autor;
        public int pagina;
        public int ano;
        public int edicao;


        /// <summary>
        /// Construtor criado para fazer os get e set dos atributos
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="pagina"></param>
        /// <param name="ano"></param>
        /// <param name="edicao"></param>
        public ClasseLivro(string titulo, string autor, int pagina, int ano, int edicao )
        {
            this.titulo = titulo;
            this.autor = autor;
            this.pagina = pagina;
            this.ano = ano;
            this.edicao = edicao;

        }


        /// <summary>
        /// Metodo Para Exibir os dados
        /// </summary>
         public void Exibir()
         {
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Pagina: {pagina}");
            Console.WriteLine($"Ano: {ano}");
            Console.WriteLine($"Adição: {edicao}");
             
         }

    }
}
