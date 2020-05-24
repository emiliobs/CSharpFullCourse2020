using System;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {

            var archivos = new Alamcenarobjetos<object>(2);

            //archivos.Aggregar("Emilio");
            //archivos.Aggregar("Pablo");
            //archivos.Aggregar(55555);
            //archivos.Aggregar("Lina");
            //archivos.Aggregar(1975);

           archivos.Aggregar(new DateTime().DayOfYear);
            //archivos.Aggregar(new Empleado(2500));

            var queEs = archivos.GetElemento(0);

            Console.WriteLine(queEs);

          //  Console.WriteLine(queEs.Getsalario());



            Console.ReadKey();
        }
    }

    class Alamcenarobjetos <T>
    {
        public Alamcenarobjetos(int z)
        {
            datosElementos = new T[z];
        }

        public void Aggregar( T obj)
        {
            datosElementos[i] = obj;
            i++;
        }

        public  T GetElemento(int i)
        {
            return datosElementos[i];
        }

        private T[] datosElementos;
        private int i = 0;
    }

    public class Empleado
    {
        private readonly double salario;

        public Empleado(double salario)
        {
            this.salario = salario;
        }

        public double  Getsalario()
        {
            return this.salario;
        }
    }
}
