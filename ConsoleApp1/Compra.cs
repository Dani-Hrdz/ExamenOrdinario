using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Compra
    {
        string producto;
        int cantidad, precio;
        StreamWriter sw = null;

        public Compra(string producto, int cantidad, int precio)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.precio = precio;
            
        }
        public void crearArchivo()
        { 

            try
            {
                sw = new StreamWriter("Compras.txt", true);
                sw.Write("\nProducto: " + producto);
                sw.Write("\nCantidad de compra: " + cantidad);
                sw.Write("\nPrecio: {0:C}", precio);
                sw.Close();
                    
            }
            catch (IOException e)
            {
                Console.WriteLine("\nError: " + e.Message);
                Console.WriteLine("\nRuta: " + e.StackTrace);
            } 
        }
        public void Desplegar()
        {
            Console.Clear();
            Console.WriteLine("Producto: " + producto);
            Console.WriteLine("Cantidad a comprar: " + cantidad);
            Console.WriteLine("Precio: {0:C}", precio);

        }
    }
    
}
