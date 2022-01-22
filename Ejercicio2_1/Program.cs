using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int lados = 0, longitud = 0, result = 0;

            try
            {
                Console.Write("\nInserte la cantidad de lados del polígono regular: ");
                lados = Convert.ToInt16(Console.ReadLine());

                Console.Write("\nInserte la longitud de uno de los lados del polígono regular: ");
                longitud = Convert.ToInt16(Console.ReadLine());
            }
            catch (System.Exception) { throw; }

            result = lados * longitud;

            Console.WriteLine($"\nPerímetro del polígono regular es: {result}\n");
        }
    }
}