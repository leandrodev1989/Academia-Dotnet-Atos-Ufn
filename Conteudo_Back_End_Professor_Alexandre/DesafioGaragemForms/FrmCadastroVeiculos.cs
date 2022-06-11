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

namespace Garagemteste
{
    public partial class FrmCadastroVeiculos : Form
    {
        static List<Veiculo> listaveiculos = new List<Veiculo>();


        public FrmCadastroVeiculos()
        {
            InitializeComponent();
            //EntityDados.carregarLista(listaveiculos);

            //
            
        }




        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       


        /// <summary>
        /// Função no evento do Botão Limpar campo placa e campo opções depois que o usuario
        /// Cadastrar o veiculo no FrmCadastroVeiclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            tbplaca.Text = "";
            listaveiculos.Clear();
        }

       

        private void btncadastrar_Click(object sender, EventArgs e)
        {
               
               

                /// Validando o campo para que não fique vazio
                if (tbplaca.Text.Equals(""))
                {
                    MessageBox.Show("É preciso digitar a Placa e escolher uma opção!", "Alerta");
                    return;
                }

                string placa;
                ///Alterando a fonta para Maiusculo
                tbplaca.Text = tbplaca.Text.ToUpper();

                DateTime Datahoraentrada = DateTime.Now;
                //gravar na lista desde que não estave na lista
                if (Veiculo.jacdastrado(tbplaca.Text, listaveiculos))
                {
                    MessageBox.Show("Veiculo já Cadastrado!", "Alerta");
                }
                else
                {
                    
                 
                      listaveiculos.Add(new Veiculo(tbplaca.Text, Datahoraentrada));


                      tbentrada.AppendText(tbplaca.Text + " - " + Datahoraentrada + Environment.NewLine);

                      StreamWriter escritor = new StreamWriter("veiculosEntrada.txt", true);

                      escritor.WriteLine(tbplaca.Text + " - " + Datahoraentrada);

                      escritor.Close();

                      tbplaca.Text = "";

                }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {

                //Verifica se o arquivo existe
                if (File.Exists("veiculosEntrada.txt"))
                {
                    using (StreamReader sr = File.OpenText("veiculosEntrada.txt"))
                    {
                        tbentrada.Text = sr.ReadToEnd();
                    }

                }
                else
                {
                    MessageBox.Show("O Arquivo Não Foi Localizado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro inesperado!\n\n" + ex.Message);

            }


        }
    }
}
