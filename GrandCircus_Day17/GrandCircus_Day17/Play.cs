using System;
using System.Collections.Generic;
using System.Text;

namespace GrandCircus_Day17
{
    class Play
    {
        public Play()
        {
            var player1 = new Player1();
            var player2 = new Player2();
            Console.WriteLine("Welcome to the Rock, Paper, Scissors game!");
            Console.WriteLine("What is your name?");
            var playerName = Console.ReadLine();
            var human = new Player3(playerName);
        }

        public void PrintOpponentSelection()
        {
            var counter = 1;
            var players = Enum.GetValues(typeof(Players));
            foreach (var player in players)
            {
                Console.WriteLine($"{counter} - {player}");
                counter++;
            }
        }

        public string ChooseOpponent()
        {
            Console.WriteLine("Select your challenger!");
            PrintOpponentSelection();
            var opponentSelection = Console.ReadLine();
            return opponentSelection;
        }

        public Players ChooseOpponentValidate(string userSelection)
        {
            Players returnPlayer = Players.RockMan;
            Players clearedPlayerCheck;
            bool checker = true;
            do
            {
                if (Enum.TryParse<Players>(userSelection, out clearedPlayerCheck) && Enum.IsDefined(typeof(Players), clearedPlayerCheck))
                {
                    returnPlayer = GetPlayer(clearedPlayerCheck);
                    checker = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please choose a player in the player list");
                    userSelection = ChooseOpponent();
                }
            } while (checker);
            return returnPlayer;
        }

        public static Players GetPlayer(Players player)
        {
            Players returnPlayer = Players.RockMan;
            switch (player)
            {
                case Players.RockMan:
                    returnPlayer = Players.RockMan;
                    break;
                case Players.RandDumb:
                    returnPlayer = Players.RandDumb;
                    break;
                default:
                    break;
            }
            return returnPlayer;
        }


        
        public string ChooseMove()
        {
            Console.WriteLine("Choose rock, paper, or scissors");
            var moveSelection = Console.ReadLine();
            return moveSelection;
        }
        
        public Roshambo ChooseMoveValidate(string userSelection)
        {
            Roshambo returnMove = Roshambo.paper;
            Roshambo clearedMoveCheck;
            bool checker = true;
            do
            {
                if (Enum.TryParse<Roshambo>(userSelection, out clearedMoveCheck) && Enum.IsDefined(typeof(Roshambo), clearedMoveCheck))
                {
                    returnMove = GetRoshambo(clearedMoveCheck);
                    checker = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid move");
                    userSelection = ChooseMove();
                }
            } while (checker);
            return returnMove;
        }

        public static Roshambo GetRoshambo(Roshambo roshambo)
        {
            Roshambo returnMove = Roshambo.paper;
            switch (roshambo)
            {
                case Roshambo.rock:
                    returnMove = Roshambo.rock;
                    break;
                case Roshambo.paper:
                    returnMove = Roshambo.paper;
                    break;
                case Roshambo.scissors:
                    returnMove = Roshambo.scissors;
                    break;
                default:
                    break;
            }
            return returnMove;
        }
        

        public static void CheckWinner(Player computerPlayer, Player humanPlayer)
        {
            if (computerPlayer.GenerateRoshambo() == humanPlayer.GenerateRoshambo())
            {
                returnOutcome(computerPlayer, humanPlayer);
                Console.WriteLine("It's a draw!");
            }
            else if (computerPlayer.GenerateRoshambo() == Roshambo.rock)
            {
                if (humanPlayer.GenerateRoshambo() == Roshambo.paper)
                {
                    returnOutcome(computerPlayer, humanPlayer);
                    Console.WriteLine("You win!");
                    humanPlayer.Wins++;
                    computerPlayer.Losses++;
                }
                else
                {
                    returnOutcome(computerPlayer, humanPlayer);
                    Console.WriteLine("You lose!");
                    humanPlayer.Losses++;
                    computerPlayer.Wins++;
                }
            }
            else if (computerPlayer.GenerateRoshambo() == Roshambo.paper)
            {
                if (humanPlayer.GenerateRoshambo() == Roshambo.scissors)
                {
                    returnOutcome(computerPlayer, humanPlayer);
                    Console.WriteLine("You win!");
                    humanPlayer.Wins++;
                    computerPlayer.Losses++;
                }
                else
                {
                    returnOutcome(computerPlayer, humanPlayer);
                    Console.WriteLine("You lose!");
                    humanPlayer.Losses++;
                    computerPlayer.Wins++;
                }
            }
            else
            {
                if (humanPlayer.GenerateRoshambo() == Roshambo.rock)
                {
                    returnOutcome(computerPlayer, humanPlayer);
                    Console.WriteLine("You win!");
                    humanPlayer.Wins++;
                    computerPlayer.Losses++;
                }
                else
                {
                    returnOutcome(computerPlayer, humanPlayer);
                    Console.WriteLine("You lose!");
                    humanPlayer.Losses++;
                    computerPlayer.Wins++;
                }
            }
        }

        public static void returnOutcome(Player computerPlayer, Player humanPlayer)
        {
            Console.WriteLine($"{humanPlayer.Name} threw {humanPlayer.GenerateRoshambo()}! {computerPlayer.Name} threw {computerPlayer.GenerateRoshambo()}!");
        }
        /*
        public static Roshambo ValidateEntry()
        {
            Roshambo returnMove = Roshambo.rock;
            bool checker = true;
            Roshambo clearedMoveCheck;
            do
            {
                Console.Write("Choose rock, paper, or scissors: ");
                var response = Console.ReadLine();
                if (Enum.TryParse<Roshambo>(response, out clearedMoveCheck) && Enum.IsDefined(typeof(Roshambo), clearedMoveCheck))
                {
                    returnMove = getCategory(clearedMoveCheck);
                    checker = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Can only accept rock, paper, or scissors.");
                }
            } while (checker);
            return returnMove;
            
        }
        */
    }
}
