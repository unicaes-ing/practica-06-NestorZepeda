using System;
using System.Collections.Generic;
using System.Text;

namespace practica6
{
    class Ejercicio_3
    {

        private static void Expo(double nbase = 0, double elevado = 0, double exponente = 0)
        {
            if (nbase == 0)
            {
                Console.WriteLine();
                Console.WriteLine("un numero de base cero elevado a cualquier otro numero siempre es CERO");
            }
            else
            {
                if (nbase > 1)
                {
                    elevado = Math.Pow(nbase, exponente);
                    Console.WriteLine();
                    Console.WriteLine(string.Format("el numero: " + nbase + " elevado a " + exponente + " es = " + elevado));
                    Console.ReadKey();
                }
            }
        }
       public static void Ejercicio3()
        {
            int nbase , exponente ;
            double elevado = 0;
            Console.WriteLine("Ingrese el numero");
           nbase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("exponente a elevar");
           exponente = Convert.ToInt32(Console.ReadLine());
            Expo(nbase, elevado, exponente);
            Console.ReadKey(); 
        }
    }   
}
