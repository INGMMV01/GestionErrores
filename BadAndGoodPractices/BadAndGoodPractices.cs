using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadAndGoodPractices
{
    public class BadAndGoodPractices
    {

        /// <summary>
        /// Bad use of Exception
        /// </summary>
        /// <param name="strInt">number as string</param>
        public int ConvertTextInteger(string strInt)
        {
            try
            {
                int value = int.Parse(strInt);
                return value;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Good test of conversion
        /// </summary>
        /// <param name="strInt"></param>
        /// <returns></returns>
        public int ConvertGood(string strInt)
        {
            int value = 0;
            int.TryParse(strInt, out value);
            return value;
        }
    }

}
