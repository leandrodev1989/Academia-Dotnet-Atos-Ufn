using Garagemteste.Util;
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
         static List<Veiculo> listaEntrada = new List<Veiculo>();
         static List<Veiculo> listaSaida = new List<Veiculo>();

        public FrmCadastroVeiculos()
        {
            InitializeComponent();
           
            
            EntityDados.LerdoArquivoEntrada(listaEntrada);
            PopularListatextBoxListagaragem(listaEntrada);

            EntityDados.LerdoArquivoSaida(listaSaida);
            PopularListatextBoxListaSaida(listaSaida);
           
        }



        /// <summary>
        /// Metodo para Popular a text box lista veiculos Saida do estacionamento
        /// </summary>
        /// <param name="listaveiculosSaida"></param>
        private void PopularListatextBoxListaSaida(List<Veiculo> listaveiculos)
        {
            textBox_listaveiculosSaida.Text = "";
            foreach (Veiculo i in listaveiculos)
            {
                textBox_listaveiculosSaida.AppendText(i.Placaveiculo + "  -  " + i.Tempopermanencia + " - " + i.Valorcobrado +  Environment.NewLine);
            }
        }


        /// <summary>
        /// Metodo para Popular a text box lista veiculos entrada
        /// </summary>
        /// <param name="listaveiculosEntrada"></param>
        private void PopularListatextBoxListagaragem(List<Veiculo> listaveiculos)
        {
            textBox_listaVeiculosEntrada.Text = "";
            foreach (Veiculo i in listaveiculos)
            {
                textBox_listaVeiculosEntrada.AppendText(i.Placaveiculo + "    -    " + i.Dataentrada + "    -   " + i.Horaentrada + Environment.NewLine);
            }
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncadastrar_Click(object sender, EventArgs e)
        {

         
            // Validando o campo para que não fique vazio
            if (tbplaca.Text.Equals(""))
            {
                MessageBox.Show("É preciso digitar a Placa e escolher uma opção!", "Alerta");
                return;
            }

            if (tbplaca.Text.Length != 7 )
            {
                MessageBox.Show("É preciso digitar a Placa Com 7 Caracteres!", "Alerta");
                return;
            }

            

            
            //Alterando a fonta para Maiusculo
            tbplaca.Text = tbplaca.Text.ToUpper();

            //gravar na lista desde que não estave na lista
            if (UtilVeiculo.jacdastrado(tbplaca.Text, listaEntrada))
            {
                MessageBox.Show("Veiculo já Cadastrado!", "Alerta");
            }
            else
            {

                //Adiciona os Dados na Lista
                listaEntrada.Add(new Veiculo(tbplaca.Text, dtData.Value,dtHora.Value));

                EntityDados.GravarNoarquivoEntrada(listaEntrada);

                //escreve os dados na lista e arquivo fazendo o append escrevendo um em baixo do outro
                textBox_listaVeiculosEntrada.AppendText(tbplaca.Text + " - " + dtData.Value + " - "
                + dtHora.Value + Environment.NewLine);

                

                MessageBox.Show("Entrada  Registrada!\n" +  "PLACA:"+ tbplaca.Text + 
                    "\n" + "DATA:" + dtData.Value + "\n" + "HORA:" 
                    + dtHora.Value + "\n" + "Valor Por Hora: 5,00","Alerta" );

                tbplaca.Text = "";
              

              
            }
        }

        /// <summary>
        /// Função para exibir na tela os os dados escritos no arquivo de Entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonListarEntrada_Click(object sender, EventArgs e)
        {
            if (listaEntrada.Count == 0)
            {
                MessageBox.Show("Garagem Vazia!", "Alerta!");
            }


            try
            {

                //Verifica se o arquivo existe
                if (File.Exists("veiculosEntrada.txt"))
                {
                    using (StreamReader sr = File.OpenText("veiculosEntrada.txt"))
                    {
                        textBox_listaVeiculosEntrada.Text = sr.ReadToEnd();
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

      

        private void btnsaida_Click(object sender, EventArgs e)
        {  
            //Alterando a fonta para Maiusculo
            tbplaca.Text = tbplaca.Text.ToUpper();


            // Validando o campo para que não fique vazio
            if (tbplaca.Text.Equals(""))
            {
                MessageBox.Show("É preciso digitar a Placa e escolher uma opção!", "Alerta");
                return;
            }

            if (tbplaca.Text.Length != 7)
            {
                MessageBox.Show("É preciso digitar a Placa Com 7 Caracteres!", "Alerta");
                return;
            }



            //gravar na lista desde que não estave na lista
            if (UtilVeiculo.jacdastrado(tbplaca.Text, listaEntrada))
            {
               // MessageBox.Show("Veiculo Saindo da Garagem!", "Alerta");
            }
            if(listaEntrada.Count == 0)
            {
                MessageBox.Show("Lista Vazia", "Alerta");
            }

            int procuraveiculo = UtilVeiculo.Localizado(tbplaca.Text, listaEntrada);

            if (procuraveiculo == -27)
            {
                MessageBox.Show("Veiculo não estar na garagem", "Alerta");
                return;
            }
            else
            {
                MessageBox.Show("Veiculo Saindo da Garagem!", "Alerta");
            }

               RealizarCobraca();  
          
               tbplaca.Text = "";
           

        }

        private  void RealizarCobraca()
        {

            int localizar;
            foreach (Veiculo i in listaEntrada)
            {
                if (i.Placaveiculo.Equals(tbplaca.Text))
                {
                    localizar = listaEntrada.IndexOf(i);

                    listaSaida.Add(i);
                    i.Horasaida = DateTime.Now;
                    i.Tempopermanencia = i.Horasaida.Subtract(i.Horaentrada);
                    i.Valorcobrado = Math.Ceiling(i.Tempopermanencia.TotalMinutes / 60) * 5;

                    EntityDados.GravarNoarquivoSaida(listaSaida);
                    textBox_listaveiculosSaida.AppendText(tbplaca.Text + " - " + (int)i.Tempopermanencia.TotalHours + " - " + i.Valorcobrado);

                    listaEntrada.RemoveAt(localizar);
                    EntityDados.GravarNoarquivoEntrada(listaEntrada);

                    MessageBox.Show($"PLACA:{tbplaca.Text}TP:\n{(int)i.Tempopermanencia.TotalHours} HORA(s)\n{i.Valorcobrado} Reais");
                    break;
                }
            }
        }

        private void btnlistarsaisa_Click(object sender, EventArgs e)
        {

            try
            {

                //Verifica se o arquivo existe
                if (File.Exists("veiculosSaida.txt"))
                {
                    using (StreamReader sr = File.OpenText("veiculosSaida.txt"))
                    {
                         textBox_listaveiculosSaida.Text = sr.ReadToEnd();
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
