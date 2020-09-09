using System;
using System.Threading;

namespace Actividad4
{
    class Autobus
    {
        //Declaramos propiedades
        public double Litros;
        public double Costo;
        public double Tiempo;
        public double Distancia;

        public double Velocidad = 80;
        public double PrecioGasolina = 20;
        public double Rendimiento = 8;

        public Autobus(double distancia)
        {
            Distancia = distancia;
        }

        public Autobus()
        {
        }

        public double SolicitaDistancia(double Distancia)
        {
            Console.WriteLine("Ingrese la distancia recorrida : ");
            Distancia = double.Parse(Console.ReadLine());

            Tiempo = Distancia / Velocidad;
            Litros = Distancia / Rendimiento;
            Costo = Litros * PrecioGasolina;
            return Distancia;
        }
        public double MuestraTiempo()
        {
            Tiempo = Distancia / Velocidad;
            return Tiempo;
        }

        public double MuestraLitros()
        {
            Litros = Distancia / Rendimiento;
            return Litros;
        }

        public double MuestraCosto(double costo)
        {
            Tiempo = Distancia / Velocidad;
            Litros = Distancia / Rendimiento;
            Costo = Litros * PrecioGasolina;
            return Costo;
        }

        public double MuestraDistancia()
        {
            return Distancia;
        }




        static void Main(string[] args)
        {
            double distancia, litros, costo;
            double precioGasolina = 20;
            double rendimiento = 8;
            double velocidad = 80;

            Autobus objeto1 = new Autobus();
            Console.WriteLine("Ingresa la distancia recorrida : ");
            distancia = double.Parse(Console.ReadLine());

            litros = distancia / rendimiento;
            costo = litros * precioGasolina;

            Console.WriteLine("Distancia: " + distancia);
            Console.WriteLine("Tiempo : " + distancia / velocidad);
            Console.WriteLine("Litros : " + distancia / rendimiento);
            Console.WriteLine("El costo es: " + objeto1.MuestraCosto(costo) + litros*precioGasolina);

            Console.ReadKey();
        }
    }
}
