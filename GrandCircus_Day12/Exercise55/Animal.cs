using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise55
{
    abstract class Animal
    {
        public bool IsMultiCellular()
        {
            return true;
        }

        public virtual string MeansOfReproduction()
        {
            return "not set";
        }

        public virtual bool HasWings()
        {
            return false;
        }

        public virtual string VertabrateOrInvertabrate()
        {
            return "not set";
        }

        public virtual bool LaysEggs()
        {
            return false;
        }
    }
}
