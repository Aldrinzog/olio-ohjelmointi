using System;
using System.Collections.Generic;
using System.Text;

namespace Korttipakka
{
    class Kortti
    {
        private string Nimi;

        public Kortti(string _nimi)
        {
            Nimi = _nimi;
        }

        public string Tiedot()
        {
            return Nimi;
        }
    }
}
