using System;

namespace AppHerencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //  var babieca = new Caballo("Lima");
            //  var humano = new Humano("Carla");
            //  var copito = new Gorila("Juan");

            //  //IMamiferosTerrestres mamiferosTerrestresBAbieca = babieca;
            //ISaltoConPatas mamiferosTerrestresBAbieca = babieca;

            //  //principio de sustitución
            //  Mamiferos[] almacenasnimales = new Mamiferos[3];
            //  almacenasnimales[0] = babieca;
            //  almacenasnimales[1] = humano;
            //  almacenasnimales[2] = copito;

            //  almacenasnimales[0].GetNombre();


            //  for (int i = 0; i < almacenasnimales.Length; i++)
            //  {
            //      almacenasnimales[i].Pensar();
            //  }

            //  Console.WriteLine("--------------------------------------");
            //  Ballena myWally = new Ballena("camila");
            //  myWally.Nadar();
            //  Console.WriteLine("--------------------------------------");

            //  Console.WriteLine($"Número de patas de Babiecas: {mamiferosTerrestresBAbieca.NumerosDePatas()}");

            var juancho = new Lagartija("Juancho lagarto");
            juancho.Respirar();
            juancho.GetNombre();

            Console.WriteLine("-------------------------------------------------------------");

            var humano = new Humano("Emilio Barera");
            humano.Respirar();
            humano.GetNombre();

            Console.ReadKey();
        }
    }
}
