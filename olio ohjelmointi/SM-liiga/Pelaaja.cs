using System;
using System.Collections.Generic;
using System.Text;

namespace SM_liiga
{
    class Pelaaja
    {
        public string Etunimi;
        public string Sukunimi;
        public int Pelinumero;

        public Pelaaja(string _etunimi, string _sukunimi, int _pelinumero)
        {
            Etunimi = _etunimi;
            Sukunimi = _sukunimi;
            Pelinumero = _pelinumero;
        }

        public string TulostaTiedot()
        {
           return "Pelaaja:  " + Etunimi + " " + Sukunimi + " " + Pelinumero;
    
        }
 
    }
}
