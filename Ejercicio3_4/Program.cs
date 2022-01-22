using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio3_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int dia = 0;

            try
            {
                do
                {
                    Console.Write("\nInserte un número del 1 al 7: ");
                    dia = Convert.ToInt16(Console.ReadLine());
                    if (dia < 1 || dia > 7)
                    {
                        Console.WriteLine("\nHubo un error. Dato insertado incorrecto...\n");
                    }
                } while (dia < 1 || dia > 7);
            }
            catch (System.Exception) { throw; }

            Console.WriteLine("");
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
            Console.WriteLine("");
        }
    }
}