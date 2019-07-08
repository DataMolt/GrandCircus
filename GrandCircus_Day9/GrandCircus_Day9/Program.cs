using System;
using System.Collections.Generic;


namespace GrandCircus_Day9
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = testClass.Sum(5, 6);
            Console.WriteLine(result);
            Console.WriteLine("\n");

            var vincent = new Animal("Vincent");
            //vincent.SetName("Vincent");
            Console.WriteLine(vincent.GetName());
            Console.WriteLine("\n");

            vincent.SetName("Boo Boo");
            Console.WriteLine(vincent.GetName());
            Console.WriteLine("\n");

            var jessie = new Animal("Jessie");
            //jessie.SetName("Jessie");
            Console.WriteLine(jessie.GetName());
            Console.WriteLine("\n");

        }
    }
}
