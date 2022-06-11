using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagemteste
{
     class EntityDados
     {
        




        public static void gravarNoarquivo(List<Veiculo> listaveiculos)
        {

            StreamWriter escritor = new StreamWriter("veiculosEntrada.txt");

            foreach (Veiculo i in listaveiculos)
            {
                escritor.WriteLine(i.Placaveiculo + " - " + i.Datahoraentrada);
               
                
            }
            escritor.Close();

        }
    }
}
