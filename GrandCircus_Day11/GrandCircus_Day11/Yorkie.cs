using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day11
{
    class Yorkie : Dog
    {
        public Yorkie(string name, int age) : base(name, age)
        {
        }

        // Function override
        public override string Bark()
        {
            return "Yip";
        }
    }
}
