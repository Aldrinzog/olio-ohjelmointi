using System;
using System.Collections.Generic;

namespace OpiskelijaKokoelma
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Opiskelija> opiskelijat = new Dictionary<int, Opiskelija>();

            while (true)
            {
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("Lisää - Kirjota lisää jos haluat lisätä uuden Opiskelijan ");
                Console.WriteLine("Poista - Kirjota poista jos haluat poista opiskelijan ");
                Console.WriteLine("Tulosta - Kirjota tulosta jos haluat tulosaa opiskelijan tiedot ");
                Console.WriteLine("Poistu - kirjota poistu jos haluat poistua ohjelmasta ");
                string syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "Lisää":
                        //Kun käyttäjä kirjottaa syötteeksi lisää tämä kohta tehtään 
                        LisääOpiskelija(opiskelijat);
                        break;

                    case "Poista":
                        //Kun käyttäjä kirjottaa syötteeksi poista tämä kohta tehdään 
                        PoistaOpiskelija(opiskelijat);
                        break;

                    case "Tulosta":
                        //Kun käyttäjä kirjottaa syötteeksi tulosta tämä kohta tehdään
                        TulostaOpiskelija(opiskelijat);
                        break;

                    case "Poistu":
                        //Kun käyttäjä kirjottaa syötteeksi poistu tämä kohta tehdään 
                        return;


                    default:
                        Console.WriteLine("Tuntematon syöte yritä uudestaan ");
                        break;


                }

            }






        }
        static void PoistaOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Console.WriteLine("Anna opiskelijan id jonka haluat poista sovelluksesta");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (opiskelijat.ContainsKey(syöte))
            {
                Console.WriteLine("Opiskelia " + opiskelijat[syöte].Nimi + " Poistettu");
            }
            else
            {
                Console.WriteLine("Opiskelija id:llä " + syöte + " Ei löydy kokoelmasta ");
            }
            opiskelijat.Remove(syöte);
        }
        static void LisääOpiskelija(Dictionary<int, Opiskelija> opiskelijat)
        {
            Opiskelija uusiOpiskelija = new Opiskelija();

            while (true)
            {


                Console.WriteLine("Opiskelijan tiedot ");
                Console.WriteLine("Anna etunimi");
                uusiOpiskelija.Nimi = Console.ReadLine();
                Console.WriteLine("Anna sukunimi");
                uusiOpiskelija.Sukunimi = Console.ReadLine();
                Console.WriteLine("Anna ryhmätunnus");
                uusiOpiskelija.Ryhmätunnus = Console.ReadLine();
                Console.WriteLine("Anna opiskelianumero ");
                uusiOpiskelija.Opiskelianumero = Convert.ToInt32(Console.ReadLine());

                if (opiskelijat.ContainsKey(uusiOpiskelija.Opiskelianumero))
                {
                    Console.WriteLine("Opiskelija listasta löytyi id");
                    continue;

                }
                else
                {
                    opiskelijat.Add(uusiOpiskelija.Opiskelianumero, uusiOpiskelija);
                    break;
                }

            }


        }


    }
}
