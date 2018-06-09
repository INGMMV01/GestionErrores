using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            test1();
            test2();
            test3();
        }

        private static void test1()
        {
            PersonaDAO personaDAO = new PersonaDAO();                        
            Persona persona = personaDAO.ObtenerPersona("123");
        }

        private static void test2()
        {
            PersonaDAO personaDAO = new PersonaDAO();
            Persona persona;
            try
            {
                persona = personaDAO.ObtenerPersona("123");
            }
            catch (Exception e)
            {
                persona = new Persona(null, null, null);
            }

            //aquí tendré que procesas y hacer condiciones sobre persona
            int i = 0;
        }

        private static void test3()
        {
            PersonaDAO personaDAO = new PersonaDAO();
            Persona persona = personaDAO.ObtenerPersonaCasoEspecial("123");

            //aquí tendré que procesas y hacer condiciones sobre persona
            int i = 0;
        }

    }
}
