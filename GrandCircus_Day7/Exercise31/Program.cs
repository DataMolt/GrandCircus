using System;
using System.Linq;

namespace Exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 31
            Console.WriteLine("Exercise 31");
            string yesOrNo = null;
            do
            {
                int[] newArray = new int[5] { 2, 8, 0, 24, 51 };
                Console.WriteLine("Please enter an int: ");
                string userInput = Console.ReadLine();
                int userInput1;

                while (true)
                {
                    if ((int.TryParse(userInput, out userInput1)) && (userInput1 >= 0) && (userInput1 < newArray.Length))
                    {
                        userInput1 = int.Parse(userInput);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Value must be a valid integer 0 through 4");
                        Console.WriteLine("Please re-enter value: ");
                        userInput = Console.ReadLine();
                    }
                }
               
                Console.WriteLine(newArray[userInput1]);
                Console.WriteLine("Would you like to try again? (y/n) ");
                yesOrNo = Console.ReadLine();
            } while (!yesOrNo.Equals("n", StringComparison.OrdinalIgnoreCase));

            // Exercise 32
            Console.WriteLine("Exercise 32");
            
            do
            {
                int[] newArray = new int[5] { 2, 8, 0, 24, 51 };
                Console.WriteLine("Please enter an int: ");
                string userInput2 = Console.ReadLine();
                int userInput3;

                while (true)
                {
                    if ((int.TryParse(userInput2, out userInput3)))
                    {
                        userInput3 = int.Parse(userInput2);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Value must be a valid integer");
                        Console.WriteLine("Please re-enter value: ");
                        userInput2 = Console.ReadLine();
                    }
                }

                // Loop Method
                /*
                bool findValue = false;
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (newArray[i] == userInput3)
                    {
                        Console.WriteLine($"The index of your value is {i}");
                        findValue = true;
                        break;
                    }
                }

                if (!findValue)
                {
                    Console.WriteLine("Could not find value");
                }
                */
                if (newArray.Contains(userInput3))
                {
                    Console.WriteLine($"Your value is located at index {Array.IndexOf(newArray, userInput3)}");
                }
                else
                {
                    Console.WriteLine("Cannot find value");
                }

                Console.WriteLine("Would you like to try again? (y/n) ");
                yesOrNo = Console.ReadLine();
            } while (!yesOrNo.Equals("n", StringComparison.OrdinalIgnoreCase));
        }

    }
}
