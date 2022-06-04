using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    class Usuario
    {
        /// <summary>
        /// Atributos da classe
        /// </summary>
        public string nome;
        public string telefone;
        private string cpf;
        public string login;
        public string senha;
        public string ativoinativo;
        public string tipousuario;


        /// <summary>
        /// Construtor da classe Usuario
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="cpf"></param>
        /// <param name="telefone"></param>
        /// <param name="login"></param>
        /// <param name="senha"></param>
        /// <param name="ativoinativo"></param>
        /// <param name="tipousuario"></param>
        public Usuario(string nome,  string cpf, string telefone, string login, string senha,  string ativoinativo, string tipousuario)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.Cpf = cpf;
            this.Login = login;
            this.Senha = senha;
            this.Ativoinativo = ativoinativo;
            this.Tipousuario = tipousuario;


        }

        /// <summary>
        /// Construtor padrão
        /// </summary>
        public Usuario()
        {
            
        }
        
        /// <summary>
        /// Criação dos gets e sets
        /// </summary>
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Login { get => login; set => login = value; }
        public string Ativoinativo { get => ativoinativo; set => ativoinativo = value; }
        public string Tipousuario { get => tipousuario; set => tipousuario = value; }
        public string Cpf { get => cpf; set => cpf = value; }



        /// <summary>
        /// Metodo para exibir as informações para o usuario
        /// </summary>
        public void Exibir()
        {
            MessageBox.Show(
               $"DADOS DO CADASTRO\n" +
               $"Nome:---------{this.Nome}\n" + 
               $"Telefone:-----{this.Telefone}\n" + 
               $"Cpf:----------{this.Cpf}\n"+
               $"Login:--------{this.Login}\n" + 
               $"Senha:--------{this.Senha}\n" + 
               $"Status:-------{this.Ativoinativo}\n" +  
               $"Tipo Usuário:-{this.Tipousuario}");
            
           
        }

       
    }
}
