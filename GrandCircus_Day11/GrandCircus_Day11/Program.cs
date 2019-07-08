using System;
using System.Collections.Generic;

namespace GrandCircus_Day11
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Animal("Vincent", 5);
            Console.WriteLine(animal.Name);

            var animalTwo = new Animal("Jessie", 3);

            var animalThree = new Animal("Millie", 2);

            Console.WriteLine(animalThree.Age);

            //var dog = new Dog("Poppins", 20);
            //Console.WriteLine(dog.Age);

            var terrier = new Terrier("Vincent", 5);
            Console.WriteLine(terrier.Bark());

            var poodle = new Poodle("Turbo", 4);
            Console.WriteLine(poodle.Bark());
            Console.WriteLine(poodle.makeNoise());

            var yorkie = new Yorkie("Lil Screamer", 1);
            Console.WriteLine(yorkie.Bark());
            Console.WriteLine("\n");

            var dogs = new List<Dog>();
            dogs.Add(terrier);
            dogs.Add(poodle);
            dogs.Add(yorkie);

            // we only have access to properties from the parent class DOG
            // cannot use methods or properties specific to child classes
            foreach (var dog in dogs)
            {
                Console.WriteLine(dog.Bark());
            }
            Console.WriteLine("\n");

            // changing a type yorkie into a type poodle
            Poodle convertedPoodle = MapToPoodle(yorkie);
            Console.WriteLine(convertedPoodle.makeNoise());


            Console.ReadLine();
        }
        // process mapping
        // manually converting one created type to another
        public static Poodle MapToPoodle(Yorkie yorkie)
        {
            var poodle = new Poodle(yorkie.Name, yorkie.Age);
            return poodle;
        }
    }
}
