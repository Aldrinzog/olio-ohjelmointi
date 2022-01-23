using System;
using System.Collections.Generic;
using System.Text;

namespace staticTest
{
    //Staattinen luokka "static" avainsanalla 
     static class StaattinenLuokka
     {
        public void float KmToMiles(float i)
        {
            float conversion = 0.62137f;


            return i * conversion;
        }
     }
}
