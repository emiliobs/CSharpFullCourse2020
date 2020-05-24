using System;
using System.Text.RegularExpressions;

namespace AppRegex
{
    class Program
    {
        static void Main(string[] args)
        {

            var frase = "mi Web es https://wwww.youtube.com:";
            var patron = "https://(wwww).?youtube.com";

            Regex miRegex = new Regex(patron);

            MatchCollection elMatch = miRegex.Matches(frase);

            if (elMatch.Count > 0)
            {
                Console.WriteLine("Se ha encontrado web");
            }
            else
            {
                Console.WriteLine("No se ha encontado web");
            }
            
        }
    }
}
