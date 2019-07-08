using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day11
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

       
        // Function overloading
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
