 using System;

namespace harjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {

            //olio ajoneuvo -luokasta
            ajoneuvo auto = new ajoneuvo();

            //asetetaan oliolle "auton" arvot
            auto.Nimi = "toyota";
            auto.nopeus = 160;
            auto.renkaat = 4;

            //käytetään "auton" olion toimintoja 
            auto.TulostaData();

            //Noudatetaan auton tiedot tostring() metodilla
            string autonTiedot = auto.ToString();
            Console.WriteLine(autonTiedot);

            // tyhjä rivi konsoliin 
            Console.WriteLine();

            //Luodaan toinen olio luokasta ajoneuvo 

            ajoneuvo mopo = new ajoneuvo();
            mopo.Nimi = "skootteri";
            mopo.nopeus = 55;
            mopo.renkaat = 2;

            mopo.TulostaData();
            Console.Write(mopo.ToString());


        }
    }
}