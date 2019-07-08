using System;
using System.Collections.Generic;

namespace Exercise52
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);

            Console.WriteLine(square.AverageArea().ToString());
            Console.WriteLine(square.AveragePerimiter().ToString());

            var triangle = new Triangle(5, 5, 5);

            Console.WriteLine(triangle.AverageArea().ToString());
            Console.WriteLine(triangle.AveragePerimiter().ToString());

            var circle = new Circle(5);

            Console.WriteLine(circle.AverageArea().ToString());
            Console.WriteLine(circle.AveragePerimiter().ToString());

            Dictionary<string, string> shapeDict = new Dictionary<string, string>();
            shapeDict.Add("1", "Square");
            shapeDict.Add("2", "Triangle");
            shapeDict.Add("3", "Circle");

            Console.WriteLine("Enter a shape you math nerd: ");
            foreach (var item in shapeDict)
            {
                Console.WriteLine(item);
            }
            var shapeInput = Console.ReadLine();
            string selectedShape = GetShapeToCalculate(shapeInput, shapeDict);
            GetAndCalculateValues(selectedShape);
        }


        public static string GetShapeToCalculate(string userInput, Dictionary<string, string> shapeDict)
        {
            string desiredShape = null;
            switch (userInput)
            {
                case "1":
                    desiredShape = shapeDict["1"];
                    break;
                case "2":
                    desiredShape = shapeDict["2"];
                    break;
                case "3":
                    desiredShape = shapeDict["3"];
                    break;
                default:
                    Console.Write("Please enter a valid number related to shapes: ");
                    break;
            }
            return desiredShape;
        }

        public static void GetAndCalculateValues(string desiredShape)
        {
            if (desiredShape == "Square")
            {
                Console.WriteLine("Give me a side value: ");
                double side1 = double.Parse(Console.ReadLine());
                var square = new Square(side1);
                Console.WriteLine($"The average area is: {square.AverageArea()}");
                Console.WriteLine($"The average perimiter is: {square.AveragePerimiter()}");
            }
            if (desiredShape == "Triangle")
            {
                Console.WriteLine("Give me a side value: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Give me a side value: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Give me a side value: ");
                double side3 = double.Parse(Console.ReadLine());
                var triangle = new Triangle(side1, side2, side3);
                Console.WriteLine($"The average area is: {triangle.AverageArea()}");
                Console.WriteLine($"The average perimiter is: {triangle.AveragePerimiter()}");
            }
            if (desiredShape == "Circle")
            {
                Console.WriteLine("Give me a radius:");
                double radius = double.Parse(Console.ReadLine());
                var circle = new Circle(radius);
                Console.WriteLine($"The average area is: {circle.AverageArea()}");
                Console.WriteLine($"The average perimiter is: {circle.AveragePerimiter()}");

            }
        }

    }
}
