using System;

namespace GrandCircus_Day7
{
    class Program
    {
        static void Main(string[] args)
        {
            // our first array <3
            // an array literal
            // hard coding a value to a variable is a literal
            int[] intArray = new int[] {2,5,5,1,2,3};

            // tells how many elements can exist in the array
            string[] stringArray = new string[5];

            // Dont do things this way, not a common method
            int[] intArrayTwo = { 2, 3, 4, 5 };

            // this is an int literal
            int number = 5;

            int[] intArrayCopy = intArrayTwo;

            int indexOne = intArray[0];

            Console.WriteLine(indexOne);

            intArrayTwo[0] = 6;

            // reference types refer to the same value, so changing things changes every var pointing to it
            Console.WriteLine(intArrayTwo[0]);
            Console.WriteLine(intArrayCopy[0]);

            string[] names = new string[] {"Adam", "Kelly", "Vincent", "Haley", "Goku", "Ang"};

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            // Another way to assign an array
            double[] numbers = new double[3];
            numbers[0] = 2.2d;
            numbers[1] = 5.7d;
            numbers[2] = 9.3d;

            int aNameTotal = GetANames(names);
            Console.WriteLine(aNameTotal);

            string[] states = { "MI", "TX", "OR" };

            Console.WriteLine();

            // FOR EACH LOOPZ BAY-BEEEE
            string[] foods = new string[] { "pizza", "burrito", "sushi", "fromage" };

            foreach (var food in foods)
            {
                Console.WriteLine(food);

            }

            // substring test
            string hello = "hello";
            Console.WriteLine(hello.Substring(1));

            // multi dimensional array
            int[][] nestedArry = new int[][] { new int[] { 2 }};

            int[,] perfectTwoDArry = new int[3,2];
            perfectTwoDArry[0, 0] = 1;

            int acc = 0;
            for (int col = 0; col < perfectTwoDArry.GetLength(0); col++)
            {
                for (int row = 0; row < perfectTwoDArry.GetLength(1); row++)
                {
                    perfectTwoDArry[col, row] = acc;
                    acc++;
                }
            }

            // jagged array
            //int[][] jaggedArray = new int[][] { new int[2], new int[3], new int[4] };
            /*
            var accTwo = 0;
            for (int row = 0; row < jaggedArray.GetLength(0); row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] = accTwo;
                    accTwo++;
                }
            }
            */
            int[][] jaggedArray = new int[][] { new int[2] { 1, 2 }, new int[3] { 3, 4, 5 }, new int[4] { 6, 7, 8, 9 } };

            
            foreach (var row in jaggedArray)
            {
                foreach (var col in row)
                {
                    Console.WriteLine($"{col}");
                }
            }

            Console.ReadLine();
        }
            static int GetANames(string[] names)
            {
            int aCounter = 0;
            for (int i = 0; i < names.Length; i++)
            {
                // you can do this also to get the first index
                // Console.WriteLine(names[i][0]);
                var name = names[i];
                if (names[i].StartsWith("A", StringComparison.OrdinalIgnoreCase))
                {
                    aCounter++;
                }
            }
            return aCounter;
            }
    }
}
