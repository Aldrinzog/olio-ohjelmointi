using System;
using System.Collections.Generic;
using System.Text;

namespace Albumi
{
    class kappale
    {
        public string Nimi;
        public string kesto;

        public kappale(string _nimi, string _kesto)      
        {
            Nimi = _nimi;
            kesto = _kesto;
        }
        public string ToString()
        {
            string KappaleenTiedot = ("----Nimi:  " + Nimi + " - " + kesto);
            return KappaleenTiedot;
        }
    }
}
