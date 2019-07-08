using System;

namespace Day3_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 14
            Console.WriteLine("Exercise 14");
            Console.WriteLine("Enter a number dude");
            int userInput1 = int.Parse(Console.ReadLine());
            for (int i = 1; i < userInput1; i++)
            {
                int squared = i * i;
                Console.WriteLine(squared);
            }
            Console.WriteLine("\n");

            //Exercise 16
            Console.WriteLine("Exercise 16");
            //Adding to string
            string star = "*";
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(star);
                star += "*";
            }
            //Using new string
            for (int starCount = 1; starCount < 11; starCount++)
            {
                var newStar = new string('*', starCount);
                Console.WriteLine(newStar);
            }

            //Exercise 17
            Console.WriteLine("Exercise 17");
            int starLength = 10;
            for (int i = 1; i < starLength; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    var newSpace = new string(' ', (starLength - j) / 2);
                    var newStar = new string('*', j);
                    Console.WriteLine(newSpace + newStar);
                }
            }



            Console.ReadLine();
        }
    }
}
