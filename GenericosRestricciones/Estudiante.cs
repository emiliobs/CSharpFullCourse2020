using System;
using System.Collections.Generic;
using System.Text;

namespace GenericosRestricciones
{
    public class Estudiante
    {
        private readonly double _edad;

        public Estudiante(double edad)
        {
            _edad = edad;
        }

        public double GetEdad()
        {
            return _edad;
        }
    }
}
