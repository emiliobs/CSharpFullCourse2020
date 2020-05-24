using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>();


            Console.WriteLine("Introduce elementos en la colección y (0 para salir)");

            int ele = 1;

            while (ele != 0)
            {
                ele = Convert.ToInt32(Console.ReadLine());

                numeros.Add(ele);
            }


            numeros.RemoveAt(numeros.Count - 1);
            Console.WriteLine("Elemento Introducidos");

            foreach (var num in numeros)
            {
                Console.WriteLine(num);
            }

          
            Console.ReadKey();
        }
    }
}
