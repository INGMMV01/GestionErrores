using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class PersonaDAO
    {
        Persona dummy = new Persona("987654321", "marcos", 39);

        public Persona ObtenerPersona(string dni)
        {
            //accedo a BD y obtengo 0 resultados
            int resultados = 0;

            if (resultados == 0)
                throw new Exception("no existe la persona");
            else
                return dummy;
        }

        public Persona ObtenerPersonaCasoEspecial(string dni)
        {
            //accedo a BD y obtengo 0 resultados
            int resultados = 0;

            if (resultados == 0)
                return new Persona(null, null, null);
            else //devolver resultados
            {
                return dummy;
            }
        }


    }
}
