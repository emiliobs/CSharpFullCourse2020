using System;

namespace AvisosVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico avisosTrafico = new AvisosTrafico();
            avisosTrafico.MostrrarAvisos();

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            AvisosTrafico avisosTrafico1 = new AvisosTrafico("Jefatura Madrid", "Sanción de velocidad: 300€", "05/05/1955");
            Console.WriteLine(avisosTrafico1.GetFecha());
            avisosTrafico1.MostrrarAvisos();
        }
    }
}
