using System;
using System.Text.RegularExpressions;

namespace GrandCircus_Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            //var again = true;
            //while (again)
            //{
            //    Console.Write("Give me a number (x to quit): ");
            //    var response = Console.ReadLine();
            //    //if (response.Equals("x", StringComparison.OrdinalIgnoreCase))
            //    {
            //        again = false;
            //    }
            //    else
            //    {
            //        var number = int.Parse(response);
            //        Console.WriteLine($"You entered - {number}");
            //    }
            //}

            // Catching multiple exceptions
            // Some will never catch due to InvalidOperationException
            //Console.Write("Give me a number (x to quit): ");
            //var response = Console.ReadLine();

            //int number = 0;
            //try
            //{
            //    throw new InvalidOperationException("oops");
            //    number = int.Parse(response);
            //}
            //catch (FormatException ex)
            //{

            //    Console.WriteLine($"You didn't enter a number! {ex}");
            //}
            //catch (InvalidOperationException ioe)
            //{
            //    Console.WriteLine("beep");
            //}
            //Console.WriteLine($"You entered - {number}");

            Console.WriteLine("enter a number");
            var response = Console.ReadLine();
            int number = 0;
            // out designates a var that needs to be assigned before the function ends
            // in this case, number will be assigned the value of response, if it returns true
            if (int.TryParse(response, out number))
            {
                Console.WriteLine($"You entered {number}");

            }
            else
            {
                Console.WriteLine("you didn't write a number");
            }

            var input = "Hello";
            string lower;
            var result = IsLowerCase(input, out lower);

            Console.WriteLine($"Result equals {result}, Lower = {lower}");

            Console.WriteLine("enter ur soc lol");
            input = Console.ReadLine();

            if (Regex.IsMatch(input, @"^\d{3}\-?\d{2}\-?\d{4}$"))
            {
                Console.WriteLine("ty lol");
            }
            else
            {
                Console.WriteLine("hey buddy just trust me :)"
                    );
            }

            Console.ReadLine();

        }
        // take in a string, return true if that string is already in lowercase
        // return false if it isnt in lower case
        // if false, also return the string as a lowercase string
        public static bool IsLowerCase(string input, out string lower)
        {
            lower = input.ToLower();
            return input == lower;
        }
    }
}
