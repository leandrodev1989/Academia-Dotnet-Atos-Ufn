using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class Form1 : Form
    {

        internal static List<Usuario> usuarios = new List<Usuario>();
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

           
            
            
            Usuario us = new Usuario(tbNome.Text, tbtelefone.Text, tbCpf.Text,  tbUsuario.Text,tbSenha.Text, tipousuario, ativoinativo);
            us.Exibir();
            usuarios.Add(us);
            MostarListaUsuario();
            dgAutomoveis.Rows.Add(tbNome.Text, tbtelefone.Text, tbCpf.Text, tbUsuario.Text, tbSenha.Text, tipousuario, ativoinativo);


        }

        static void MostarListaUsuario()
        {
            foreach(Usuario us in usuarios)
            {

                MessageBox.Show(
                   $"DADOS Da LISTA\n" +
                   $"Nome:---------{us.Nome}\n" +
                   $"Telefone:-----{us.Telefone}\n" +
                   $"Cpf:----------{us.Cpf}\n" +
                   $"Login:--------{us.Login}\n" +
                   $"Senha:--------{us.Senha}\n" +
                   $"Status:-------{us.Ativoinativo}\n" +
                   $"Tipo Usuário:-{us.Tipousuario}");
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btbClear_Click(object sender, EventArgs e)
        {

            tbNome.Clear();
            tbCpf.Clear();
            tbtelefone.Clear();
            tbUsuario.Clear();
            tbSenha.Clear();
            cbTipos.Text = "";
            cbStatus.Text = "";
            btbClear.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
