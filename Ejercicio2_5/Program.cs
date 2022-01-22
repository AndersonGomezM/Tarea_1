using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal euros = 0.0m, dolar = 0.0m, convercion = 1.13m;

            try
            {
                Console.Write("\nCantidad en dolares: ");
                dolar = Convert.ToDecimal(Console.ReadLine());
            }
            catch (System.Exception) { throw; }

            euros = dolar * convercion;

            Console.WriteLine($"\n{dolar}$ = {euros} euros\n");
        }
    }
}