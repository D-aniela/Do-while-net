using System;

namespace EvidenciaAprendizaje
{
    class ZonaPreferente
    {
        public int Preferente = 0, Preferente1 = 0, Preferente2 = 0;

    }

    class ZonaCresta
    {
        public int Cresta = 0, Cresta1 = 0, Cresta2 = 0;

    }
    
    class ZonaLuneta
    {
        public int Luneta = 0, Luneta1 = 0, Luneta2 = 0;
    }
    
    class ZonaBalcon
    {
        public int Balcon = 0, Balcon1 = 0, Balcon2 = 0;
    }
    class PrimerPiso
    {
        public int Piso = 0, Piso1 = 0, Piso2 = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            ZonaPreferente preferente = new ZonaPreferente();
            ZonaCresta cresta = new ZonaCresta();
            ZonaLuneta luneta = new ZonaLuneta();
            ZonaBalcon balcon = new ZonaBalcon();
            PrimerPiso piso = new PrimerPiso();

            String opcion, s1;
            int resultado1, resultado2;

            Console.WriteLine("Número localidad   Precio       No. de Boletos");
            Console.WriteLine("1. Preferente       $2000         2000");
            Console.WriteLine("2. Cresta           $1500         3000");
            Console.WriteLine("3. Luneta           $1200         5000");
            Console.WriteLine("4. Balcon           $ 900         4000");
            Console.WriteLine("5. Primer piso      $ 700         8000");
        do{
        Console.WriteLine("Ingrese opción para localidad");
            opcion=Console.ReadLine();
            switch(opcion){
                    case "1":
                        Console.WriteLine("Cantidad boletos Preferente : ");
                        preferente.Preferente = Convert.ToInt32(Console.ReadLine());
                        if (preferente.Preferente > 2000)
                        {
                            Console.WriteLine("Ingrese una cantidad valida");
                        }
                        else
                        {
                            preferente.Preferente1 = preferente.Preferente1 + preferente.Preferente;
                            preferente.Preferente2 = preferente.Preferente1 * 2000;
                        }
                        break;
                    case "2":
                        Console.WriteLine("Cantidad boletos Cresta : ");
                        cresta.Cresta = Convert.ToInt32(Console.ReadLine());
                        if(cresta.Cresta > 3000)
                        {
                            Console.WriteLine("Ingrese una cantidad valida");
                        }
                        else
                        {
                        cresta.Cresta1 = cresta.Cresta1 + cresta.Cresta;
                        cresta.Cresta2 = cresta.Cresta1 * 1500;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Cantidad boletos Luneta : ");
                        luneta.Luneta = Convert.ToInt32(Console.ReadLine());
                        if(luneta.Luneta > 5000)
                        {
                            Console.WriteLine("Ingrese una cantidad valida");
                        }
                        else
                        {
                        luneta.Luneta1 = luneta.Luneta1 + luneta.Luneta;
                        luneta.Luneta2 = luneta.Luneta1 * 1200;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Cantidad boletos Balcon : ");
                        balcon.Balcon = Convert.ToInt32(Console.ReadLine());
                        if(balcon.Balcon > 4000)
                        {
                            Console.WriteLine("Ingrese una cantidad valida");
                        }
                        else
                        {
                        balcon.Balcon1 = balcon.Balcon1 + balcon.Balcon;
                        balcon.Balcon2 = balcon.Balcon1 * 900;
                        }
                        break;
                    case "5":
                        Console.WriteLine("Cantidad boletos Primer Piso :");
                        piso.Piso = Convert.ToInt32(Console.ReadLine());
                        if(piso.Piso > 8000)
                        {
                            Console.WriteLine("Ingrese una cantidad valida");
                        }
                        else
                        {
                        piso.Piso1 = piso.Piso1 + piso.Piso;
                        piso.Piso2 = piso.Piso1 * 700;
                        }
                        break;
                    default:
                        Console.WriteLine("No se pudo realizar la compra");
                        break;
            }
                resultado1 = preferente.Preferente1 + cresta.Cresta1 + luneta.Luneta1 + balcon.Balcon1 + piso.Piso1;
                resultado2 = preferente.Preferente2 + cresta.Cresta2 + luneta.Luneta2 + balcon.Balcon2 + piso.Piso2;

                Console.WriteLine("¿Desea continuar comprando? (s/n)");
                s1 = Console.ReadLine();
            } while (s1 == "s");
            Console.WriteLine("Boletos vendidos Zona Preferente : " + preferente.Preferente1);
            Console.WriteLine("Boletos vendidos Zona Cresta : " + cresta.Cresta1);
            Console.WriteLine("Boletos vendidos Zona Luneta : " + luneta.Luneta1);
            Console.WriteLine("Boletos vendidos Zona Balcon : " + balcon.Balcon1);
            Console.WriteLine("Boletos vendidos Zona Primer Piso : " + piso.Piso1);

            Console.WriteLine("Total de boletos de localidades vendidas : " + resultado2);
            Console.WriteLine("Total de boletos vendidos : " + resultado1);
            Console.ReadKey();
        }
    }
}
