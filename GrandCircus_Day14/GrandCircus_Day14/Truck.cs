using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day14
{
    class Truck : IVehicle
    {
        public void EngageFourWheel()
        {
            // Do something
        }

        public string Honk()
        {
            return "HOOOONK";
        }

        public void Brake()
        {
            Console.WriteLine("SCREEECH");
        }
    }
}
