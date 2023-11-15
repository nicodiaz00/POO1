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

            Ventas ventaSemanal = new Ventas();
            int codigoCliente;
            int codigoArticulo;
            int cantidad;
            Console.WriteLine("ingrese codigo Cliente");
            codigoCliente = int.Parse(Console.ReadLine());
            ventaSemanal.CodigoCliente = codigoCliente;
            while(ventaSemanal.CodigoCliente != 0)
            {
                Console.WriteLine("Ingrese codigo articulo");
                codigoArticulo = int.Parse(Console.ReadLine());
                ventaSemanal.CodigoArticulo = codigoArticulo;
                Console.WriteLine("Ingrese la cantidad");
                cantidad = int.Parse(Console.ReadLine());
                ventaSemanal.Cantidad = cantidad;
            }

        }
    }
}
