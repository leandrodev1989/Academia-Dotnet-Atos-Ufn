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
         List<Veiculo> listaveiculosEntrada = new List<Veiculo>();
         List<Veiculo> listaveiculosSaida = new List<Veiculo>();

        public FrmCadastroVeiculos()
        {
            InitializeComponent();
           
            
            EntityDados.LerdoArquivoEntrada(listaveiculosEntrada);
            PopularListatextBoxListagaragem(listaveiculosEntrada);

            EntityDados.LerdoArquivoSaida(listaveiculosSaida);
            PopularListatextBoxListaSaida(listaveiculosSaida);
           
        }



        /// <summary>
        /// Metodo para Popular a text box lista veiculos Saida do estacionamento
        /// </summary>
        /// <param name="listaveiculosSaida"></param>
        private void PopularListatextBoxListaSaida(List<Veiculo> lista)
        {
            textBox_listaveiculosSaida.Text = "";
            foreach (Veiculo i in lista)
            {
                textBox_listaveiculosSaida.AppendText(i.Placaveiculo + " - " + i.Datasaida + " - " + i.Horasaida + " - " + i.Tempopermanencia + " - " + i.Valorcobrado + 
                    " - " + i.Dataentrada + " - " + i.Horaentrada  + Environment.NewLine);
            }
        }


        /// <summary>
        /// Metodo para Popular a text box lista veiculos entrada
        /// </summary>
        /// <param name="listaveiculosEntrada"></param>
        private void PopularListatextBoxListagaragem(List<Veiculo> lista)
        {
            textBox_listaVeiculosEntrada.Text = "";
            foreach (Veiculo i in lista)
            {
                textBox_listaVeiculosEntrada.AppendText(i.Placaveiculo + " - " + i.Dataentrada + " - " + i.Horaentrada + Environment.NewLine);
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
        /// Função no evento do Botão Limpar campo placa e campo opções depois que o usuario
        /// Cadastrar o veiculo no FrmCadastroVeiclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            tbplaca.Text = "";
            listaveiculosEntrada.Clear();
        }

       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncadastrar_Click(object sender, EventArgs e)
        {

            string  dataentrada = DateTime.Now.ToString("dd-MM-yyyy");
            string horaentrada = tbhoraentrada.Text;
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
            if (Veiculo.jacdastrado(tbplaca.Text, listaveiculosEntrada))
            {
                MessageBox.Show("Veiculo já Cadastrado!", "Alerta");
            }
            else
            {

                //Adiciona os Dados na Lista
                listaveiculosEntrada.Add(new Veiculo(tbplaca.Text, dataentrada, horaentrada));

                //escreve os dados na lista e arquivo fazendo o append escrevendo um em baixo do outro
                textBox_listaVeiculosEntrada.AppendText(tbplaca.Text + " - " + dataentrada + " - " + horaentrada + Environment.NewLine);

                EntityDados.GravarNoarquivoEntrada(listaveiculosEntrada);

                MessageBox.Show("Entrada  Registrada!\n" +  "PLACA:"+ tbplaca.Text + 
                    "\n" + "DATA:" + dataentrada  + "\n" + "HORA:" 
                    + horaentrada + "\n" + "Valor Por Hora: 5,00","Alerta" );

                tbplaca.Text = "";
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


        /// <summary>
        /// Função para exibir na tela os os dados escritos no arquivo de Saida da Garagem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void btnsaida_Click(object sender, EventArgs e)
        {


            string horasaida = tbhorasaida.Text;
            string datasaida = DateTime.Now.ToString("dd-MM-yyyy");
            int tempopermanencia = 0;
            double valorcobrado = 0;
            string dataentrada = DateTime.Now.ToString("dd-MM-yyyy");
            string horaentrada = DateTime.Now.ToString("HH-mm"); 



           
            //Alterando a fonta para Maiusculo
            tbplacasaida.Text = tbplacasaida.Text.ToUpper();

            // Validando o campo para que não fique vazio
            if (tbplacasaida.Text.Equals(""))
            {
                MessageBox.Show("É preciso digitar a Placa e escolher uma opção!", "Alerta");
                return;
            }

            if (tbplacasaida.Text.Length != 7)
            {
                MessageBox.Show("É preciso digitar a Placa Com 7 Caracteres!", "Alerta");
                return;
            }


            listaveiculosSaida.Add(new Veiculo(tbplacasaida.Text, datasaida, horasaida,tempopermanencia,valorcobrado,dataentrada,horaentrada));

            textBox_listaveiculosSaida.AppendText(tbplacasaida.Text + " - " + datasaida + " - " + horasaida + " - " + tempopermanencia + " - " +
                valorcobrado + " - " + dataentrada +" - " + horaentrada + Environment.NewLine);
            //Adiciona os Dados na Text box Saiad da garagem,

            EntityDados.GravarNoarquivoSaida(listaveiculosSaida);

            tbplacasaida.Text = "";
            tbhorasaida.Text = "";

        }


    }
}
