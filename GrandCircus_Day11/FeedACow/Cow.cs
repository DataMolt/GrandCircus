using System;
using System.Collections.Generic;
using System.Text;

namespace FeedACow
{
    class Cow
    {
        public int Weight { get; set; }

        public Cow()
        {
            Weight = 50;
        }


        public void Feed(string userInput)
        {
            switch (userInput)
            {
                case "carrot":
                    Weight += 1;
                    break;
                case "grass":
                    Weight += 2;
                    break;
                case "pie":
                    Weight += 10;
                    break;
                default:
                    Console.WriteLine("I ain't feedin ma girl that");
                    break;
            }
        }
    }
}
