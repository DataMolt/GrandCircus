using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzWoofLab
{
    public class FizzBuzzLogicChecking
    {
        public bool ThreePrintsFizz(int num)
        {
            if (num % 3 == 0 || num.ToString().Contains("3"))
            {
                return true;
            }
            return false;
        }

        public bool FivePrintsBuzz(int num)
        {
            if (num % 5 == 0 || num.ToString().Contains("5"))
            {
                return true;
            }
            return false;
        }

        public bool SevenPrintsWoof(int num)
        {
            if (num % 7 == 0 || num.ToString().Contains("7"))
            {
                return true;
            }
            return false;
        }

        public bool ThreeAndFive(int num)
        {
            if (ThreePrintsFizz(num) && FivePrintsBuzz(num))
            {
                return true;
            }
            return false;
        }

        public bool ThreeAndSeven(int num)
        {
            if (ThreePrintsFizz(num) && SevenPrintsWoof(num))
            {
                return true;
            }
            return false;
        }

        public bool FiveAndSeven(int num)
        {
            if (FivePrintsBuzz(num) && SevenPrintsWoof(num))
            {
                return true;
            }
            return false;
        }

        public bool ThreeFiveAndSeven(int num)
        {
            if (ThreeAndFive(num) && SevenPrintsWoof(num))
            {
                return true;
            }
            return false;
        }

        public void CheckEverything(int num)
        {
            if (ThreeFiveAndSeven(num))
            {
                Console.WriteLine($"{num} - FizzBuzzWoof");
                return;
            }
            else if (FiveAndSeven(num))
            {
                Console.WriteLine($"{num} - BuzzWoof");
                return;
            }
            else if (ThreeAndSeven(num))
            {
                Console.WriteLine($"{num} - FizzWoof");
                return;
            }
            else if (ThreeAndFive(num))
            {
                Console.WriteLine($"{num} - FizzBuzz");
                return;
            }
            else if (ThreePrintsFizz(num))
            {
                Console.WriteLine($"{num} - Fizz");
                return;
            }
            else if (FivePrintsBuzz(num))
            {
                Console.WriteLine($"{num} - Buzz");
                return;
            }
            else if (SevenPrintsWoof(num))
            {
                Console.WriteLine($"{num} - Woof");
                return;
            }
            else
            {
                Console.WriteLine($"{num}");
                return;
            }
        }
    }
}
