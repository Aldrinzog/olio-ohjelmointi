using System;

namespace AbstractTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Opiskelija opiskelija = new Opiskelija();

            Henkilö henkilöOpiskelija = new Opiskelija();


            Console.WriteLine(opiskelija.GetType());
            Console.WriteLine(henkilöOpiskelija.GetType());
        }
    }
}
