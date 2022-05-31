using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio7PrimeiraParte
{
    class UtilServico
    {

        /// <summary>
        /// Metodo para exibir a lista para mostrar os dados nela contida
        /// </summary>
        /// <param name="frase"></param>
        /// <param name="listaveiculos"></param>
        public static void exibirLista(string frase, List<Veiculo> listaveiculos)
        {
            if(listaveiculos.Count == 0)
            {
                Console.WriteLine("Lista Vazia!!");
            }
            else
            {
                Console.WriteLine(frase);
                foreach (Veiculo i in listaveiculos)
                {
                    Console.WriteLine(i.Placa + " - " + i.Datahoradaentrada);

                }

            }



        }



        /// <summary>
        /// metodo para carregar a lista quando abrir o programa
        /// </summary>
        /// <param name="listaveiculos"></param>
        public static void carregarListas(List<Veiculo> listaveiculos)
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.dat";
            string[] vetorDados;

            
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); //placa;data
                    DateTime Datahoraentrada = DateTime.Parse(vetorDados[1]);
                    listaveiculos.Add(new Veiculo(vetorDados[0], Datahoraentrada));
                } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
                
                leitor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Arquivo de usuários com problemas ou inexistente");
            }
        }


        /// <summary>
        /// metodo para verificar se o veiculo já foi cadastrado
        /// </summary>
        /// <param name="objeto"></param>
        /// <param name="listaveiculos"></param>
        /// <returns></returns>
        private static bool jaCadastrado(Veiculo objeto, List<Veiculo> listaveiculos)
        {
            foreach (Veiculo i in listaveiculos)
            {
                if (objeto.Placa.Equals(i.Placa) && objeto.Datahoradaentrada.Equals(i.Datahoradaentrada))
                {
                    return true;
                }
            }
            return false;
        }



        /// <summary>
        /// Metodo para gravar informações para pelo usuario
        /// </summary>
        /// <param name="objeto"></param>
        private static void gravarArquivo(Veiculo objeto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("garagem.dat", true);

                escritor.WriteLine(objeto.Placa + ";" + objeto.Datahoradaentrada);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Arquivo de usuários com problemas nos Dados {e.Message}");
            }
        }





        /// <summary>
        /// Metodo para fazer o cadastro da placa do veiculo e colocando a data e hora automaticamente
        /// Com validação para verificar se o veiculo já estar cadastrado
        /// </summary>
        /// <param name="frase"></param>
        /// <param name="listaveiculos"></param>
        public static void  CadastrarVeiculos(string frase, List<Veiculo> listaveiculos)
        {



            Console.WriteLine(frase);
            string placa;

            do
            {
                Console.Write("Digite a Placa do veiculo: ");
                placa = Console.ReadLine();


                if (placa.Length != 7)
                {
                    Console.WriteLine("Digite a placa com 7 caracteres.");


                    if (placa == null || string.IsNullOrEmpty(placa) || string.IsNullOrWhiteSpace(placa))
                    {
                        Console.WriteLine("Placa não Pode ser vazia ou nula!!");
                        break; 

                    }
                    else
                    {
                        Console.WriteLine("Veiculo Cadastrado com Sucesso!!");
                    }
                }
                else
                {
                    break;
                }
                

                Console.WriteLine("Veiculo Cadastrado com Sucesso!!");
            } while (true);


          
            

            Veiculo objeto = new Veiculo(placa);

            if (!UtilServico.jaCadastrado(objeto, listaveiculos))
            {
                listaveiculos.Add(objeto);
                //gravar no arquivo
                UtilServico.gravarArquivo(objeto);
            }
            else
            {
                Console.WriteLine("Veículo com esse placa já está na base de dados!");
            }
        }




    }
}
