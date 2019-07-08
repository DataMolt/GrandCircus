using System;

namespace GrandCircus_Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop outline
            // step 1: initialize variable, ie int i = 0
            // step 2: check for boolean statement, ie i < 10
            // step 3: if false, for loop ends, no more for loop, done
            // step 4: increment or decrement, ie i++
            // step 5: repeat step 2
            for (int i = 0; i < 3; i++)
			{
                Console.WriteLine(i);
			}

            Console.Write("this ");
            Console.Write("is ");
            Console.Write("cool");
            Console.ReadLine();
        }
    }
}
