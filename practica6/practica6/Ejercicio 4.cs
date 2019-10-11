using System;
using System.Collections.Generic;
using System.Text;

namespace practica6
{
    class Ejercicio_4
    {
        static void Binario(int bin)

        {
            if (bin != 0)
            {
                Binario(bin / 2);
                Console.Write
                    (+ bin % 2);
            }
        }
        public static int Ejercicio4()

        {
            int num;
            Console.WriteLine("conversion de numero decimal a binario");
            Console.WriteLine();
            Console.WriteLine("\nINTRODUCE UN NUMERO ENTERO PARA CONVERTIR");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("+========================================================+");
            Console.WriteLine("+      ESTA ES LA CONVERCION BINARIA DE EL NUMERO " + num + "     +");
            Console.WriteLine("+========================================================+");
            Binario(num);
            return 0;
        }
    }
}
