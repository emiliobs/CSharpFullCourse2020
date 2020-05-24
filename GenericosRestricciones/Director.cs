using System;
using System.Collections.Generic;
using System.Text;

namespace GenericosRestricciones
{
    public class Director  : IParaEmpleados
    {
        private readonly double _salario;

        public Director(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
