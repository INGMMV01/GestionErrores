using System;

namespace ErrorManagement
{
    class Program
    {
        /// <summary>
        /// How to work the try catch finally statement
        /// </summary>
        /// <param name="args">Not used</param>
        static void Main(string[] args)
        {
            try
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
                    // Catch Only format exception  ...........
                    Console.WriteLine(ex.Message);
                }
                //catch (DivideByZeroException ex)
                //{
                //    // Catch All...........
                //    Console.WriteLine(ex.Message);
                //}
                finally
                {
                    // Always is executed
                    Console.WriteLine("Block finally..................");
                }
                // program continues
                Console.WriteLine("Continue to next instruction...");
            }
            catch (Exception ex)
            {
                // Catch All...........
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
