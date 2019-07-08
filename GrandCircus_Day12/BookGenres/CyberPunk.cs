using System;
using System.Collections.Generic;
using System.Text;

namespace BookGenres
{
    public abstract class CyberPunk : BaseBook
    {
        public override string GetGenre()
        {
            return "CyberPunk";
        }
    }
}
