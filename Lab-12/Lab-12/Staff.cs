using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12
{
    class Staff : Person
    {
        private string School { get; set; }
        private double Pay { get; set; }

        public Staff(string name, string address, string school, double pay)
            : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        public override void ToString()
        {
            base.ToString();
            Console.WriteLine($"School is: {School}\nPay is {Pay}");
        }
    }
}
