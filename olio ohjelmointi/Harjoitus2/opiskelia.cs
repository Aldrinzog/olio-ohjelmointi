using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class opiskelia { 


        private string Nimi { get; set; }
    private string opiskeliaID { get; set; }

    private string sähköposti { get; set; }
    private int Opintopisteet { get; set; }


    // konstruktori opiskelija luokalle 
    public void opiskelija(string _Nimi, string _id, int _opintopisteet)
    {
        this.Nimi = _Nimi;
        this.opiskeliaID = _id;
        this.Opintopisteet = _opintopisteet;

    }

    public void tulostaData()
    {
        Console.WriteLine("");
        Console.WriteLine("ajoneuvo: ");
        Console.WriteLine("-- Nimi: " + Nimi);
        Console.WriteLine("-- opiskelijaID: " + opiskeliaID);
        Console.WriteLine("-- opintopisteet: " + Opintopisteet);
        Console.WriteLine("");

    }
    // metodi, joka ottaa parametriksi integer - arvon.
    public void MuokkaaOpintopisteitä(int i)
    {
        Opintopisteet += i;

        if (Opintopisteet < 0)
        {
            Opintopisteet = 0;
        }
    }
