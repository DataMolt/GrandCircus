using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day10
{
    class Person
    {
        public Person(string name)
        {
            _name = name;
        }

        // Properties
        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value.Length > 0)
                {
                    _age = value;
                }
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        // Functions (Methods)
        // -- Constructor
        public void SetInterest(string interest)
        {
            this._interest = interest;
        }

        public string GetName()
        {
            return _interest;
        }

        //Fields
        private string _interest;
        private string _address;
        private string _age;
        private string _name;
    }
}
