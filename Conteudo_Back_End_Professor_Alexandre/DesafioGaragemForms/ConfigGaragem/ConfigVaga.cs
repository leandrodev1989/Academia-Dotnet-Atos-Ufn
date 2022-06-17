using System.IO;
using System.Windows.Forms;

namespace Garagemteste.ConfigGaragem
{
    class ConfigVaga
     {

        /// <summary>
        /// Atributos
        /// </summary>
        int tamanhogaragem;
        double valorhora;


        /// <summary>
        /// Construtor para criar e fazer alterações no numero de vagas da garagem
        /// </summary>
        /// <param name="tamanhogaragem"></param>
        /// <param name="valor"></param>
        public ConfigVaga(int tamanhogaragem, double valorhora)
        {
            this.Tamanhogaragem = tamanhogaragem;
            this.Valorhora = valorhora;
        }


        /// <summary>
        /// Metodo Para Gravar o Espaço da garagem no arquivo
        /// </summary>
        public void GravarVagas()
        {
            StreamWriter write = new StreamWriter("Configravar.txt");

            //Cria o arquivo caso não existe
            
            
                write.WriteLine(tamanhogaragem + ";" + valorhora);
                write.Flush();
                write.Close();

                MessageBox.Show("Quantidade de Vagas Registrada No estacionamentro com exito.", "Alerta!");
                   
        }


        /// <summary>
        /// Metodo que ler os Dados gravados no arquivo vags na garagem
        /// </summary>
        public void Lergravados()
        {
            StreamReader leitor2;
            string linha;
            string[] vetorler;
            // Verifica se o Arquivo Exiiste
            if (File.Exists("Configravar.txt"))
            {
                leitor2 = new StreamReader("Configravar.txt");
                do
                {
                    linha = leitor2.ReadLine();
                    if (linha != null)
                    {
                        vetorler = linha.Split(';');

                        this.Tamanhogaragem = int.Parse(vetorler[0]);
                        this.Valorhora = int.Parse(vetorler[1]);
                    }
                } while (!leitor2.EndOfStream);
            }
            else
            {             
            }
        }


        /// <summary>
        /// Construtor padrão
        /// </summary>
        public ConfigVaga()
        {

        }


        /// <summary>
        /// Gets e Sets Dos atributos para fazer as devidas auterações
        /// </summary>
        public int Tamanhogaragem { get => tamanhogaragem; set => tamanhogaragem = value; }
        public double Valorhora{ get => valorhora; set => valorhora = value; }


     }

   
}
