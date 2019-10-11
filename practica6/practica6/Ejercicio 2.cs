 using System;
using System.Collections.Generic;
using System.Text;

namespace practica6
{
    class Ejercicio_2
    {
       
        public static void Dibujo(int tamBase = 0, int tamAlto = 0)
        {
            int i, j;
            for (i = 1; i <= tamBase; i++) 
            {
                for (j = 1; j <= tamAlto; j++)
                {
                    Console.Write("* ", j);
                }
                Console.WriteLine(" ");
            }
        }
       
        public static void Dibujo(ConsoleColor colorTexto, string caracter, int tamBase = 0, int tamAlto = 0)
        {
            int i, j;
            Console.ForegroundColor = colorTexto;
            for (i = 1; i <= tamBase; i++) 
            {
                for (j = 1; j <= tamAlto; j++)
                {
                    Console.Write(" " + caracter );
                }
                Console.WriteLine(" ");
            }
        }
      
        public static void Dibujo( ConsoleColor colorTexto, string caracter, int tamBase = 0, int tamAlto = 0, int x = 0, int y = 0)
        {
            int i, j;
          
            Console.ForegroundColor = colorTexto;
           
            for (i = 1; i <= tamBase; i++) 
            {
                Console.SetCursorPosition(x, y++);
                for (j = 1; j <= tamAlto; j++)
                {
                    Console.Write(" "+caracter );
                }
                Console.WriteLine(" ");
            }
        }
       
        public static void Ejercicio2()
        {
            Console.WriteLine("introduce el alto de cuadrado");
            int tamBase = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("introduce el ancho de cuadrado");
            int tamAlto = int.Parse(Console.ReadLine());
            Dibujo( tamBase, tamAlto);
            Console.ReadKey();
            Console.Clear();
           
            Console.WriteLine("introduce el alto de cuadrado");
            tamBase = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("introduce el ancho de cuadrado");
             tamAlto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el caracter");
            string caracter = Convert.ToString(Console.ReadLine());
            Dibujo(ConsoleColor.Green, caracter, tamBase, tamAlto);
            Console.ReadKey();
            Console.Clear();
           
            Program p = new Program();
            Console.WriteLine("introduce el alto de cuadrado");
            tamBase = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("introduce el ancho de cuadrado");
            tamAlto = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el caracter");
             caracter = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Ingresa las coordenada en X");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Ingresa las coordenada en Y");
            int y = Convert.ToInt32(Console.ReadLine());
            Dibujo(ConsoleColor.Cyan, caracter, tamBase, tamAlto, x, y);
            Console.ReadKey();
        }
    }
}
