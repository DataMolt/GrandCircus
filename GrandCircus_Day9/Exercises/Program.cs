using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 47
            Console.WriteLine("Exercise 47");
            var userInputLog = new List<string>();
            string yesOrNo = null;
            do
            {
                Console.WriteLine("Please enter a word or something lol: ");
                userInputLog.Add(Console.ReadLine());
                Console.WriteLine(string.Join(' ', userInputLog));

                Console.WriteLine("Would you like to try again? (y/n) ");
                yesOrNo = Console.ReadLine();
            } while (!yesOrNo.Equals("n", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Goo-buy");
            Console.WriteLine("\n");

            // Exercise 48
            Console.WriteLine("Exercise 48");
            var userInputList = new List<int>();
            string userInput2;
            int userInput3;

            while (true)
            {
                Console.WriteLine("Please enter an int or Q to quit: ");
                userInput2 = Console.ReadLine();

                if ((int.TryParse(userInput2, out userInput3)))
                {
                    userInput3 = int.Parse(userInput2);
                    userInputList.Add(userInput3);
                }
                else if (userInput2.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Value must be a valid integer");
                    Console.WriteLine("Please re-enter value: ");
                    userInput2 = Console.ReadLine();
                }
            }

            int userInputSummed = 0;
            foreach (var number in userInputList)
            {
                userInputSummed += number;
            }

            Console.WriteLine($"The sum of your entered values is: {userInputSummed}");

            Console.ReadLine();
        }
    }
}
