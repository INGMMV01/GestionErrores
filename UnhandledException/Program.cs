using System;

namespace UnhandledException
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = 0;
            try
            {
                Console.WriteLine("Begin Block Try................");
                var a = 250;
                var b = 0;
                c = a / b;
                Console.WriteLine(string.Format("The result is = {0}", c));
                Console.WriteLine("End Block Try..................");
            }
            catch (FormatException ex)
            {
                // Catch Format Exception...........
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Always is executed
                Console.WriteLine("Block finally..................");
            }
            // program continues
            Console.WriteLine("Continue to next instruction...");
        }
    }
}
