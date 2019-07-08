using System;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {       
            string repeatCheck;
            do
            {
                string checkInput;
                int userInput;
                Console.WriteLine("Dude enter ur name lol: ");
                string userName = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine($"Please enter a value {userName}: ");
                    checkInput = Console.ReadLine();
                    if (int.TryParse(checkInput, out userInput))
                    {
                        userInput = int.Parse(checkInput);
                        if (BetweenOneAndOneHundred(userInput))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Dude, {userName}, that's real funny and all but I'm gonna need an int between 1 and 100");
                        }
                    }
                }

                if (!IsEven(userInput))
                {
                    Console.WriteLine($"{userInput} Odd");
                }

                if (TwoToTwentyFive(userInput) && IsEven(userInput))
                {
                    Console.WriteLine("Even and less than 25");
                }

                if (TwentySixToSixty(userInput) && IsEven(userInput))
                {
                    Console.WriteLine("Even");
                }

                if (GreaterThanSixty(userInput) && IsEven(userInput))
                {
                    Console.WriteLine("Even");
                }

                if (GreaterThanSixty(userInput) && !IsEven(userInput))
                {
                    Console.WriteLine("Odd");
                }

                Console.WriteLine($"Would you like to try again, {userName} (y/n)? ");
                repeatCheck = Console.ReadLine();
            } while (!repeatCheck.Equals("n", StringComparison.OrdinalIgnoreCase));

            Console.ReadLine();
        }

        public static bool IsEven(int number)
        {
            return (number % 2) == 0;
        }

        public static bool TwoToTwentyFive(int number)
        {
            return (number >= 2 && number <= 25);
        }

        public static bool TwentySixToSixty(int number)
        {
            return (number >= 26 && number <= 60);
        }

        public static bool GreaterThanSixty(int number)
        {
            return (number > 60);
        }

        public static bool BetweenOneAndOneHundred(int number)
        {
            return (number >= 1 && number <= 100);
        }
    }
}
