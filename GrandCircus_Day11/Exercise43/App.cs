using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise43
{
    class App
    {
        public static void Run()
        {
            Console.Write("Please enter an X coordinate: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Please enter an Y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            var point = new Point(x, y);

            Console.WriteLine($"You have created a point object ({x},{y}). It has a distance of {point.GetDistance()}.");

            Console.ReadLine();
        }
    }
}
