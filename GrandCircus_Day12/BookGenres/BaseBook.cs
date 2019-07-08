using System;
using System.Collections.Generic;
using System.Text;

namespace BookGenres
{
    public abstract class BaseBook
    {
        public string Title { get; set; }

        public virtual string GetGenre()
        {
            return "book";
        }

        public virtual bool IsBook()
        {
            return true;
        }
    }
}
