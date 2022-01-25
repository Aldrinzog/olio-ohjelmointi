using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus1
{
    class ajoneuvo
    {
        private int minikerros;
        private int maxkerros;


        private int nykyinenkerros;

        public int nykyinenKerros
        {
            get => nykyinenkerros;
            set
            {

                if (value > maxkerros || value < minikerros)
                {
                    Console.WriteLine("virheellinen kerros");
                }
                else
                {
                    nykyinenkerros = value;
                }


            }
        }

    }

}

