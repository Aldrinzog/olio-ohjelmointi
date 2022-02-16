using System;

namespace SM_liiga
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("Lisää - Kirjota lisää jos haluat lisätä uuden pelaajan ");
                Console.WriteLine("Poista - Kirjota poista jos haluat poista pelaajan ");
                Console.WriteLine("Tulosta - Kirjota tulosta jos haluat tulosaa pelaajan tiedot ");
                Console.WriteLine("Poistu - kirjota poistu jos haluat poistua ohjelmasta ");
                string syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "Lisää":
                        //Kun käyttäjä kirjottaa syötteeksi lisää tämä kohta tehtään 
                        Liiga.Lisää();
                        break;

                    case "Poista":
                        //Kun käyttäjä kirjottaa syötteeksi poista tämä kohta tehdään 
                        Liiga.Poista();
                        break;

                    case "Tulosta":
                        //Kun käyttäjä kirjottaa syötteeksi tulosta tämä kohta tehdään
                        Liiga.Näytä();
                        break;

                    case "Poistu":
                        //Kun käyttäjä kirjottaa syötteeksi poistu tämä kohta tehdään 
                        return;


                    default:
                        Console.WriteLine("Tuntematon syöte yritä uudestaan ");
                        break;


                }

            }
            Liiga.Lisää();
            Liiga.Poista();
            Liiga.Näytä();
        }
    }
}
