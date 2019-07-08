using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class Student : Person 
    {
        private string Program { get; set; }
        private int Year { get; set; }
        private double Fee { get; set; }

        public Student(string name, string address, string program, int year, double fee) 
            : base (name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"Program is: {Program}\nYear is: {Year}\nFee is: {Fee}");
        }

    }
}
