using System;
using System.Collections.Generic;
using System.Text;

namespace AppHerencia
{
    public class Lagartija : Animales
    {
        public object nombreReptil { get; private set; }

        public Lagartija(string nombre)
        {
            nombreReptil = nombre;
        }
                           
        public override void GetNombre()
        {
            Console.WriteLine($"El ombre del reptil es: {nombreReptil}");
        }
    }
}
