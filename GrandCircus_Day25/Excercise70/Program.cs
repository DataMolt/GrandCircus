using System;
using System.Collections.Generic;
using System.IO;

namespace Excercise70
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var translateJapanese = new Dictionary<string, string>
            {
                { "uma", "horse" },
                { "neko", "cat" },
                { "inu", "dog" },
                { "sakana", "fish" },
                { "tori", "bird" },
            };
            */

            var translateJapanese = new Dictionary<string, string>();

            string checker = "y";
            while (!(checker == "n"))
            {
                Console.WriteLine("Type in key value pairs");
                var splitShit = Console.ReadLine().Split(" ");
                translateJapanese.TryAdd(splitShit[0], splitShit[1]);
                Console.WriteLine("try again?");
                checker = Console.ReadLine();
            }
            foreach (var kvp in translateJapanese)
            {
                System.IO.File.AppendAllText(@"C:\Users\Shusui\Desktop\translations.txt", $"{kvp.Key} - {kvp.Value}\n");
            }
        }
    }
}
