using System;
using System.Collections.Generic;
using System.Text;

namespace AppHerencia
{
    public class Adolecente : Humano
    {
        public Adolecente(string nombreAdolecente) : base(nombreAdolecente)
        {
        }

        public override void Pensar()
        {
            Console.WriteLine("Las hormonas me inpiden pensar con claridad.!");

            base.Pensar();
        }
    }
}
