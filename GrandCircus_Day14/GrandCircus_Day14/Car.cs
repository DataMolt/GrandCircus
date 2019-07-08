using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day14
{
    public class Car : IHonk, IBrake
    {
        public string Honk()
        {
            return "Hoooonk";
        }

        public void Brake()
        {
            Console.WriteLine("SCRREEEECH");
        }
    }
}
