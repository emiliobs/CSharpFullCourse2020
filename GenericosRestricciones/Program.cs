using System;

namespace GenericosRestricciones
{
    class Program
    {
        static void Main(string[] args)
        {

            AlmacenarEmpleados<Secretaria> emp = new AlmacenarEmpleados<Secretaria>(3);
            emp.Agregar(new Secretaria(4500));
            emp.Agregar(new Secretaria(2500)); 
            emp.Agregar(new Secretaria(3000));

            //AlmacenarEmpleados <Estudiante> = new AlmacenarEmpleados<Estudiante>(1);

            Console.ReadKey();
        }
    }

     class AlmacenarEmpleados<T> where T:IParaEmpleados
    {
        private int i = 0;
        private T[] datosEmpleados;

        public AlmacenarEmpleados(int z)
        {
            datosEmpleados = new T[z];
        }

        public void Agregar(T obj)
        {
            datosEmpleados[i] = obj;

            i++;
        }

        public T GetEmpleado(int i)
        {
            return datosEmpleados[i];
        }
    }
    
}
