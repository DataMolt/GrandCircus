using System;
using System.Collections.Generic;
using System.Text;

namespace BookGenres
{
    public abstract class Drama : BaseBook
    {
        public override string GetGenre()
        {
            return "Drama";
        }
    }
}
