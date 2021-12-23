using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MünzWurf
{
    class Program
    {
        static void Main(string[] args)
        {
            // Münzwurf simuliert
            // User entscheidet wie viel Münzen geworfen werde
            // User soll Ausgabe erhalten wie oft Kopf und wie oft Zahl 

            Console.WriteLine("Wieviel Münzen möchtest du werfen??");
            int eingabe = 0;
            eingabe = int.Parse(Console.ReadLine());
            
            int kopf = 0;
            int zahl = 0;
            
            Random rnd = new Random();

            for (int i = 0; i < eingabe; i++)
            {
                int zufall = rnd.Next(0, 2);
                if (zufall == 1)
                {
                    zahl++;
                    Console.Write("X ");
                }
                else 
                {
                    kopf++;
                    Console.Write("O ");
                }
            }
            Console.WriteLine(" Du hast " + kopf + " Kopf geworfen und " + zahl + " Zahl geworfen.");

            Console.ReadKey();

        }
    }
}
