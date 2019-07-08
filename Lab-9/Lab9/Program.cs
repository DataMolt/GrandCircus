using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueCheck = null;
            
            var studentList = new List<Student>();

            var Adam = new Student("Adam");
            Adam.SetAge("29");
            Adam.SetInterest("Bad Movies");
            Adam.SetFavoriteFood("Pizza");
            studentList.Add(Adam);

            var Kelly = new Student("Kelly");
            Kelly.SetAge("25");
            Kelly.SetInterest("Gardening");
            Kelly.SetFavoriteFood("Bread");
            studentList.Add(Kelly);

            var Vincent = new Student("Vincent");
            Vincent.SetAge("5");
            Vincent.SetInterest("Barking at squirrels");
            Vincent.SetFavoriteFood("Ribs");
            studentList.Add(Vincent);

            var Haley = new Student("Haley");
            Haley.SetAge("25");
            Haley.SetInterest("Video Games");
            Haley.SetFavoriteFood("Chicken and waffles");
            studentList.Add(Haley);

            var Devon = new Student("Devon");
            Devon.SetAge("26");
            Devon.SetInterest("Basketball");
            Devon.SetFavoriteFood("Burritos");
            studentList.Add(Devon);

            var sortedStudentList = SortListByName(studentList);

            do
            {
                PrintStudents(sortedStudentList);

                Console.WriteLine("Please indicate which student you'd like information on, based on their student number.");
                Console.Write("Or, if you'd like to add a new student, type 'add': ");
                string userInput = Console.ReadLine();

                if (userInput.Equals("add", StringComparison.OrdinalIgnoreCase))
                {
                    AddStudentToList(sortedStudentList);
                    sortedStudentList = SortListByName(sortedStudentList);
                    PrintStudents(sortedStudentList);
                }
                else
                {
                    int checkedUserInput = InputChecker(userInput, sortedStudentList);
                    var studentName = ReturnName(sortedStudentList, checkedUserInput);
                    ReturnStudentInformation(studentName, sortedStudentList, checkedUserInput);
                }

                Console.WriteLine("Would you like to add or get information on another student (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));

            Console.ReadLine();
        }

        public static int InputChecker(string userInput, List<Student> studentList)
        {
            int checkedInput;
            while (true)
            {
                if ((int.TryParse(userInput, out checkedInput)) && (int.Parse(userInput) > 0) && int.Parse(userInput) <= studentList.Count)
                {
                    checkedInput = int.Parse(userInput);
                    break;
                }
                else
                {
                    Console.Write("Please enter a valid student number: ");
                    userInput = Console.ReadLine();
                }
            }
            return checkedInput - 1;
        }

        public static void PrintStudents(List<Student> studentList)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                Console.WriteLine($"Student {i+1}: {studentList[i].GetName()}");
            }
        }

        public static List<Student> SortListByName(List<Student> studentList)
        {
            return studentList.OrderBy(x => x.GetName()).ToList();
        }

        public static string ReturnName(List<Student> studentList, int studentListIndex)
        {
            return studentList[studentListIndex].GetName();
        }

        public static void ReturnStudentInformation(string studentName, List<Student> studentList, int studentListIndex)
        {
            string continueCheck = null;
            do
            {
                string returnRequestedInformaton = null;
                string userRequestInput = null;
                Console.WriteLine("1 Age\n2 Interest\n3 Favorite Food");
                Console.Write($"What information would you like to know about {studentName}? ");
                userRequestInput = Console.ReadLine();
                switch (userRequestInput)
                {
                    case "1":
                        returnRequestedInformaton = $"{studentName}'s age is {studentList[studentListIndex].GetAge()}";
                        break;
                    case "2":
                        returnRequestedInformaton = $"{studentName} likes {studentList[studentListIndex].GetInterest()}";
                        break;
                    case "3":
                        returnRequestedInformaton = $"{studentName}'s favorite food is {studentList[studentListIndex].GetFavoriteFood()}";
                        break;
                    default:
                        Console.Write("Please enter a valid number related to student interest: ");
                        break;
                }
                Console.WriteLine(returnRequestedInformaton);
                Console.WriteLine("Would you like to know more (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
        }

        public static void AddStudentToList(List<Student> studentList)
        {
            Console.Write("Please enter a student name: ");
            string studentName = Console.ReadLine();
            studentName = CheckForBlankValue(studentName);
            var newStudent = new Student(studentName);
            Console.Write("Please enter student's age: ");
            var studentAge = CheckForBlankValue(Console.ReadLine());
            newStudent.SetAge(studentAge);
            Console.Write("Please enter student's interest: ");
            var studentInterest = CheckForBlankValue(Console.ReadLine());
            newStudent.SetInterest(studentInterest);
            Console.Write("Please enter student's favorite food: ");
            var studentFood = CheckForBlankValue(Console.ReadLine());
            newStudent.SetFavoriteFood(studentFood);
            studentList.Add(newStudent);
        }

        public static string CheckForBlankValue(string userInput)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Cannot accept blank value");
                    Console.Write("Please re-enter value: ");
                    userInput = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }
            return userInput;
        }
    }
}
