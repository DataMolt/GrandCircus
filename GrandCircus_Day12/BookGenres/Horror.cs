using System;
using System.Collections.Generic;
using System.Text;

namespace BookGenres
{
    public abstract class Horror : BaseBook
    {
        public override string GetGenre()
        {
            return "Horror";
        }
    }
}
