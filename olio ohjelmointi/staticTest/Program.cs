using System;

namespace staticTest
{
    class Program
    {
        static void Main(string[] args)
        {
            float Kilometri = 60f;


           float mailit = StaattinenLuokka.KmToMiles(Kilometri);

            Console.WriteLine("{0}km/h on yhtäkuin {1} mailia", Kilometri, mailit);
        }
    }
}
