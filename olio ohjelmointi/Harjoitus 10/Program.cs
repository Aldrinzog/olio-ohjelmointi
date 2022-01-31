using System;

namespace Harjoitus_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Varis varis = new Varis("Varis", 90);

            Varsi.MakeASound();
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
