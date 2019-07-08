using System;

namespace GrandCircus_Day15
{
    class Program
    {
        static void Main(string[] args)
        {

            // one method for parsing
            //var move = int.Parse(response);

            // var move =  Enum.Parse<Move>(response);
            // Turn(move);

            // Turn(Move.Paper);

            // Casting to enum type
            //Turn((Move)move);

            /*
            if (int.TryParse(response, out int move1))
            {
                Turn((Move)move1);
            }
            */
            bool checker = true;
            do
            {
                Console.Write("Make a move: ");
                var response = Console.ReadLine();
                if (Enum.TryParse<Move>(response, out var move2))
                {
                    Turn(move2);
                    checker = false;
                    break;
                }
                else
                {
                    Console.WriteLine("lol wut izzit");
                    Console.WriteLine("give me something I can work with idiot");
                    var values = Enum.GetValues(typeof(Move));
                    Console.WriteLine("enter one of these lol");
                    foreach (var value in values)
                    {
                        Console.WriteLine(value);
                    }
                }
            } while (checker);

            bool checker2 = true;
            do
            {
                Move mover;
                Console.Write("Make another move: ");
                var response = Console.ReadLine();
                if (Enum.TryParse(response, true, out mover) && Enum.IsDefined(typeof(Move), mover))
                {
                    Turn(mover);
                    checker2 = false;
                    break;
                }
                else
                {
                    Console.WriteLine("lol wut izzit");
                    Console.WriteLine("give me something I can work with idiot");
                    var values = Enum.GetValues(typeof(Move));
                    Console.WriteLine("enter one of these lol");
                    foreach (var value in values)
                    {
                        Console.WriteLine(value);
                    }
                }
            } while (checker2);

        }

    public static void Turn(Move move)
        {
            switch (move)
            {
                case Move.Rock:
                    Console.WriteLine("Rock on");
                    break;
                case Move.Paper:
                    Console.WriteLine("Origami");
                    break;
                case Move.Scissor:
                    Console.WriteLine("Running with");
                    break;
                default:
                    break;
            }

            /*
            if (move == Move.Paper)
            {
                Console.WriteLine("Paper");
            }
            */
        }
    }
}
