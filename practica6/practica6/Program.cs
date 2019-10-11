using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("***************************************");
                Console.WriteLine("             Practica 6");
                Console.WriteLine("***************************************");
                Console.WriteLine();
                Console.WriteLine("Seleccione ejercicio a ver");
                Console.WriteLine();
                Console.WriteLine("1-)Ejercicio 1");
                Console.WriteLine("2-)Ejercicio 2");
                Console.WriteLine("3-)Ejercicio 3");
                Console.WriteLine("4-)Ejercicio 4");
                Console.WriteLine("5-)Salir");
                Console.WriteLine();
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Ejercicio_1.Ejercicio1();
                        break;
                    case 2:
                        Console.Clear();
                        Ejercicio_2.Ejercicio2();
                        break;
                    case 3:
                        Console.Clear();
                        Ejercicio_3.Ejercicio3();
                        break;
                    case 4:
                        Console.Clear();
                        Ejercicio_4.Ejercicio4();
                        break;
                    default:
                        break;
                }
            } while (op != 5);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();

        }


    }
}
