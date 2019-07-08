using System;
using System.Collections.Generic;
using System.Text;

namespace BookGenres
{
    public abstract class Western : BaseBook
    {
        public override string GetGenre()
        {
            return "Western";
        }
    }
}
