using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day11
{
    class Poodle : Dog
    {
        public Poodle(string name, int age) : base(name, age)
        {
        }

        public bool HasHair()
        {
            return true;
        }
        
        public string makeNoise()
        {
            return Howl();
        }
    }
}
