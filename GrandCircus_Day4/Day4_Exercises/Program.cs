using System;

namespace Day4_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 10
            Console.WriteLine("Exercise 10");
            string input1;
            double value;
            double height;
            while (true)
            {
                Console.WriteLine("Please enter your height in inches: ");
                input1 = Console.ReadLine();
                if (double.TryParse(input1, out value))
                {
                    height = double.Parse(input1);
                    break;
                }
                else
                {
                    Console.WriteLine("Dude I'm gonna need a decimal or int");
                }
            }
            if (height < 54)
            {
                Console.WriteLine($"Sry, you cannot ride the raptor, you must be {54 - height} more inches");
            }
            else
            {
                Console.WriteLine("yo dude, let's ride");
            }
            Console.WriteLine("\n");


            //Exercise 11
            Console.WriteLine("Exercise 11");
            string value1 = null;
            for (int i = 0; i < 10; i++)
            {
                value1 += (i.ToString()) + " ";
            }
            Console.WriteLine(value1);
            Console.WriteLine("\n");


            //Exercise 12
            Console.WriteLine("Exercise 12");
            string value2 = null;
            for (int i = 9; i > -1 ; i--)
            {
                value2 += (i.ToString()) + " ";
            }
            Console.WriteLine(value2);
            Console.WriteLine("\n");


            //Exercise 14
            Console.WriteLine("Exercise 14");
            Console.WriteLine("Enter ur fave number lol: ");
            int input2 = int.Parse(Console.ReadLine());
            string value3 = null;
            for (int i = 1; i <= input2; i++)
            {
                value3 += (i * i) + " ";
            }
            Console.WriteLine(value3);
            Console.WriteLine("\n");


            //Exercise 15
            Console.WriteLine("Exercise 15");
            Console.WriteLine("Enter your next fave ok: ");
            int input3 = int.Parse(Console.ReadLine());
            string value4 = null;
            for (int i = 1; i <= input3; i++)
            {
                value4 += (i * i * i) + " ";
            }
            Console.WriteLine(value4);
            Console.WriteLine("\n");


            //Exercise 18
            Console.WriteLine("Exercise 18");
            Console.WriteLine("hey idk how many fav numbers u have but enter another plz: ");
            int input4 = int.Parse(Console.ReadLine());
            int value5 = 0;
            for (int i = 1; i <= input4; i++)
            {

                value5 += i;
            }
            Console.WriteLine(value5);
            Console.WriteLine("\n");


            Console.ReadLine();
        }
    }
}
