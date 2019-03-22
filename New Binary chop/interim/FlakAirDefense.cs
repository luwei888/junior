using System;
using System.Collections.Generic;
using System.Text;

namespace interim
{
    class FlakAirDefense : AirDefense
    {
        internal override void Shoot()
        {
            Console.WriteLine("高射炮开火");
        }
    }
}
