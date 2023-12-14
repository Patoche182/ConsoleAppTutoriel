using System;
using System.Threading;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début du programme");

            for (int i = 0; i < 3; i++)
            {
                Thread monThread = new Thread(new ThreadStart(FonctionComplexe));
                monThread.Start();
            }
            Console.WriteLine("Fin du programme");
        }

        static void FonctionComplexe()
        {
            Console.WriteLine("Dans le Thread : " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000); // Pause 2 secondes
            Console.WriteLine("Travail effectué !");
        }
    }
}