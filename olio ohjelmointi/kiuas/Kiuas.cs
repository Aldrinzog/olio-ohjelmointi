using System;
using System.Collections.Generic;
using System.Text;

namespace kiuas
{
    class Kiuas
    {
        public string Lampotila;
        public string Merkki;
        public string Kosteus;
        public string Tila;

        public Kiuas(string merkki, int Lampotila, int kosteus)
        {
            Merkki = Merkki;
            Lampotila = Lampotila;
            int = kosteus;
            Tila = false; // Tila alussa on aina false!
        }


        public void HaeTiedot()
        {
            Console.WriteLine("");
            if (Tila == true)
            {
                Console.WriteLine("Kiuas" + Merkki + "on päällä");
                Console.WriteLine("Lampotila" + Lampotila);
                Console.WriteLine("kosteus" + Kosteus);
                Console.WriteLine("tila" + Tila);
            }
            else
            {
                Console.WriteLine("Kiuas " + Merkki + " ei ole päällä");
            }
        }
    }
