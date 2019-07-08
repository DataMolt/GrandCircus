using System;

namespace ClassTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal buppie = new Dog();
            Dog spongus = new Dog();
            Console.WriteLine(spongus.Bark());
        }
    }
}
