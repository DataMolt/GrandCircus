using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    class Triangle : Shape
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }


        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double AverageArea()
        {
            double s = AveragePerimiter() / 2;
            return Math.Sqrt((s * ((s - Side1) * (s - Side2) * (s - Side3))));
        }

        public override double AveragePerimiter()
        {
            return (Side1 + Side2 + Side3);
        }
    }
}
