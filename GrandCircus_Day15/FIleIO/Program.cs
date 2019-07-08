using System;
using System.IO;

namespace FIleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("C:\\Users\\Shusui\\Desktop\\someFile.txt"))
            {
                Console.WriteLine("found this haha");
                //File.Delete("C:\\Users\\Shusui\\Desktop\\someFile.txt");
            }
            else
            {
                Console.WriteLine("didn't find it aww");
            }

            //File.WriteAllText("C:\\Users\\Shusui\\Desktop\\newFile.txt", "hello");
            File.AppendAllText("C:\\Users\\Shusui\\Desktop\\newFile.txt", $"hello at {DateTime.Now.ToLongDateString()}");

            var contents = File.ReadAllText("C:\\Users\\Shusui\\Desktop\\newFile.txt");
            Console.WriteLine(contents);


            using (var writer = new StreamWriter("C:\\Users\\Shusui\\Desktop\\SomeStreamFile.txt"))
            {
                writer.WriteLine("Hello");
                writer.WriteLine("\nWorld");
                writer.Flush();
            }

            /*
            var writer = new StreamWriter("C:\\Users\\Shusui\\Desktop\\SomeStreamFile.txt");
            writer.WriteLine("Hello");
            writer.WriteLine("\nWorld");
            writer.Flush();
            writer.Dispose();
            */
        }
    }
}
