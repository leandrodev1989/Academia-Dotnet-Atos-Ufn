using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6CadastroEmail
{
    class ProbleEmail
    {
        string nomeCompleto { get; set; }
        string email { get; set; }

       

        public ProbleEmail(string nome)
        {
            this.nomeCompleto = nome;
            this.gerarEmail();

        }



        private void gerarEmail()
        {
            string[] vetorDados = this.nomeCompleto.Split(' ');
            this.email = vetorDados[vetorDados.Length - 1] + "," + vetorDados[0] + "@ufn.edu.br";
            this.email = this.email.ToLower();
        }

    }
}
