using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("\nIntrodusca su nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine($"\n Saludos {nombre}, espero que tengas un buen día.\n");
        }
    }
}