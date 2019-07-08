using System;

namespace GrandCircus_Day16
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogFactory = new FactoryExample.DogFactory();

            var dog = dogFactory.Create(FactoryExample.DogType.Poodle);

            Console.WriteLine(dog.Bark());
            Console.WriteLine();

            var gameFactory = new MyFactory.GameFactory();
        }
    }
}
