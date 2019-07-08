using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public Wizard(int spellNumber, int magicalEnergy, string name, int strength, int intelligence) 
            : base(magicalEnergy, name, strength, intelligence)
        {
            SpellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"Your character's name is {Name}.\nTheir magical energy is {MagicalEnergy}.\nThey have {SpellNumber} spells left." +
                $"\nStrength: {Strength}\nIntelligence: {Intelligence}");
        }
    }
}
