using System;
using System.IO;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {

            var miArchikvo = new ManejoDeArchivos();
            miArchikvo.MenejoDeArchivo();
            miArchikvo.Mensaje();

            Console.ReadKey();
        }
    }

    class ManejoDeArchivos
    {
        StreamReader archivo = null;

        int contador = 0;

        string linea;

        public void MenejoDeArchivo()
        {
            archivo = new StreamReader(@"c:\texto.txt");
            while ((linea = archivo.ReadLine()) != null)
            {
                Console.WriteLine(linea);
                contador++;
            }

           
        } 

        public void Mensaje()
        {
            Console.WriteLine($"Hay {contador} Líneas");
        }

        //Destructor:
        ~ManejoDeArchivos()
        {
            archivo.Close();
        }

    }
}
