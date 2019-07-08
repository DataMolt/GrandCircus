using System;
using System.Text.RegularExpressions;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 41
            Console.WriteLine("Exercise 41");

            Console.Write("Enter a numerator:" );
            string numerator = Console.ReadLine();
            Console.WriteLine("Enter a denominator: ");
            string denominator = Console.ReadLine();
            double dividedInput = DivideDoubles(numerator, denominator);
            Console.WriteLine(RoundSecondDecimal(dividedInput));
        }

        public static double DivideDoubles(string userInput1, string userInput2)
        {
            double checkedNumerator = VerifyDouble(userInput1);
            double checkedDenominator = VerifyDouble(userInput2);
            return checkedNumerator / checkedDenominator;
        }

        public static double VerifyDouble(string userInput)
        {
            double checkInput;
            while (true)
            {
                if (double.TryParse(userInput, out checkInput))
                {
                    checkInput = double.Parse(userInput);
                    break;
                }
                else
                {
                    Console.Write("Can only accept a valid integer or decimal: ");
                    userInput = Console.ReadLine();
                }
            }
            return checkInput;
        }

        public static double RoundSecondDecimal(double dividedBool)
        {
            //string dividedBoolToSTring = dividedBool.ToString();
            //Match m = Regex.Match(dividedBoolToSTring, @"^\d+\.\d{3}");
            //double toTheThirdDecimal = double.Parse(m.Value);
            // I was going to do this manually but got lazy lol
            return Math.Round(dividedBool, 2);
        }
    }
}