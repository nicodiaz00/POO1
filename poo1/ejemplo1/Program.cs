using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona();

            personaUno.setEdad(20);

            Console.WriteLine("la edad es" + personaUno.getEdad());
            Console.ReadKey();
        }
    }
}
