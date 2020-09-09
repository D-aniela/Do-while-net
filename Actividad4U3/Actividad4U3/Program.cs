using System;

namespace Actividad4U3
{
    class Program
    {
        static void Main(string[] args)
        {
            double precio = 0;
            double subtotal = 0;
            double descuento = 0;
            double total = 0;
            string respuesta = "";

            do
            {
                Console.WriteLine("Introuce la cantidad a pagar");
                string cantidad = Console.ReadLine();

                double cant = Convert.ToDouble(cantidad);

                if (cant < 1000)
                {
                    descuento = 0;
                }
                else if (cant >= 1000 && cant <= 2500)
                {
                    descuento = 0.1;
                }
                else if (cant > 2500 && cant <= 5000)
                {
                    descuento = 0.15;
                }
                else
                {
                    descuento = .2;
                }

                subtotal = cant;
                descuento = subtotal * descuento;
                total = subtotal - descuento;

                Console.WriteLine("El subtotal de la compra es de : " + subtotal);

                Console.WriteLine("Ingresar otra cantidad : 1=Si, 2=no");

                respuesta = Console.ReadLine();

            } while (respuesta == "si" || respuesta == "1");
            {
                Console.WriteLine("Subtotal : " + subtotal);
                Console.WriteLine("Descuento : " + descuento);
                Console.WriteLine("Total : " + total);
            }
        }
    }
}
