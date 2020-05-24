using System;
using System.Collections.Generic;
using System.Text;

namespace AppHerencia
{
     public abstract  class Animales
    {

        public void Respirar()
        {
            Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void GetNombre();
    }
}
