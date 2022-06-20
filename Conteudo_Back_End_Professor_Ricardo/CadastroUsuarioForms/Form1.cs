using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CadastroUsuarioForms
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private string stringConexao = "Data Source=DESKTOP-AC\\SQLEXPRESS;Initial Catalog=usuarios_db;Integrated Security=True";

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
          
           

            Usuario usuario = new Usuario(int.Parse(textBox_idusuario.Text), textBox_nomecompleto.Text );

            MessageBox.Show("Id Do Usuario:" + usuario.IdUsuario + "Nome Completo:" + usuario.Nomecompleto + "Email:" + usuario.Email);

           
     

            textBox_idusuario.Text = "";
            textBox_nomecompleto.Text = "";
       
            usuario.gravarPessoa();
            

        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
