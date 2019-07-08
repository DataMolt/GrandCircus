using System;

namespace Excercise75
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareRoot(25));
            Console.WriteLine(SquareRoot(16));
            Console.WriteLine(SquareRoot(256));
        }
        public static int SquareRoot(int getRoot)
        {
            for (int i = 1; i < getRoot; i++)
            {
                if (getRoot % i == 0)
                {

                    if (i * i == getRoot)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

        public static int SquareRootBabylon(int num)
        {
            var stringNum = num.ToString();
            var stopper = 2;
            for (int i = 0; i < stopper; i++)
            {

            }
        }
    }
}
