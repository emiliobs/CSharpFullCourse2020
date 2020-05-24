using System;
using System.Collections.Generic;

namespace AppQueue
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> edades = new Dictionary<string, int>();

            //rellenar el dicionary:
            edades.Add("Emilio", 55);

            edades.Add("Chealsy", 35);
            edades.Add("Camila", 78);

            edades["Jaime"] = 78;
            edades["Lina"] = 32;

            //Recorre el diccionario....
            foreach (KeyValuePair<string, int> personas in edades)
            {
                Console.WriteLine($"Nombre: {personas.Key} Edad: {personas.Value} ");
            }

        }
    }
}
