using System;
using System.Collections.Generic;
using System.Text;

namespace GenericosRestricciones
{
    public class Electricista  : IParaEmpleados
    {
        private readonly double _salario;

        public Electricista(double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
