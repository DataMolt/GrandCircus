using System;
using System.Collections.Generic;

namespace Bonus13
{
    class Program
    {
        static void Main(string[] args)
        {
            var Yarr = new Warrior("Club of Smash", "Yarr", 200, 2);
            var Garr = new Warrior("Axe of Cut", "Garr", 200, 2);
            var Wizro = new Wizard(15, 150, "Wizro", 3, 200);
            var Bizro = new Wizard(30, 120, "Bizro", 3, 180);
            var Sizro = new Wizard(20, 150, "Sizro", 3, 220);

            var playerList = new List<GameCharacter>();
            playerList.Add(Yarr);
            playerList.Add(Garr);
            playerList.Add(Wizro);
            playerList.Add(Bizro);
            playerList.Add(Sizro);

            foreach (var player in playerList)
            {
                player.Play();
                Console.WriteLine("\n");
            }

            Yarr.LoudNoise();
            Console.WriteLine(Yarr.CoolProp);

            Console.ReadLine();
        }
    }
}
