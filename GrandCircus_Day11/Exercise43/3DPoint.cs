using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise43
{
    class _3DPoint : Point
    {
        public int Z { get; set; }

        public _3DPoint(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
    }
}
