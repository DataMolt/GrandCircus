using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise52
{
    class Square : Shape
    {
        public double LengthOfSide { get; set; }

        public Square(double lengthOfSide)
        {
            LengthOfSide = lengthOfSide;
        }

        public override double AverageArea()
        {
            return Math.Pow(LengthOfSide, 2);
        }

        public override double AveragePerimiter()
        {
            return LengthOfSide * 4;
        }

    }
}
