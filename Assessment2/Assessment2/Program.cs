using System;

namespace Assessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "This is a test hehe";
            Console.WriteLine(GetCharOccurence(testString, 'i'));

            Console.WriteLine(GetCharOccurence("Mississippi", 's'));

            int[] testArray = CreateIntegerArray();

            foreach (var item in testArray)
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }

        public static int GetCharOccurence(string stringToCheck, char charToFind)
        {
            int totalCharsFound = 0;
            foreach (var character in stringToCheck)
            {
                if (character.Equals(charToFind))
                {
                    totalCharsFound += 1;
                }
            }
            return totalCharsFound;
        }

        public static int[] CreateIntegerArray()
        {
            int[] arrayToFill = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrayToFill[i] = CheckForPositiveOdd();
            }
            return arrayToFill;
        }

        public static int CheckForPositiveOdd()
        {
            string userInput;
            int userInputInt;
            int verifiedUserInput;
            while (true)
            {
                Console.Write("Please enter a postive, odd integer: ");
                userInput = Console.ReadLine();
                if ((int.TryParse(userInput, out userInputInt)) && (userInputInt % 2 != 0) && (userInputInt > 0))
                {
                    verifiedUserInput = int.Parse(userInput);
                    break;
                }
                else
                {
                    Console.WriteLine("Can only accept a postive, odd integer: ");
                }
            }
            return verifiedUserInput;
        }
    }
}
