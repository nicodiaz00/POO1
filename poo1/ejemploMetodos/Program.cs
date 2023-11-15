using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaNueva = new Persona();

            string nombre;

            Console.WriteLine("ingrese el nombre de la persona");
            nombre = Console.ReadLine();

            personaNueva.setNombre(nombre);

            Console.WriteLine("El nombre de la persona es" + personaNueva.getNombre());

            Console.WriteLine(personaNueva.saludar());

            Console.ReadKey();
        }
    }
}
