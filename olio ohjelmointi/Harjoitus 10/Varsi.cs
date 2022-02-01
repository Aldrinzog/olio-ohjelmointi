using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Varsi : Eläin, ICanFly
    {
        public float SwimSpeed { get; set; }

        public Varsi(string _Name, float _WingSize)
        {
            Name = _Name;
            wingSize = _WingSize;
        }

        public void FLy()
        {
            Console.WriteLine("{0} Lentää. Siipinen koko on {1}", Name, wingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Kakaaw Kakaaw");
        }


    }
}
