using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            test1();
            test2();
            test3();

            Console.ReadKey();
        }

        private static void test1()
        {
            DateTime? fecha;
            try
            {
                fecha = new DateTime(2018, 20, 40);
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine("ha fallado");
            }
        }

        private static void test2()
        {
            DateTime? fecha;
            try
            {
                fecha = new DateTime(2018, 20, 40);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ha fallado");
            }
        }

        private static void test3()
        {
            string cadena = "2018-20-40";
            DateTime result;
            if (DateTime.TryParse(cadena, out result))
                Console.WriteLine(result);
            else
                Console.WriteLine("ha fallado");
        }

    }
}
