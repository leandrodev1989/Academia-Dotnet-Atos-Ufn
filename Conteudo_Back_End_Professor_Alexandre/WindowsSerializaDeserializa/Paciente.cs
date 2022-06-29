using System;
using System.Collections.Generic;

namespace WindowsSerializaDeserializa
{
    [Serializable]
    public class Paciente
    {
        public string nome;
        public DateTime datanascimewnto;
        public string cpf;

        public Paciente(string nome, DateTime datanascimento, string cpf)
        {
            this.Nome = nome;
            this.Datanascimento = datanascimento;
            this.cpf = cpf;    
        }


        public string Nome { get => nome; set => nome = value; }
        public DateTime Datanascimento { get => datanascimewnto; set => datanascimewnto = value; }
        public string Cpf { get => cpf; set => cpf = value; }



        public static bool jacadastrado(string nome, List<Paciente> lista)
        {
            foreach (Paciente i in lista)
            {
                if (i.Nome.Equals(i.nome))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
