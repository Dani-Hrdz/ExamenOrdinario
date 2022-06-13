using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string producto;
            int precio, cantidad;

            try
            {
                Console.Write("Nombre del producto: ");
                producto = Console.ReadLine();
                Console.Write("Precio del producto: ");
                precio = int.Parse(Console.ReadLine());
                Console.Write("Cantidad a comprar: ");
                cantidad = int.Parse(Console.ReadLine());
                Compra c1 = new Compra(producto, cantidad, precio);
                c1.crearArchivo();
                c1.Desplegar();
                Console.ReadKey();
            }
            catch(FormatException e)
            {
                Console.WriteLine("\nError: " + e.Message);
                Console.WriteLine("\nRuta: " + e.StackTrace);
                Console.ReadKey();
            }
        }
    }
}
