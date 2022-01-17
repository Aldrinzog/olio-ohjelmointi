using System;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            // luodaan opiskelia olio
            opiselija opiskejia1 = new piselija("Matti", "TVT1234", 0);

            opiskejia1.TulostaData();
            opiskejia1.MuokkaaOpintopi();
        }
    }
}
