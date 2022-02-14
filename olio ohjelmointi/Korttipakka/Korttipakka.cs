using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Korttipakka
{
    class Korttipakka
    {
        public static  Dictionary<string, Kortti> Pakka = new Dictionary<string, Kortti>();
        public static int Hertta = 1;
        public static int Pata = 1;
        public static int Risti = 1;
        public static int Ruutu  = 1;
        public void Lisää()
        {
            for (int i = 1; i < 52; i++)
            {
                while (Hertta < 14)
                {
                    Pakka.Add("Hertta " + Hertta, new Kortti("Hertta"));
                    Hertta++;
                }
                while (Pata < 14)
                {
                    Pakka.Add("Pata " + Pata, new Kortti("Pata"));
                    Pata++;
                }
                while (Risti < 14)
                {
                    Pakka.Add("Risti " + Risti, new Kortti("Risti"));
                    Risti++;
                } 
                while (Ruutu < 14)
                {
                    Pakka.Add("Ruutu " + Ruutu, new Kortti("Ruutu"));
                    Ruutu++;
                }
                
            }
            Console.WriteLine("Kortit lisätty");
        }
        public void Sekoita() //Korttien sekoitus Metodi luokan sisältä 
        {
            var rnd = new Random(); //luodaan uusi random muuttuja 
            var randomized = Pakka.OrderBy(value => rnd.Next());
            var i = 1;
            Console.WriteLine();
            foreach (var value  in randomized)
            {
                Console.WriteLine("{0}). Kortti on: " + value.Key, i);
                i++;
            }
        }
       
    }
}
