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
                textBox_listaveiculosSaida.AppendText(i.Placaveiculo + "   -  " + i.Datasaida + "  -  " + i.Horasaida + "       -       " + i.Tempopermanencia + "    -   " + i.Valorcobrado + 
                    "     -     " + i.Dataentrada + "     -     " + i.Horaentrada  + Environment.NewLine);
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
        /// Função no evento do Botão Limpar campo placa e campo opções depois que o usuario
        /// Cadastrar o veiculo no FrmCadastroVeiclos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       

       
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
            if (Veiculo.jacdastrado(tbplaca.Text, listaEntrada))
            {
                MessageBox.Show("Veiculo já Cadastrado!", "Alerta");
            }
            else
            {

                //Adiciona os Dados na Lista
                listaEntrada.Add(new Veiculo(tbplaca.Text, dataentrada, horaentrada));

                //escreve os dados na lista e arquivo fazendo o append escrevendo um em baixo do outro
                textBox_listaVeiculosEntrada.AppendText(tbplaca.Text + " - " + dataentrada + " - " + horaentrada + Environment.NewLine);

                EntityDados.GravarNoarquivoEntrada(listaEntrada);

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


            if (tbhorasaida.Text == null)
            {
                MessageBox.Show("Campo não podfe ser Null", "Alerta");
            }

            //gravar na lista desde que não estave na lista
            if (Veiculo.jacdastrado(tbplaca.Text, listaEntrada))
            {
                MessageBox.Show("Veiculo já Cadastrado!", "Alerta");
            }
            if(listaEntrada.Count == 0)
            {
                MessageBox.Show("Lista Vazia", "Alerta");
            }

            int procuraveiculo = Veiculo.Localizado(tbplacasaida.Text, listaEntrada);

            if (procuraveiculo == -27)
            {
                MessageBox.Show("Veiculo não estar na garagem", "Alerta");
                return;
            }
            else
            {

                listaEntrada.RemoveAt(procuraveiculo);


                EntityDados.GravarNoarquivoEntrada(listaEntrada);
                EntityDados.LerdoArquivoEntrada(listaEntrada);
              
            }
            
            
                Veiculo veiculoTransf = listaEntrada[procuraveiculo];
                listaSaida.Add(veiculoTransf);
                EntityDados.GravarNoarquivoSaida(listaSaida);
             
              
            


           


            //listaSaida.Add(new Veiculo(tbplacasaida.Text, datasaida, horasaida, tempopermanencia, valorcobrado, dataentrada, horaentrada));
            //textBox_listaveiculosSaida.AppendText(tbplacasaida.Text + " - " + datasaida + " - " + horasaida + " - " + tempopermanencia + " - " +
            // valorcobrado + " - " + dataentrada + " - " + horaentrada + Environment.NewLine);
            //Adiciona os Dados na Text box Saiad da garagem,

           

             tbplacasaida.Text = "";
              tbhorasaida.Text = "";

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

        private void btndatahora_Click(object sender, EventArgs e)
        {
            DateTime datahora = DateTime.Now;
            btndatahora.Text = datahora.ToString();
            
                        
            
        }
    }
}
