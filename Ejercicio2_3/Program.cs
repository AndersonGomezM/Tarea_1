using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio2_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal pi = 3.1416m, rad, result;
            Console.Write("Inserte medida en grados: ");
            rad = Convert.ToDecimal(Console.ReadLine());

            result = (rad * pi)/180;

            Console.WriteLine($"\n{rad}º = {decimal.Round(result, 5)}rad\n");
        }
    }
}