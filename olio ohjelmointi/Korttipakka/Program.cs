using System;

namespace Korttipakka
{
    class Program
    {
        static void Main(string[] args)
        {
            Korttipakka Pakka = new Korttipakka();

            Pakka.Lisää();
            Pakka.Sekoita();
            Pakka.Sekoita();
        }
    }
}
