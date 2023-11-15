using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploDosMetodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella botellaNueva = new Botella("rojo", "aluminio");
            float cantidadMomentanea;

            Console.WriteLine("la capacidad maxima de la botella es " + botellaNueva.Capacidad);
            Console.WriteLine("la cantidad actual es " + botellaNueva.CantidadActual);

            Console.WriteLine("ingrese cuanto quiere ponerle a su botella");
            cantidadMomentanea = float.Parse(Console.ReadLine());
            botellaNueva.CantidadActual = cantidadMomentanea;

            Console.WriteLine("la cantidad ahora es " + botellaNueva.CantidadActual);
            Console.WriteLine("Ahora debe pagar " + botellaNueva.recargar());

            Console.ReadKey();
        }
    }
}
