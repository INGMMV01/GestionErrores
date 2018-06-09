using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ciclos = 3000;
            string entrada = "esto debería ser un número";
            int salida = 0;
            Conversor conversor = new Conversor();            

            Console.WriteLine("Tiempo 1: " + DateTime.Now.ToString());
            for (int i = 0; i < ciclos; i++)
            {
                salida = conversor.conTryCatch(entrada);
            }

            Console.WriteLine("Tiempo 2: " + DateTime.Now.ToString());

            for (int i = 0; i < ciclos; i++)
            {
                salida = conversor.conTryParse(entrada);
            }

            Console.WriteLine("Tiempo 3: " + DateTime.Now.ToString());

            Console.ReadLine();
        }
    }
}
