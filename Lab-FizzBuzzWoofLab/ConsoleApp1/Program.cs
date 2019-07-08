using System;

namespace FizzBuzzWoofLab
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzzChecker = new FizzBuzzLogicChecking();
            for (int i = 1; i < 101; i++)
            {
                fizzBuzzChecker.CheckEverything(i);
            }

        }
    }
}

