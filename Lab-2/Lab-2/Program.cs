using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double value;
            string continueCheck;
            string checkLength;
            string checkWidth;

            do
            {
                Console.WriteLine("Please enter length of the room: ");
                checkLength = Console.ReadLine();
                Console.WriteLine("Please enter width of the room: ");
                checkWidth = Console.ReadLine();

                while (true)
                {
                    if (double.TryParse(checkLength, out value))
                    {
                        length = double.Parse(checkLength);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Length must be a valid integer or decimal");
                        Console.WriteLine("Please re-enter length: ");
                        checkLength = Console.ReadLine();
                    }
                }

                while (true)
                {
                    if (double.TryParse(checkWidth, out value))
                    {
                        width = double.Parse(checkWidth);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Width must be a valid integer or decimal");
                        Console.WriteLine("Please re-enter width: ");
                        checkWidth = Console.ReadLine();
                    }
                }

                double area = length * width;
                double perimeter = (length * 2) + (width * 2);

                Console.WriteLine($"The length equals: {length}");
                Console.WriteLine($"The width equals: {width}");
                Console.WriteLine($"The area equals: {area}");
                Console.WriteLine($"The perimeter equals: {perimeter}");
                Console.WriteLine("Would you like to try again (y/n)? ");
                continueCheck = Console.ReadLine();

            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));

            Console.ReadLine();
        }
    }
}
