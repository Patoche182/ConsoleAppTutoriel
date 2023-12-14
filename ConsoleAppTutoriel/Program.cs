using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début du programme");
            FonctionComplexe();
            FonctionComplexe();
            FonctionComplexe();
            FonctionComplexe();
            Console.WriteLine("Fin du programme");
        }

        static void FonctionComplexe()
        {
            Thread.Sleep(2000); // Pause 2 secondes
            Console.WriteLine("Travail effectué !");
        }
    }
}