using System;
using System.Collections.Generic;
using System.Text;

namespace GenericosRestricciones
{
    public class Secretaria  : IParaEmpleados
    {
        private readonly double _salario;

        public Secretaria( double salario)
        {
            _salario = salario;
        }

        public double GetSalario()
        {
            return _salario;
        }
    }
}
