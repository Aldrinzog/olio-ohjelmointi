using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            var Nimi = new List<string>();
            Nimi.Add("Mikael");
            Nimi.Add("Jonne");
            Nimi.Add("Arttu");
            Nimi.Add("vilma");
            Nimi.Add("Kevin");
            Nimi.Add("Niklas");
            Nimi.Add("topias");
            Nimi.Add("Antti");
            Nimi.Add("Pekka");
            Nimi.Add("Matti");
            Nimi.Add("Mikko");
            Nimi.Add("Rajesh");
            //Sisältää: Tämä menetelmä määrittää, onko elementti luettelossa vai ei,
            //Jos elementti on luettelossa, tämä menetelmä palauttaa "True" tai palauttaa "False".
            // Console.WriteLine(Nimi.Contains("Sourabh\n"));

            //pääset käsiksi kaikkiin luettelon elementteihin
            Console.WriteLine("Nimejä on listassa: " + Nimi.Count);         
            foreach (string s in Nimi)
              {
                  Console.WriteLine(s);
              }
            Nimi.Remove("Rajesh");
            Console.WriteLine("Nimejä on listassa: " + Nimi.Count);
            foreach (string s in Nimi)
            {
                Console.WriteLine(s);
            }

            //Insert: Tätä menetelmää käytetään elementin lisäämiseen tiettyyn hakemistoon.
            //Nimi.Insert(5, "Rajesh");

            // Console.WriteLine("\n\n Rajeshin lisäämisen jälkeen 5. hakemistoon");

            //Käänteinen: Kääntää listan elementin järjestystä
            Console.WriteLine("Nimejä käänetään nurin");
            Nimi.Reverse();
            // Console.WriteLine("\n\nKäänteiset luettelon elementit");
            foreach (string s in Nimi)
            {
                Console.WriteLine(s);
            }
            //Poista: Poistaa elementit luettelosta
            //Nimi.Remove("Rajesh");
            //Console.WriteLine("\n\nPoista elementti luettelosta käyttämällä Poista-menetelmää");

            //Tyhjennä: Poistaa kaikki elementit luettelosta
           /* Nimi.Clear();
           Console.WriteLine("\n\nTyhjennä menetelmä");
            Console.WriteLine("Kapasiteetti: {0}, Nimi1.Kapasiteetti");
            Console.WriteLine("Count: {0}", Nimi.Count);
            Console.ReadKey();*/
        }
    }
}

