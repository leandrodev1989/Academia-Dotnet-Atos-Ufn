
using ConsoleEntity;

namespace Combiner
{
    class program
    {
        static void Main(string[] args)
        {

            using (var contexto = new ClienteContext())
            {
                Console.WriteLine("Iniciando o Programa");


                contexto.Clientes.Add(new Cliente( "leandro", "leandro@gmail.com", "01605620408"));

                contexto.SaveChanges();



                foreach(var cliente in contexto.Clientes)
                {
                    Console.WriteLine("NOME: " + cliente.Nome);
                    Console.WriteLine("Email: " + cliente.Email);
                    Console.WriteLine("Cpf: " + cliente.Cpf);
                }
               

                var quantidade_clientes = contexto.Clientes.Count();

                Console.WriteLine("Quantidade de Clientes" + quantidade_clientes);


                contexto.Clientes.First().Email = "grautec@live.com";
                contexto.SaveChanges();

                var consulta = contexto.Clientes.Where(p => p.Nome.Contains("leandro")).ToString();
                var listaClientes = contexto.Clientes.Where(p => p.Nome.Contains("leandro")).ToList();

                Console.WriteLine(consulta);
                Console.WriteLine(listaClientes);


            }
        }

    }

}

