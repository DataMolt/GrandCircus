using System;
using System.Collections.Generic;

namespace GrandCircus_Day10
{
    class Program
    {
        static void Main(string[] args)
        {
            // collections practice
            var people = new List<string>();
            people.Add("Adam");
            people.Add("Kelly");
            people.Add("Vincent");

            var count = people.Count;

            var lastIndex = people[count - 1];
            people.RemoveAt(people.Count - 1);

            foreach (var thing in people)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine(new string('=', 20));

            // this is a constructor
            var person = new Person("Adam");

            var names = new List<string>()
            {
                "Adam",
                "Kelly",
                "Vincent"
            };

            while (true)
            {
                Console.WriteLine("Enter something hehe: ");
                names.Add(Console.ReadLine());

                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }

                Console.WriteLine("Do you want to continue? (y/n): ");
                var userKey = Console.ReadKey();
                if (userKey.Key != ConsoleKey.Y)
                {
                    break;
                }
            }

            Console.WriteLine("\n");

            var adam = new Person("Adam");
            adam.Age = "29";
            adam.Address = "123 Fake Street";

            Console.WriteLine(adam.Age);
            Console.WriteLine(adam.Address);

            Console.ReadLine();
        }
    }
}
