using System;

namespace FeedACow
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueCheck = null;
            var spot = new Cow();
            do
            {
                Console.WriteLine("you wanna feed my spotty girl?");
                Console.Write("what are ya feeding her: ");
                spot.Feed(Console.ReadLine());
                Console.WriteLine($"Spot now weighs {spot.Weight}");
                Console.WriteLine("you wanna feed her again?");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));

        }
}
}
