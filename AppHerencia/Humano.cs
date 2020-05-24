using System;
using System.Collections.Generic;
using System.Text;

namespace AppHerencia
{
    public class Humano : Mamiferos
    {
        public Humano(string nombreSerVivo) : base(nombreSerVivo)
        {
        }

        public override void Pensar()
        {
            Console.WriteLine("Soy capaz de pensar ¿?");
        }
    }
}
