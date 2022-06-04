using System;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fucionalidade para exucutar as funções atribuidas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
           
           
            string ativoinativo = "";

            if (cbStatus.Text == "Ativo")
            {
                ativoinativo = "Ativo";
            }
            else if (cbStatus.Text == "Inativo")
            {
                ativoinativo = "Inativo";

            }


            string tipousuario = "";

            if (cbTipos.Text == "Administrador")
            {
                tipousuario = "Administrador";
            }
            else if (cbTipos.Text == "Usuário")
            {
                tipousuario = "Usuário";
            }

            
            Usuario usuario = new Usuario(tbNome.Text, tbCpf.Text, tbTelefone.Text,tbUsuario.Text,tbSenha.Text, tipousuario,ativoinativo);
            usuario.Exibir();




        }
    }
}
