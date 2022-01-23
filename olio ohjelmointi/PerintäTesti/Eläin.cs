using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{

    //Eläin yliluokka
    class Eläin 
    {
        public string Nimi { get; set;  }



        private static int instanssit = 0;

        public Eläin()
        {
            instanssit++;
        }

        public static void KuinkaMonta;

        public Eläin()
        {
            instanssit++;
        }

        public virtual void ääntele()
        {

        }
        
    }
}
