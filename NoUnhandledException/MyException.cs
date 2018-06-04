using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoUnhandledException
{
    /// <summary>
    /// Concatenate all messages in only
    /// one string.
    /// </summary>
    public class MyException: Exception
    {
        public string MyMensaje { get; set; } 
        public MyException(Exception previa)
        {
            var ecp = previa;
            MyMensaje = previa.Message;
            while (ecp.InnerException != null)
            {
                ecp = ecp.InnerException;
                MyMensaje += string.Format(", {0} ", ecp.Message);
            }
        }
    }
}
