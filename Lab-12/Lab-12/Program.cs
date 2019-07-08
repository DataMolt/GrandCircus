using System;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var newStudent = new Student("Adam", "123 Fake Street", "C# After Hours", 1, 5.00);
            newStudent.ToString();
            Console.WriteLine("\n");
            var newStaff = new Staff("James", "QL", "Grand Circus", 1000000);
            newStaff.ToString();

            Console.ReadLine();
        }

    }
}
