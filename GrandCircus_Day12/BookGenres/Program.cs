using System;
using System.Collections.Generic;

namespace BookGenres
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookList = new List<BaseBook>();
            var snowCrash = new CyberPunkBook("Snow Crash");
            var americanPsycho = new HorrorBook("American Psycho");
            var bloodMeridian = new WesternBook("Blood Meridian");
            var neverLetMeGo = new DramaBook("Never Let Me Go");
            var neuromancer = new CyberPunkBook("Neuromancer");

            bookList.Add(snowCrash);
            bookList.Add(americanPsycho);
            bookList.Add(bloodMeridian);
            bookList.Add(neverLetMeGo);
            bookList.Add(neuromancer);

            foreach (var book in bookList)
            {
                Console.WriteLine($"The name of the book is {book.Title} and the genre is {book.GetGenre()} and its {book.IsBook()} that it is a book.");
            }

            Console.WriteLine(snowCrash.GetType().Name);

            Console.ReadLine();
        }
    }
}
