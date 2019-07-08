using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GrandCircus_Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists
            
            List<string> movies = new List<string>();
            movies.Add("The Goonies");
            movies.Add("Star Wars");
            movies.Add("Die Hard");

            Console.WriteLine(movies[1]);
            Console.WriteLine("\n");

            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine("\n");

            movies.Insert(1, "The Shining");
            Console.WriteLine(movies[1]);
            Console.WriteLine("\n");

            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine("\n");

            var sentence2 = "Game of Thrones is cool haha";
            var words2 = sentence2.Split(" ");

            var wordsList2 = new List<string>();
            wordsList2.AddRange(words2);

            var wordsArray2 = wordsList2.ToArray();
            var sentence3 = wordsArray2.ToList();

            // Dictionaries
            var dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "you did it");
            dictionary[1] = "you did it again";
            dictionary.Add(2, "you are cool");
            dictionary.Add(3, "you da man");

            Console.WriteLine(dictionary[1]);

            Console.WriteLine("\n");

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }

            Console.WriteLine("\n");

            var dictionary2 = new Dictionary<Guid, string>();
            dictionary2.Add(Guid.NewGuid(), "Hello");
            dictionary2.Add(Guid.NewGuid(), "Hola");
            dictionary2.Add(Guid.NewGuid(), "Bonjour");

            foreach (var kvp in dictionary2)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }

            // Queue (FIFO)
            // (First in first out)
            var queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("World");

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            // Stack (LIFO)
            // (Last in first out)
            var stack = new Stack<string>();
            stack.Push("Hello");
            stack.Push("World");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }
}
