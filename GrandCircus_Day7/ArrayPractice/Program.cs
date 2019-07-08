using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] newArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine("This is a multidimensional array of consistent length");
            Console.WriteLine($"The length of the outer array is {newArray.GetLength(0)}");
            Console.WriteLine($"The length of each row is {newArray.GetLength(1)}");
            Console.WriteLine("\n");
            for (int i = 0; i < newArray.GetLength(0); i++)
            {
                for (int j = 0; j < newArray.GetLength(1); j++)
                {
                    Console.WriteLine($"The value in array {i} at index {j} is {newArray[i, j]}");

                }
                Console.WriteLine("\n");

            }

            Console.WriteLine("This is a multidimensional, jagged array");
            int[][] newJaggedArray = new int[3][] { 
                new int[] { 1 }, 
                new int[] { 2, 3 }, 
                new int[]{ 4, 5, 6 }
            };
            for (int i = 0; i < newJaggedArray.GetLength(0); i++)
            {
                Console.WriteLine($"The length of array at index {i} is {newJaggedArray[i].Length}");
                for (int j = 0; j < newJaggedArray[i].Length; j++)
                {
                    Console.WriteLine($"The value in array {i} at index {j} is {newJaggedArray[i][j]}");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Let's make a string array");
            string sentence = "Please excuse my dear aunt sally";
            Console.WriteLine("For each loop");
            string[] words = sentence.Split(' ');
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");

            Console.WriteLine("For loop");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }

            string[] newStringArray = new string[words.Length + 1];
            for (int i = 0; i < words.Length; i++)
            {
                newStringArray[i] = words[i];
            }

            string[] newStringArray2 = new string[words.Length + 1];
            words.CopyTo(newStringArray2, 0);

            Console.WriteLine("\nDone");

            Console.ReadLine();
        }
    }
}
