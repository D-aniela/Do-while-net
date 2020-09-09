using System;

namespace EvidenciaU1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*le pediremos al usuario la cantidad que desea retirar
             en este caso las variables deben ser enteras como nos indica el problema
            y las declaramos*/
            int monto, quinientos, doscientos, cien, cincuenta;

            /*Aqui le pediremos al usuario que ingrese la cantidad a retirar
             indicamos que lea lo que el usuario ingresó*/
            Console.WriteLine("Ingrese cantidad a retirar: ");
            monto = int.Parse(Console.ReadLine());

            /*Realizamos las condicionales en la que indica que
             si el monto entre 50 regresa un denominador 0 entonces
            seguiremos con el proceso, debe ser 50 porque a partir de este
            son los billetes que estan disponibles*/
            if(monto % 50 == 0)
            {
                /*Entonces primero se ejecutará el monto entre 500 para saber cuántos billetes de
                 500 deben ser*/
                quinientos = monto / 500;
                /*Luego si el denominador es cero entonces deberá seguir a la siguientes
                 operación y así sucesivamente*/
                monto = monto % 500;
                doscientos = monto / 200;
                monto = monto % 200;
                cien = monto / 100;
                monto = monto % 100;
                cincuenta = monto / 50;
                monto = monto % 50;

                /*Al terminar el proceso anterior entonces se imprimiran los resultados*/
                Console.WriteLine("Número de billetes a entregar: ");
                Console.WriteLine("500 pesos: " + quinientos);
                Console.WriteLine("200 pesos: " + doscientos);
                Console.WriteLine("100 pesos: " + cien);
                Console.WriteLine("50 pesos: " + cincuenta);
            }
            else
            {
                /*pero si no cumple la condicion anterior entonces el retiro no sera efectuado*/
                Console.WriteLine("La cantidad ingresada no es válida");
                Console.WriteLine("La cantidad ingresada debe ser múltiplo de 50");
            }
            /*Se utiliza para esperar hasta que el usuario presione una tecla y terminar el proceso*/
            Console.ReadKey();
        }
    }
}
