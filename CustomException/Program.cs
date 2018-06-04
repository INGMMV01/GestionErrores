using System;
using System.IO;

namespace CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Not right to execute
                throw new SecurityException();
            }
            catch (SecurityException ex)
            {
                // Report Error to user
                Console.WriteLine(ex.Message);
                // Store in log file the intrusion information.
                TextWriter tw = new StreamWriter("logfile.txt", true);
                tw.WriteLine("{0}: A Unauthorized access was detected", ex.TimeStamp.ToString());
                tw.Close();
            }
            catch (Exception ex)
            {
                var error = string.Format("Fatal error: {0} occurred "
                                          , ex.Message);
                Console.WriteLine(error);
            }
            Console.ReadLine();
        }
    }
}
