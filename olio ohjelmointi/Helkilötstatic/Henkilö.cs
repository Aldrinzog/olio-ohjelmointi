using System;
using System.Collections.Generic;
using System.Text;

namespace Helkilötstatic
{
    class Henkilö
    {
        private static int instanssit = 0;

        public Henkilö()
        {
            instanssit++;
        }
        
        public static void kuinkaMontaHenkilöä()
        {
            Console.WriteLine("Henkilöitä olemassa: " + instanssit);
        }

        
        public void EiStaattinenMetodi()
        {

        }
    }
}
