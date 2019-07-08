using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day17
{
    class Player2 : Player
    {
        public Player2()
        {
            Name = "Rand Dumb";
        }

        public override Roshambo GenerateRoshambo()
        {
            return GenerateRandomMove();
        }

        private Roshambo GenerateRandomMove()
        {
            var values = Enum.GetValues(typeof(Roshambo));
            Random random = new Random();
            Roshambo randomMove = (Roshambo)values.GetValue(random.Next(values.Length));
            return randomMove;
        }
    }
}
