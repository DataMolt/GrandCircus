using System;
using System.Collections;
using System.Collections.Generic;

namespace GrandCircus_Day25
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myList = new List<int>();

            // array lists dont have type safety
            var myArrayList = new ArrayList();
            myArrayList.Add(56);
            myArrayList.Add("hehe");

            // List
            // a generic structure in c#
            var list = new List<int>();
            Console.WriteLine($"the default length of a list is {list.Capacity}\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Capacity - {list.Capacity}, Count - {list.Count}");
                list.Add(i);
            }

            // remove by value
            list.Remove(1);

            // remove at index
            list.RemoveAt(0);

            var test = new List<string>();
            var test2 = new List<string>();
            test2.Add("haha");
            test2.Add("hehe");
            test.AddRange(test2);


            // arrays
            // arrays are finite length
            var myArray = new int[5];
            var myArray2 = new int[10];
            var myArray3 = new int[15];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine("\n");

            var newNumber = 1;
            myArray2[0] = newNumber + 2;
            Console.WriteLine(newNumber);
            Console.WriteLine(myArray2[0]);
            Console.WriteLine("\n");

            Array.Copy(myArray, myArray3, 5);
            foreach (var item in myArray3)
            {
                Console.WriteLine(item);
            }

            // dictionaries
            var books = new List<Book>();
            books.Add(new Book { Author = "me", Title = "hehe me" });

            var betterBooks = new Dictionary<string, Book>
            {
                { "hehe me", new Book { Author = "me", Title = "hehe me" } },
                { "hehe me again", new Book { Author = "Adam", Title = "hehe me again" } }
            };

            foreach (var kvp in betterBooks)
            {
                Console.WriteLine($"Key - {kvp.Key}, Value - {kvp.Value.Author}");
            }

            betterBooks.TryAdd("hehe me", new Book { Author = "satan", Title = "bad book" });

            // Queue (FIFO)
            Console.WriteLine("\n");
            var newBook = new Book { Author = "satan again", Title = "life's good" };
            var newBook2 = new Book { Author = "satan again lol", Title = "life's great" };
            var newBook3 = new Book { Author = "satan again lmao", Title = "life's amazing" };
            var myQueue = new Queue<Book>();
            myQueue.Enqueue(newBook);
            myQueue.Enqueue(newBook2);
            myQueue.Enqueue(newBook3);
            Console.WriteLine(myQueue.Peek());
            Console.WriteLine(myQueue.Dequeue().Author);
            Console.WriteLine(myQueue.Dequeue().Author);
            Console.WriteLine(myQueue.Dequeue().Author);

            // Stack, like Pringles (LIFO)
            var pringles = new Stack<string>();
            pringles.Push("Sour Cream and Onion");
            pringles.Push("Cheddar");
            pringles.Push("Jalapeno");

            Console.WriteLine("\n");
            Console.WriteLine(pringles.Peek());
            Console.WriteLine(pringles.Pop());
            Console.WriteLine(pringles.Pop());
            Console.WriteLine(pringles.Pop());

            Something1();
            Something2();
            Something3();
        }

        public static void Something1()
        {

        }

        public static void Something2()
        {

        }

        public static void Something3()
        {
            Something2();
        }
    }

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }

}
