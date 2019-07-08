using System;
using System.Text;

namespace GrandCircus_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.WriteLine($"{i} x {j}");
                }
            }

            // continue and break statements
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    //break;
                    continue;
                }
                Console.WriteLine(i);
            }

            // string immutability
            string a1 = "Steak Sauce";

            a1 += "!!!";

            //string concatenation
            string a2 = a1 + " iz gud dawg";
            string a3 = string.Concat(a1, " mmmm", " so good");

            //string formatting
            string a4 = $"{a1} hell yeah";
            string a5 = string.Format("{0} {1} !!", a1, " stained my shirt");

            //string comparisons
            string a6 = "Adam Lott";
            string a7 = "adam lott";
            string a8 = "Adam Brian Lott";
            Console.WriteLine(a6 == a7);
            //will ignore casing
            Console.WriteLine(a6.Equals(a7, StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(string.Compare(a6, a7, true));

            //string functions
            Console.WriteLine(a6.IndexOf('t'));
            Console.WriteLine(a7.IndexOf('a', 2));
            Console.WriteLine(a6.LastIndexOf('t'));
            Console.WriteLine(a8.Substring(5, 6));
            Console.WriteLine(a8.Substring(a8.IndexOf(" ") + 1, a8.LastIndexOf(" ") - a8.IndexOf(" ")));
            Console.WriteLine(a8.EndsWith("t"));
            Console.WriteLine(a8.Trim().EndsWith("t"));

            //string immutability
            string name;
            name = "adam"; // adam
            name = "brian"; // adam, adam brian 
            name += " lott"; // adam, adam brian, adam brian lott
            Console.WriteLine(name);
            //in this method you're reading a ton of content into memory

            //an effecient way of building a string
            //it waits until the string is complete before allocating memory to the string
            StringBuilder builder = new StringBuilder();
            builder.Append("adam"); // adam
            builder.Append(" brian "); // adam brian
            builder.Append("lott"); // adam brian lott
            Console.WriteLine(builder.ToString()); // this ties them all together


            Console.ReadKey();
        }
    }
}
