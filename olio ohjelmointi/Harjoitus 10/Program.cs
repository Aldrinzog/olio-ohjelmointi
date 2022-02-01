using System;

namespace Harjoitus_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Varsi varis = new Varsi("Varis", 90);

            varis.MakeASound();
            varis.Fly();

            Kala Ahven = new Kala("Ahven", 50, "Blurp");

            Ahven.MakeASound();
            Ahven.Swim();

            Sorsa sorsa = new Sorsa("Sorsa", 90, 10);

            sorsa.MakeASound();
            sorsa.Fly();
            sorsa.MakeASound();
            sorsa.Swim();
        }
    }
}
