using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9
{
    class Student
    {
        public Student(string name)
        {
            _name = name;
        }

        private string _name;
        private string _age;
        private string _interest;
        private string _food;

        public string GetName()
        {
            return _name;
        }

        public void SetAge(string age)
        {
            _age = age;
        }

        public string GetAge()
        {
            return _age;
        }

        public void SetInterest(string interest)
        {
            _interest = interest;
        }

        public string GetInterest()
        {
            return _interest;
        }

        public void SetFavoriteFood(string food)
        {
            _food = food;
        }

        public string GetFavoriteFood()
        {
            return _food;
        }
    }
}
