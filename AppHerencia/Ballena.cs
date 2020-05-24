using System;
using System.Collections.Generic;
using System.Text;

namespace AppHerencia
{
    public class Ballena: Mamiferos
    {
        public Ballena(string nombreBallena): base(nombreBallena)
        {

        }

        public void Nadar()
        {
            Console.WriteLine("Soy capaz  de nadar");
        }
    }
}
