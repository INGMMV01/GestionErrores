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
            int j = 0;
        }

        private static void test1()
        {
            DateTime fecha;
            object valor = "2018-06-01";
            try
            {

                fecha = valor;
            }
            catch (InvalidCastException e)
            {
                fecha = null;
            }
        }

    }
}
