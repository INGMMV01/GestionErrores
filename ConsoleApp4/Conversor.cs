using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Conversor
    {
        public int conTryCatch(string entrada)
        {
            try
            {
                int value = int.Parse(entrada);
                return value;
            }
            catch
            {
                return 0;
            }
        }

        public int conTryParse(string entrada)
        {
            int value = 0;
            int.TryParse(entrada, out value);
            return value;
        }
    }

}
