using System;

namespace VahvistinTesti
{
    class Program
    {
        static void Main(string[] args)
        {
            int uusiVoimakkus;

            Console.WriteLine("Luodaan uusi vahvistin..");
            Vahvistin vahvistin = new Vahvistin();
            Console.WriteLine("Uusi vahvistin luotu, poistu kirjottamalla sammuta ");

            while (true)
            {
                Console.WriteLine("Anna uusi äänevoimakkuus vahvistimelle (0-100) > ");
                string luettuArvo = Console.ReadLine();

                if (luettuArvo.Equals("sammuta"))
                {
                    break; //poistutaan loopista
                }

                bool result = int.TryParse(luettuArvo, out uusivoimakkuus);

                if (result) // jos result == true
                {
                    vahvistin.Äänenvoimakkuus = uusiVoimakkus;

                }
                else
                {
                    Console.WriteLine("Error: Annettu arvo on virheellinen! Mikäli et haluat  sammuttaa vahvistimen kirjoita sammuta");
                }
            }
            Console.WriteLine("Vahvistin on sammutettu");
        }
    }
}
