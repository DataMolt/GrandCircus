using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day14
{
    abstract class Engine
    {
        public int HorsePower { get; set; }

        public abstract void Drive();
    }
}
