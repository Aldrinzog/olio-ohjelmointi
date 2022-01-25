using System;

namespace Hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi tiettyhissi = new Hissi(1, 5);
            Hissi koulunHissi = new Hissi(-1, 4);

            string annettuKerros;

            while (true)
            {
                Console.WriteLine("Olet kerroksessa " + tiettyhissi, Nykyinenkerros);
                Console.WriteLine("Mihin kerrokseen");
                annettuKerros = Console.ReadLine();

                if (annettuKerros == "poistu")
                {
                    Console.WriteLine("poistut Hissistä. ");
                    break;
                }
                else
                {
                    tiettyhissi.nykyinenkerros = int.Parse(annettuKerros);
                }
            }
        }
    }
}
