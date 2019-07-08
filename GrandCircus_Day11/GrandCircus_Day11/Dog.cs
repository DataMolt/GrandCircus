using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day11
{
    public class Dog : Animal
    {
        public Dog(string name, int age)
            : base(name, age)
        {
        }

        public virtual string Bark()
        {
            return "Woawoawoawoa";
        }

        protected string Howl()
        {
            return "Awoooooo";
        }
    }
}
