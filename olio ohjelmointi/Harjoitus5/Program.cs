using System;

namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 5.0f;
            float b = 2.5f;

            float summa = laskin.summa(a, b);
            float Erotus = laskin.Erotus(a, b);
            float Kertolasku = laskin.kertolasku(a, b);
            float jakolasku = laskin.Jakolasku(a, b);

            Console.WriteLine("Numeroiden {0} ja {1}":, a, b);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Erotus: " + Erotus);
            Console.WriteLine("Kertolasku: " + Kertolasku);
            Console.WriteLine("Jakolasku: " + jakolasku);

                
           
        }
    }
}
