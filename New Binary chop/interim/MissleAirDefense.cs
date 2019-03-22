using System;
using System.Collections.Generic;
using System.Text;

namespace interim
{
    class MissleAirDefense : AirDefense
    {
        internal override void Shoot()
        {
            Console.WriteLine("东方一号导弹发射");
        }
    }
}
