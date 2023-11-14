using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploVenta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto[] producto = new Producto[10];

            for (int i = 0; i < 11; i++)
            {
                producto[i] = new Producto();
                Console.WriteLine("ingrese los datos");
                Console.WriteLine("ingrese codigo articulo");
                producto[i].setCodArticulo(int.Parse(Console.ReadLine()));
                Console.WriteLine("ingrese precio");
                producto[i].setPrecio(float.Parse(Console.ReadLine()));
                Console.WriteLine("Ingrese cod marca, mayor a 0 y menor a 11");
                producto[i].setCodMarca(int.Parse(Console.ReadLine()));
            }
        }
    }
}
