using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}



//Criar uma aplicação utilizando windows form para cadastro de usuários.
//O sistema deve possuir uma classe usuário e ter todos os atributos necessários para cadastro de um usuário.
//Atributos: nome, telefone, cpf, login, senha, status(ativo ou inativo), tipo(administrador ou usuário).
//Crie um formulário para cadastro contendo estes campos para cadastro. Ao clicar no botão, deve ser instanciado um objeto da classe.
