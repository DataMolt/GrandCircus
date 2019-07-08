using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public MagicUsingCharacter(int magicalEnergy, string name, int strength, int intelligence)
            : base(name, strength, intelligence)
        {
            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($"Your character's name is {Name}.\nTheir magical energy is {MagicalEnergy}.\nStrength: {Strength}\nIntelligence: {Intelligence}");
        }
    }
}
