using System;
using System.Collections.Generic;
using System.Text;

namespace AppHerencia
{
     public class Gorila: Mamiferos , IMamiferosTerrestres
    {
        public Gorila(string ameSerVivo) : base(ameSerVivo)
        {
        }

        public void Trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }

        public override  void Pensar()
        {
            Console.WriteLine("Pensamiennto Instintivo avanzado");
        }

        public int NumerosDePatas()
        {
            return 2;
        }
    }
}
