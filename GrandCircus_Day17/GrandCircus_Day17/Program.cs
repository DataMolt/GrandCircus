using System;

namespace GrandCircus_Day17
{
    class Program
    {
        static void Main(string[] args)
        {
            var play = new Play();
            var computerPlayerToVerify = play.ChooseOpponent();
            var computerPlayer = play.ChooseOpponentValidate(computerPlayerToVerify);
            var getMovetoVerify = play.ChooseMove();
            var playerMove = play.ChooseMoveValidate(getMovetoVerify);
            play.CheckWinner(computerPlayer, )
        }
    }
}
