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
            Console.Clear();
            Console.WriteLine("test1");
            DateTime? fecha;
            int year = 2018;
            int month = 20;
            int day = 40;
            try
            {
                fecha = new DateTime(year, month, day);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private static void test2()
        {
            Console.Clear();
            Console.WriteLine("test2");

            DateTime? fecha;
            int year = 2018;
            int month = 20;
            int day = 40;
            try
            {
                fecha = new DateTime(year, month, day);
            }
            catch (ArgumentOutOfRangeException e)
            {
                string mensaje = String.Format("La fecha {0}-{1}-{2} no es válida", year, month, day);
                ArgumentOutOfRangeException ex = new ArgumentOutOfRangeException(mensaje, e);                
                Console.WriteLine(ex.ToString());
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
