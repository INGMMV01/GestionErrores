using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoUnhandledException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Here the totally of your code
            }
            catch(Exception ex)
            {
                var error = string.Format("A fatal error happens. Please contact your support, the error is {0}", ex.Message);
                Console.WriteLine(error);
            }
        }
    }
}
