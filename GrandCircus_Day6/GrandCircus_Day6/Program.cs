using System;

namespace GrandCircus_Day6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Review for assessment
            // if statement
            int number = 3;
            if (number > 0)
            {
                Console.WriteLine("Hell yeah boi");
            }
            else
            {
                Console.WriteLine("Hell nah dawg");
            }

            // switch statement
            switch (number)
            {
                case 1:
                    Console.WriteLine("lol");
                    break;
                case 2:
                    Console.WriteLine("rofl");
                    break;
                case 3:
                    Console.WriteLine("lmao");
                    break;
                default:
                    break;
            }

            //DoYouLikeBeansLoop();

            Console.ReadLine();
        }
        // method
        public static string DoYouLikeBeans(string userInput)
        {
            string beanAnswer;
            if (userInput.Equals("y", StringComparison.OrdinalIgnoreCase))
            {
                beanAnswer = "you're a little bean baby boy";
            }
            else if (userInput.Equals("n", StringComparison.OrdinalIgnoreCase))
            {
                beanAnswer = "no beans about it";
            }
            else
            {
                beanAnswer = "type in 'y' or 'n' you bean warned";
            }
            return beanAnswer;
        }

        // wrapping a function around a function
        public static void DoYouLikeBeansLoop()
        {
            string beanAskAgain;
            do
            {
                Console.WriteLine("You like beans?");
                string beanAnswer = DoYouLikeBeans(Console.ReadLine());
                Console.WriteLine(beanAnswer);
                Console.WriteLine("wanna try again (y/n)? ");
                beanAskAgain = Console.ReadLine();
            } while (!beanAskAgain.Equals("n", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("it's bean fun");
        }
    }
}
