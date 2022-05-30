using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Item
    {
        public string Descricao { get; set; }
        public float altura { get; set; }
        public DateTime Datacriacao { get; set; }
        public int tempo { get; set; }

        public Item()
        {
                
        }

        public Item(string descricao, float altura, DateTime datacriacao)
        {
            this.Descricao = descricao;
            this.altura = altura;
            this.Datacriacao = datacriacao;

        }

        public void  TempoCriacao()
        {

            Console.WriteLine("Item Criado há");
            Console.WriteLine(DateTime.Now - this.Datacriacao);
           
        }

        

        public string Imprimir()
        {
            return $"Descrição: {this.Descricao}| Altura: {this.altura} | Data Criação: {DateTime.Now}";
            Console.WriteLine("");
        }
    }
}
