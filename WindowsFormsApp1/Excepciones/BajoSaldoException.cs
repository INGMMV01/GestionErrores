using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BajoSaldoException : LogicalException
    {
        public BajoSaldoException()
        : base("el saldo no es suficiente")
        {
        }
    }
}
