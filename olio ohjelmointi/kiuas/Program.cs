using System;

namespace kiuas
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("harvia", 80, 50);

            harvia.HaeTiedot();
            harvia.Tila = true;
            harvia.HaeTiedot();

            harvia.Lampotila = 90;
            harvia.Kosteus = 60;

            harvia.HaeTiedot();
            harvia.Tila = false;
            harvia.HaeTiedot();
        }
    }
}
