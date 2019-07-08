using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    class GameCharacter
    {
        private string v;

        public string Name { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public GameCharacter(string name, int strength, int intelligence)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }

        public GameCharacter(string name)
        {
        }

        public virtual void Play()
        {
            Console.WriteLine($"Your character's name is {Name}.\nStrength: {Strength}\nIntelligence: {Intelligence}");
        }

        protected void Scream()
        {
            Console.WriteLine("WWWWWWAAARRGHHHH!!!!");
        }
    }
}
