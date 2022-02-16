using System;
using System.Collections.Generic;
using System.Text;

namespace OpiskelijaKokoelma
{
    class Opiskelija
    {
        public string Nimi;
        public string Sukunimi;
        public string Ryhmätunnus;
        public int Opiskelianumero;

        public void TulostaTiedot()
        {
            Console.WriteLine("Opiskelia: {0} {1}. Ryhmätunnus: {2}. Opiskelianumero: {3}", Nimi, Sukunimi, Ryhmätunnus, Opiskelianumero);
            = Console.ReadLine();
           
        }
    } 
}

