using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus13
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior(string weaponType, string name, int strength, int intelligence) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($"Your character's name is {Name}.\nThey wield a mighty {WeaponType}.\nStrength: {Strength}\nIntelligence: {Intelligence}");
        }

        public void LoudNoise()
        {
            Scream();
        }

        public string CoolProp { get; set; }
    }
}
