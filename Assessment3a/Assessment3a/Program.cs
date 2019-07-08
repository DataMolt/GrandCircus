using System;

namespace Assessment3a
{
    class Program
    {
        static void Main(string[] args)
        {
            var spaceShuttle = new SpaceShuttle();

            foreach (var member in spaceShuttle.Team)
            {
                Console.WriteLine($"{member.Name} is the {member.Role} of the ship");
            }

            Console.WriteLine($"\nWill the shuttle launch with {spaceShuttle.Fuel} fuel? {spaceShuttle.Launch()}");

            spaceShuttle.Fuel = 5;
            Console.WriteLine($"\nWill the shuttle launch with {spaceShuttle.Fuel} fuel? {spaceShuttle.Launch()}");

            spaceShuttle.Fuel = 6;
            Console.WriteLine($"\nWill the shuttle launch with {spaceShuttle.Fuel} fuel? {spaceShuttle.Launch()}");
        }
    }
}
