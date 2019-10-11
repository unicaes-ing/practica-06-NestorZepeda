using System;

namespace practica6
{
    class Ejercicio_1
    {
       
       public static void Ejercicio1()
        {

            Console.WriteLine("Ingrese el numero de la tabla que desea");
            int num = Convert.ToInt32(Console.ReadLine());
            tabla(num);

            Console.WriteLine("===================================");
            Console.WriteLine("Ingrese otro numero");
            num = Convert.ToInt32(Console.ReadLine());
            tabla(num, ConsoleColor.Magenta);



            Console.ReadKey();
        }
        public static void tabla(int num)
        {

            for (int i = 1; i < 11; i++)

            {
                Console.WriteLine(num + "*" + i + "=" + i * num);
            }
        }
        public static void tabla(int num, ConsoleColor colortabla)
        {

            Console.ForegroundColor = colortabla;
            tabla(num);
        }


    }
} 
