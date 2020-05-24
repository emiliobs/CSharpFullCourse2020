using System;
using System.Collections.Generic;
using System.Text;

namespace AppHerencia
{
    public class Caballo: Mamiferos, IMamiferosTerrestres , IAnimalesYDeportes, ISaltoConPatas
    {
        public Caballo(string nombreSerVivo) : base(nombreSerVivo)
        {
        }

        public bool EsOlimpico()
        {
            return true;
        }

        public void Galopar()
        {
            Console.WriteLine("Soy capaz de galopar");

          
        }                          

        int IMamiferosTerrestres.NumerosDePatas()
        {
            return 4;
        }

        public string TipoDeporte()
        {
            return "Hípica";
        }

        int ISaltoConPatas.NumerosDePatas()
        {
            return 2;
        }
    }
}
