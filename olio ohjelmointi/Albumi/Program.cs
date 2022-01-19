using System;

namespace Albumi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Albumi DingonParhaatHitit = new Albumi();
            kappale Dingo1 = new kappale("Autiotalo", "3:50");
            DingonParhaatHitit.Nimi = "DingonParhaat";
            DingonParhaatHitit.Nimi = "DingonParhaat";
            DingonParhaatHitit.Artisti = "Dingo";
            DingonParhaatHitit.Genre = "Pop";
            DingonParhaatHitit.Hinta = "100 £";

            DingonParhaatHitit.Kappaleet.Add(Dingo1);
            DingonParhaatHitit.TulostaAlbuminTiedot();
            foreach (kappale kappale  in DingonParhaatHitit.Kappaleet)
            {
                Console.WriteLine(kappale.ToString());
            }
            DingonParhaatHitit.LisääKappale();
            DingonParhaatHitit.TulostaKappaleet();
        }
    }
}