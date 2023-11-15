using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella botella1 = new Botella("Rojo", "Plastico");
            string cambioColor = "";
            string cambioMaterial = "";

            Console.WriteLine("el color es " +  botella1.getColor());
            Console.WriteLine("Ingrese el nuevo color");
            cambioColor = Console.ReadLine();

            botella1.setColor(cambioColor);

            Console.WriteLine("ingrese nuevo material");
            cambioMaterial = Console.ReadLine();
            botella1.setMaterial(cambioMaterial);

            Console.WriteLine("Ahora el color es " + botella1.getColor());
            Console.WriteLine("Ahora el material es " + botella1.getMaterial());

            Console.ReadKey();
        }

        
    }
}
