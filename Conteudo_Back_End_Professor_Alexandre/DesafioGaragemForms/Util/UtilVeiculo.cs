using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garagemteste.Util
{
    class UtilVeiculo
    {
       

        /// <summary>
        /// Metodo Para Verificar se A placa do veiculo já estar cadastrada
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static bool jacdastrado(string placaveiculo, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placaveiculo.Equals(placaveiculo))
                {
                    return true;

                }

            }
            return false;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="placaveiculo"></param>
        /// <param name="lista"></param>
        /// <returns></returns>
        public static int Localizado(string placaveiculo, List<Veiculo> lista)
        {
            foreach (Veiculo i in lista)
            {
                if (i.Placaveiculo.Equals(placaveiculo))
                {
                    return lista.IndexOf(i);              
                }
            }
            return -27;
        }  
    }
}
