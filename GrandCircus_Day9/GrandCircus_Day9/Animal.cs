using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day9
{
    class Animal
    {
        public Animal(string name)
        {
            _name = name;
        }

        private string _name;

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

    }
}
