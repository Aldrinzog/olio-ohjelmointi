using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus_10
{
    class Sorsa : Eläin, ICanSwim, ICanFly
    {
        public int SwimSpeed { get; set; }
        public float wingSize { get; set; }

        public Sorsa(string _Name, float _WingSize, int _speed)
        {
            Name = _Name;
            wingSize = _WingSize;
            swimspeed = _speed;
        }

        public void Fly()
        {
            Console.WriteLine("{0} Lentää. Siipinen koko on {1}", Nimi, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("quack");
        }

        public void Swim()
        {
            Console.writeline("Kala {0} ui nopeudella {1}", Name SwimSpeed);
        }
    }
}
