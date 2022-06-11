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
        static List<Veiculo> listaveiculosSaida = new List<Veiculo>();
       

        public FrmCadastroVeiculos()
        {
            InitializeComponent();
            //EntityDados.carregarLista(listaveiculos);
           
            
        }



        /// <summary>
        /// Botão para fechar a plicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            
                 string dataentrada = tbdataentrada.Text;
                 string horaentrada = tbhoraentrada.Text;
               

                // Validando o campo para que não fique vazio
                if (tbplaca.Text.Equals(""))
                {
                    MessageBox.Show("É preciso digitar a Placa e escolher uma opção!", "Alerta");
                    return;
                }

                 string placaveiculo;
                //Alterando a fonta para Maiusculo
                tbplaca.Text = tbplaca.Text.ToUpper();


                    //gravar na lista desde que não estave na lista
                    if(Veiculo.jacdastrado(tbplaca.Text, listaveiculos))
                    {
                        MessageBox.Show("Veiculo já Cadastrado!", "Alerta");
                    }
                    else
                    {

                        //Adiciona os Dados na Lista
                        listaveiculos.Add(new Veiculo(tbplaca.Text, dataentrada, horaentrada));

                        //escreve os dados na lista e arquivo fazendo o append escrevendo um em baixo do outro
                        tbentrada.AppendText(tbplaca.Text + " - " + dataentrada + " - " + horaentrada + Environment.NewLine);

                        EntityDados.gravarNoarquivoEntrada(listaveiculos);


                         tbplaca.Text = "";
                         tbdataentrada.Text = "";
                         tbhoraentrada.Text = "";
                    }
                
                  
               
                
                
                   

                
            
           
        }

        /// <summary>
        /// Função para exibir na tela os os dados escritos no arquivo de Entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListarEntrada_Click(object sender, EventArgs e)
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


        /// <summary>
        /// Função para exibir na tela os os dados escritos no arquivo de Saida da Garagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void btnsaida_Click(object sender, EventArgs e)
        {
            string placaveiculo;
            string horasaida = tbhoraentrada.Text;
            string datasaida = tbdatasaida.Text;
            double velorcobrado  = 0;
            double tempopermanencia = 0;
            string dataentrada =   String.Format("{0:dd/MM/yyyy}");
            string horaentrada = String.Format("{0:dd/MM/yyyy}");



            //this.Datasaida = datasaida;
            //this.Horasaida = horasaida;
            //this.Tempopermanencia = tempopermanencia;
            //this.Valorcobrado = valorcobrado;

           

            //Adiciona os Dados na Lista,
          
            EntityDados.gravarNoArquivoSaida(listaveiculos);

        }
    }
}
