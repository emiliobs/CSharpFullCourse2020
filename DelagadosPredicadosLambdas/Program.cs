using System;
using System.Collections.Generic;

namespace DelagadosPredicadosLambdas
{
    class Program
    {
        static void Main(string[] args)
        {


            var people = new List<Personas>() 
            {
               new Personas{ Nombre = "Lina" , Edad = 55},
               new Personas{ Nombre = "Camilo" , Edad = 45},
               new Personas{ Nombre = "Lina" , Edad = 12},
               new Personas{ Nombre = "Sandra " , Edad = 45},
               new Personas{ Nombre = "Blanca" , Edad = 12},
            };


            var gentes = new List<Personas>(people);
            Predicate<Personas> PersonasPredicate = new Predicate<Personas>(ExisteEmilio);

            var existe = gentes.Exists(PersonasPredicate);

            if (existe)
            {
                Console.WriteLine("Hay personas que se llaman Emilio");
            }
            else
            {
                Console.WriteLine("NO existen personas que se llaman Emilio");
            }
            
          

            Console.ReadKey();
        }

        static bool ExisteEmilio(Personas personas)
        {
            if (personas.Nombre == "Emilio")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool NumeroPrimos(int num)
        {
            int a = 0;

            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }

            if (a != 2)
            {
                return false;
                //Console.WriteLine($"Este número no es primo: {a}");
            }
            else
            {
                return true;
                //Console.WriteLine($"Este número es primo");
            }

            
        }

        static bool DamePares(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //definicion del objeto delegabdo...

        delegate void ObjetoDelegado(string msj);



    }


    class MensajeBienvenida
    {
        public static void SaludosBienvenida(string msj)
        {
            Console.WriteLine($"Mensaje de bienvenida: {msj}");
        }
    }

    class Mensajedespedida
    {
       public static void SaludoDespedida(string msj)
        {
            Console.WriteLine($"Mensaje de despedida: {msj}");
        }
    }

}
