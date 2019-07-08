using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day14
{
    class DieselEngine : Engine
    {
        public override void Drive()
        {
            Console.WriteLine("Before drive");
            Console.WriteLine("After drive");
        }
    }
}
