using System;

namespace Exercise_42
{
    class Program
    {
        static void Main(string[] args)
        {
            var newPoint = new Point(1,2);

            Console.WriteLine("Please enter an x value: ");
            newPoint.X = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a y value: ");
            newPoint.Y = int.Parse(Console.ReadLine());

            Console.WriteLine(newPoint.A);
            Console.WriteLine(newPoint.B);

            Console.WriteLine(newPoint.X);
            Console.WriteLine(newPoint.Y);
        }
    }
}
