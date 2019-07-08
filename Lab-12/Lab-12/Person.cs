using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class Person
    {
        private string Name { get; set; }
        private string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual void ToString()
        {
            Console.WriteLine($"Name is: {Name}\nAddress is: {Address}");
        }
    }
}
