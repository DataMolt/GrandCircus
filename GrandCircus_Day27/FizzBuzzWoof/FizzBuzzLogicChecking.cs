using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzWoof
{
    public class FizzBuzzLogicChecking
    {
        public string ThreePrintsFizz(int num)
        {
            if (num % 3 == 0 || num.ToString().Contains("3"))
            {
                return "Fizz";
            }
            return null;
        }

        public string FivePrintsBuzz(int num)
        {
            if (num % 5 == 0 || num.ToString().Contains("5"))
            {
                return "Buzz";
            }
            return null;
        }

        public string SevenPrintsWoof(int num)
        {
            if (num % 7 == 0 || num.ToString().Contains("7"))
            {
                return "Woof";
            }
            return null;
        }

        public string ThreeAndFive(int num)
        {
            if (!(ThreePrintsFizz(num) == null) && !(FivePrintsBuzz(num) == null))
            {
                return "FizzBuzz";
            }
            return null;
        }

        public string ThreeAndSeven(int num)
        {
            if (!(ThreePrintsFizz(num) == null) && !(SevenPrintsWoof(num) == null))
            {
                return "FizzWoof";
            }
            return null;
        }

        public string FiveAndSeven(int num)
        {
            if (!(ThreePrintsFizz(num) == null) && !(SevenPrintsWoof(num) == null))
            {
                return "BuzzWoof";
            }
            return null;
        }

        public string ThreeFiveAndSeven(int num)
        {
            if (!(ThreeAndFive(num) == null) && !(SevenPrintsWoof(num) == null))
            {
                return "FizzBuzzWoof";
            }
            return null;
        }
    }
}
