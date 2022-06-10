using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoGaragemForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // trazer os  dados do arquivo para a lista, toda a vez que o programa ser executado
            StreamReader leitor = new StreamReader("jogadores.txt");
            string linha;
            string[] vetorDados;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split();
                listaJogadores.Add(new Jogador(vetorDados[0], vetorDados[1]) );

                textBox_listadejogadores.AppendText(vetorDados[0] + " - " + vetorDados[1] + Environment.NewLine);

            } while(!leitor.EndOfStream);

            leitor.Close();
        }

       

        

       

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            //validar e o text box for vazio
            if (tbnomeJogador.Text.Equals(""))
            {
                MessageBox.Show("É preciso digitar um nome completo", "Alerta");
                return;
            }

            string email;
            //altera o nome para maiusculo
            tbnomeJogador.Text = tbnomeJogador.Text.ToUpper();

            //gravar na lista desde que não estave na lista
            if (Jogador.jacdastrado(tbnomeJogador.Text, listaJogadores))
            {
                MessageBox.Show("Jogador já Cadastrado!","Alerta");
            }
            else
            {
                string[] vetorNomes = tbnomeJogador.Text.ToLower().Split();

                if (vetorNomes.Length > 1)
                {
                     email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br";
                }
                else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";
                }

                listaJogadores.Add(new Jogador(tbnomeJogador.Text, email) );
                textBox_listadejogadores.AppendText(tbnomeJogador.Text + " - " + email + Environment.NewLine);



                //metodo para escrever no arquivo
                StreamWriter escritor = new StreamWriter("jogadores.txt", true);

                escritor.WriteLine(tbnomeJogador.Text + " - " + email);

                escritor.Close();
               // listaJogadores
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            tbnomeJogador.Text = "";
            textBox_listadejogadores.Text = "";
            listaJogadores.Clear();
        }
         static List<Jogador> listaJogadores = new List<Jogador>();
    }
}
