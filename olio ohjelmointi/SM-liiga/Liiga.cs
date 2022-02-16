using System;
using System.Collections.Generic;
using System.Text;

namespace SM_liiga
{
    class Liiga
    {
        string Etunimi;
        string Sukunimi;
        int pelinumero;

        static Dictionary<int, Pelaaja> SMLiiga = new Dictionary<int, Pelaaja>();
        public static void Lisää()
        {
            bool Tarkista = false;
            Console.WriteLine();
            Console.WriteLine("Syötä pelaajan etunimi");
            string Etunimi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Syötä pelaajan sukunimi");
            string Sukunimi = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Syötä pelaajan pelinumero");
            int Pelinumero = int.Parse(Console.ReadLine());
            while (!Tarkista)
            {
                Tarkista = Tarkistus(Pelinumero);
            }
            if (Tarkista)
            {
                SMLiiga.Add(Pelinumero, new Pelaaja(Etunimi, Sukunimi, Pelinumero));
                Console.WriteLine(SMLiiga[Pelinumero].TulostaTiedot() + " Lisätty Sm-Liigaan ");
            }
        }

        public static bool Tarkistus(int e)
        {
            foreach (int value in SMLiiga.Keys)
            {
                if (e == value)
                {
                    Console.WriteLine(" Tämä pelaajan numero löytyi SM-liigasta");

                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        public static void Poista()
        {
            foreach (int value in SMLiiga.Keys)
            {
                Console.WriteLine();
                Console.WriteLine(SMLiiga[value].TulostaTiedot());
            }
            int e = int.Parse(Console.ReadLine());
            foreach (int value in SMLiiga.Keys)
            {
                if (e == value)
                {
                    Console.WriteLine(SMLiiga[e].TulostaTiedot() + " Poistettu Sm-Liigasta ");
                    SMLiiga.Remove(e);
                }
                else
                {
                    Console.WriteLine(" Tätä pelaaja ei löydetty SM-liigasta");
                    return;
                }

            }

        }
            public static void Näytä()
            {
                foreach (int value in SMLiiga.Keys)
                {
                    Console.WriteLine();
                    Console.WriteLine(SMLiiga[value].TulostaTiedot());
                }
            }
    }
}