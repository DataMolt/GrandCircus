using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day17
{
    public class Player3 : Player
    {

        public Player3(string name) 
        {
            Name = name;
        }
        
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.scissors;
        }

    }
}
