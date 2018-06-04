using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            test1();
            test2();
            test3();
            test4();
        }

        private static void test1()
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5 };
            int index = 100;
            int numero = numeros[index];
        }

        private static void test2()
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5 };
            int index = 100;
            int numero;
            try
            {
                numero = numeros[index];
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }            
        }

        private static void test3()
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5 };
            int index = 100;
            int numero;
            try
            {
                numero = numeros[index];
            }
            catch (IndexOutOfRangeException e)
            {
                numero = -1;
            }
        }

        private static void test4()
        {
            int[] numeros = { 0, 1, 2, 3, 4, 5 };
            int index = 100;
            int numero;

            if (index < numeros.Length)
                numero = numeros[index];
            else
                numero = -1;
        }

    }
}
