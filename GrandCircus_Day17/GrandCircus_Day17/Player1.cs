using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day17
{
    public class Player1 : Player
    {

        public Player1()
        {
            Name = "John Rockman";
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
