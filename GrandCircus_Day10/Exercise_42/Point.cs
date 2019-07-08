using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_42
{
    class Point
    {
        public Point(int a, int b)
        {
            _a = a;
            _b = b;
        }

        private int _a;
        private int _b;
        private int _x;
        private int _y;

        public int A
        {
            get
            {
                return _a;
            }
            set
            {
            }
        }

        public int B
        {
            get
            {
                return _b;
            }
            set
            {
            }
        }

        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }
    }
}
