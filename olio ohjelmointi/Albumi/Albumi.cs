using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi
{
    class Albumi
    {
        public string Artisti;
        public string Nimi;
        public string Genre;
        public string Hinta;
        public List<kappale> Kappaleet = new List<kappale>();

        kappale Tanssi1 = new kappale("JetkanPolkka", "2:50");
        kappale Tanssi2 = new kappale("JetkanPolkka", "2:50");
        kappale Tanssi3 = new kappale("JetkanPolkka", "2:50");
        kappale Tanssi4 = new kappale("JetkanPolkka", "2:50");
        kappale Tanssi5 = new kappale("JetkanPolkka", "2:50");
        
        public void LisääKappale()
        {
            Kappaleet.Add(Tanssi1);
        }

        public void TulostaKappaleet()
        {
            foreach (kappale kappale in Kappaleet)
            {
                Console.WriteLine(kappa.ToString());
            }
        }
        public void TulostaAlbuminTiedot()
        {
            Console.WriteLine("");
            Console.WriteLine("Albumi: ");
            Console.WriteLine("-- Artisti: " + Artisti);
            Console.WriteLine("-- Nimi" + Nimi);
            Console.WriteLine("-- Genre" + Genre);
            Console.WriteLine("-- Hinta " + Hinta);
            Console.WriteLine("");
            Console.WriteLine("Songs");
        }

    }
}
