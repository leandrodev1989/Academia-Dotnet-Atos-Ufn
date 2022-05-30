///Lendo Arquivos 
///


//namespace ManipulacaoArquivo
//{
//    class Program
//    {
//        public static void Main(string[] argas)
//        {
//         n  

//            Console.WriteLine("Digite o  nome do Caminho");
//            string filePath = Console.ReadLine();

//            using (StreamWriter stream = new StreamWriter(filePath))
//            {
//                if(filePath.Equals(filePath))
//                {
//                    Console.WriteLine("Digite um caminho diferente esse já existe!!");
//                }
//                else if(!filePath.Equals(filePath))

//                stream.WriteLine("A persistência realiza o impossível. Provérbio Chinês\n" +
//                    "Meu maior defeito, nos tranqüilos dias da infância, consistia em desanimar\n" +
//                    " com demasiada facilidade quando uma tarefa qualquer me parecia difícil.\n" +
//                    "Eu podia ser tudo, menos um menino persistente.");
//            }

//        }
//    }
//}




bool escolheuSair = false;
while (escolheuSair == false)
{
    //Criação da Exibição do Menu
    Console.WriteLine("Sistema de Estoque DIO");
    Console.WriteLine("1-Listar\n2-Adicionar\n3-Remover\n4-Adicionar entrada\n5-Adicionar Saida\n6-Sair");
    string opStr = Console.ReadLine();
    int opInt = int.Parse(opStr);

    //Condição criada caso o usuario digite um numero diferente da opção do Menu
    if (opInt > 0 && opInt < 7)
    {
        Menu escolha = (Menu)opInt;

        switch (escolha)
        {
            case Menu.Listar:
                break;
            case Menu.Adicionar:
                break;
            case Menu.Remover:
                break;
            case Menu.Entrada:
                break;
            case Menu.Saida:
                break;
            case Menu.Sair:
                escolheuSair = true;
                break;
        }

    }
    else
    {
        escolheuSair = true;
    }
    Console.Clear();
}

enum Menu
{
    Listar = 1,
    Adicionar,
    Remover,
    Entrada,
    Saida,
    Sair
}