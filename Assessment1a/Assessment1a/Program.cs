using System;

namespace Assessment1a
{
    class Program
    {
        static void Main(string[] args)
        {
            // problem 1
            double gradePass = 66;
            double gradeFail = 65;
            bool isPassing = IsPassing(gradePass);
            bool isFailing = IsPassing(gradeFail);
            Console.WriteLine(isPassing);
            Console.WriteLine(isFailing);

            // problem 2
            double grade1 = 85.5;
            double grade2 = 92.8;
            double grade3 = 96.7;
            double getAverage = AverageGrades(grade1, grade2, grade3);
            Console.WriteLine(getAverage);

            // problem 3
            double grade4 = 63;
            double grade5 = 64;
            double grade6 = 94;
            double grade7 = 95;
            Console.WriteLine(OddOrEvenAndPassing(grade4));
            Console.WriteLine(OddOrEvenAndPassing(grade5));
            Console.WriteLine(OddOrEvenAndPassing(grade6));
            Console.WriteLine(OddOrEvenAndPassing(grade7));

            Console.ReadLine();
        }

        public static bool IsPassing(double grade)
        {
            return grade > 65;
        }

        public static bool IsEven(double grade)
        {
            return (grade % 2) == 0;
        }

        public static double AverageGrades(double grade1, double grade2, double grade3)
        {
            double gradeSum = grade1 + grade2 + grade3;
            double gradeAverage = gradeSum / 3;
            return gradeAverage;
        }

        public static string OddOrEvenAndPassing(double grade)
        {
            string returnStatement;
            if (IsPassing(grade) && !IsEven(grade))
            {
                returnStatement = "Passing and odd";
            }
            else if (!IsPassing(grade) && !IsEven(grade))
            {
                returnStatement = "Failing and odd";
            }
            else if (IsPassing(grade) && (IsEven(grade)))
            {
                returnStatement = "Passing and even";
            }
            else if (!IsPassing(grade) && IsEven(grade))
            {
                returnStatement = "Failing and even";
            }
            else
            {
                return null;
            }
            return returnStatement;
        }
    }

}
