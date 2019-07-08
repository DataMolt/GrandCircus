using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise43
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double GetDistance()
        {
            int c = (X * X) + (Y * Y);
            return Math.Sqrt(c);
        }
    }
}
