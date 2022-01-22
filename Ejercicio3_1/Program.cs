using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num;
            try
            {
                Console.Write("\nInserte un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception) { throw; }

            if (num % 2 == 0)
            {
                Console.WriteLine($"\n{num} es par.\n");
            }
            else
            {
                Console.WriteLine($"\n{num} es impar.\n");
            }
        }
    }
}