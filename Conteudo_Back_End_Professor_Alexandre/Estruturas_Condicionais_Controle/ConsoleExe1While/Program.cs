namespace ConsoleEx1While
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ExWhile();
            Ex();
        }

        static void ExWhile()
        {
            
            int x;

            Console.Write("Entre com o valor: ");
            x = int.Parse(Console.ReadLine());
            while(x < 100)
            {
               
                    Console.WriteLine("Contador = " + x);
                x++;
                
                
            }
        }

        static void Ex()
        {
            int y;
            Console.Write("Entre com o valor: ");
            y = int.Parse(Console.ReadLine());

            while ( y < 100)
            {
                Console.WriteLine("Contador = " + y);
                y += 2;
            }
            
        }
    }
}
