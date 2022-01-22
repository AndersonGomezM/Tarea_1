using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_5
{
    class Program
    {
        public static void Main(string[] args)
        {
            var tiempo = DateTime.Now.ToString("dd/MM/yyyy");

            Console.Write("\nIntrodusca su nombre: ");
            var nombre = Console.ReadLine();

            Console.WriteLine($"\n Saludos {nombre}, espero que este bien, hoy {tiempo} es un buen día.\n");
        }
    }
}