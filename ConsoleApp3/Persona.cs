using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    class Persona
    {
        string _dni;
        string _nombre;
        int? _edad;

        public Persona(string dni, string nombre, int? edad)
        {
            _dni = dni;
            _nombre = nombre;
            _edad = edad;
        }

    }
}
