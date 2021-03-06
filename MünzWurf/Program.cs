using System;

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
                    zahl = ZählerX(zahl);
                }
                else
                {
                    kopf = ZählerO(kopf);
                }
            }
            AusgabKonsole(kopf, zahl);
            Console.ReadKey();

        }

        private static void AusgabKonsole(int kopf, int zahl)
        {
            Console.WriteLine(" Du hast " + kopf + " Kopf geworfen und " + zahl + " Zahl geworfen.");
        }

        private static int ZählerO(int kopf)
        {
            kopf++;
            Console.Write("O ");
            return kopf;
        }

        private static int ZählerX(int zahl)
        {
            zahl++;
            Console.Write("X ");
            return zahl;
        }
    }
}
