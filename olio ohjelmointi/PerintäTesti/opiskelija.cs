using System;
using System.Collections.Generic;
using System.Text;

namespace PerintäTesti
{
    class opiskelija : Henkilö
    {
        public string opiskelijaID { get; set; }

        public override void puhu()
        {
            Console.WriteLine( Nimi + "puhui opiskelija luokassa");
        }
    }
}
