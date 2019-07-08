using System;

namespace GrandCircus_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
            Console.WriteLine(x);
            int y = x;

            string a = "42";
            bool b = false;
            int c = 0;

            Console.WriteLine(x == y);



            //Console.WriteLine(b == c); 
            //Apparently this doesn't work in C# but it does in Python
            //This only works for implicitly cast types

            //this will assign the var adam True, because x is equal to y
            bool adam = x == y;

            //this will assign the var brian False, because it inverts the value of adam
            bool brian = !adam;

            //hit tab tab after if and it builds the statement - cool
            if (brian)
            {
                Console.WriteLine("this is true");
            }
            else
            {
                Console.WriteLine("this is false");
            }

            //switch statement
            int e = 1;
            switch (e)
            {
                case 1:
                    Console.WriteLine("this is one");
                    break;
                case 2:
                    Console.WriteLine("this is two");
                    break;
                default:
                    Console.WriteLine("default statement");
                    break;
            }

            //while loops
            bool whileCheck = true;
            while (whileCheck)
            {
                Console.WriteLine("one loop");
                whileCheck = false;
            }

            //do loop
            //do loops will always run once
            string input2 = null;
            do
            {
                Console.WriteLine("From a do loop dee loop");
                input2 = Console.ReadLine();
            } while (input2 != "x");

            //for loops
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            //exercise 1
            Console.WriteLine("Enter some text! ");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput);

            Console.ReadKey();

        }
    }
}
