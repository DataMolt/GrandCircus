using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day17
{
    public abstract class Player
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }

        public abstract Roshambo GenerateRoshambo();
    }
}
