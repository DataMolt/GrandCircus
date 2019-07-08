using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double AverageArea()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        public override double AveragePerimiter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
