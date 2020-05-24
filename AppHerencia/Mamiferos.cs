using System;
using System.Collections.Generic;
using System.Text;

namespace AppHerencia
{
    public class Mamiferos : Animales
    {
        private readonly string nombreSerVivo;

        public Mamiferos(string nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }

   

        public void CuidarCrias()
        {
            Console.WriteLine("Cuido de mís crias hasta que se valgan por si solas");
        }

        public override void GetNombre()
        {
            Console.WriteLine($"El nombre del mamifero es: {this.nombreSerVivo}");
        }

        public virtual void Pensar()
        {
            Console.WriteLine("Pensamiento básicao instintivo");
        }

        
    }
}
