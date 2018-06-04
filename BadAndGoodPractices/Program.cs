using System;

namespace BadAndGoodPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = "23x";
                int myInteger = 0; ;
                var converter = new BadAndGoodPractices();
                Console.WriteLine("Tiempo 1: " + DateTime.Now.ToString());
                for (int i = 0; i < 10000; i++)
                {
                    myInteger = converter.ConvertTextInteger(input);
                }
                Console.WriteLine("Tiempo 2: " + DateTime.Now.ToString());
                Console.WriteLine(string.Format("The Conversion result is : {0}", myInteger));

                for (int i = 0; i < 10000; i++)
                {
                    myInteger = converter.ConvertGood(input);
                }
                Console.WriteLine("Tiempo 3: " + DateTime.Now.ToString());
                Console.WriteLine(string.Format("The Conversion result is : {0}", myInteger));
            }
            catch (Exception ex)
            {
                var error = string.Format("Fatal error: {0}"
                                          , ex.Message);
                Console.WriteLine(error);
            }
            Console.ReadLine();

        }
    }
}
