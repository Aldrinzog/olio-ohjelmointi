using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus1
{
    class ajoneuvo
    {
        public string Nimi { get; set; }
        public int nopeus { get; set; }
        public int renkaat { get; set; }



        public void TulostaData()
        {
            Console.WriteLine("ajoneuvo: ");
            Console.WriteLine("-- Nimi: " + Nimi);
            Console.WriteLine("-- nopeus: " + nopeus);
            Console.WriteLine("-- renkaat: " + renkaat);
        }

        public string Tostring()
        {
            string merkkijono = "Ajoneuvo Nimi: " + Nimi + ". nopeus: " + nopeus + "km/h.renkaat " + renkaat + "kpl";

            return merkkijono;
        }
    }
}