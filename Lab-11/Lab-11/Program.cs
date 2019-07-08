using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {

            var movieList = BuildMovieList();

            string continueCheck;
            do
            {
                var returnCategory = checkReturnCategory();
                var categoryList = buildCategoryList(returnCategory, movieList);
                returnSelectedCategoryTitles(categoryList);
                Console.Write("\nWould you like to get movies of another category? (y/n)? ");
                continueCheck = Console.ReadLine();
            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("Goodbye!");

            Console.ReadLine();
        }

        public static List<Movie> BuildMovieList()
        {
            var hausu = new Movie("Hausu", "Horror");
            var midnightCowboy = new Movie("Midnight Cowboy", "Drama");
            var fantasticMrFox = new Movie("The Fantastic Mr. Fox", "Animated");
            var bladeRunner = new Movie("Bladerunner", "SciFi");
            var videodrome = new Movie("Videodrome", "Horror");
            var cleo5To7 = new Movie("Cleo From 5 to 7", "Drama");
            var forbiddenPlanet = new Movie("Forbidden Planet", "Animated");
            var metropolis = new Movie("Metropolis", "SciFi");
            var itFollows = new Movie("It Follows", "Horror");
            var barryLyndon = new Movie("Barry Lyndon", "Drama");
            var akira = new Movie("Akira", "Animated");
            var childrenOfMen = new Movie("Children of Men", "SciFi");
            var movieList = new List<Movie>()
            {
                hausu, midnightCowboy, fantasticMrFox, bladeRunner, videodrome, cleo5To7, forbiddenPlanet,
                    metropolis, itFollows, barryLyndon, akira, childrenOfMen
            };
            return movieList;

        }


        public static string getCategory(Categories category)
        {
            string returnCategory = "default";
            switch (category)
            {
                case Categories.Horror:
                    returnCategory = "Horror";
                    break;
                case Categories.Drama:
                    returnCategory = "Drama";
                    break;
                case Categories.Animated:
                    returnCategory = "Animated";
                    break;
                case Categories.SciFi:
                    returnCategory = "SciFi";
                    break;
                default:
                    break;
            }
            return returnCategory;
        }

        public static string checkReturnCategory()
        {
            string returnCategory = "Defualt";
            Categories clearedCategoryCheck;
            bool checker = true;
            do
            {
                returnCategoryChoices();
                Console.Write("Choose a movie category or category number from the above list: ");
                var response = Console.ReadLine();
                if (Enum.TryParse<Categories>(response, out clearedCategoryCheck) && Enum.IsDefined(typeof(Categories), clearedCategoryCheck)) 
                {
                    returnCategory = getCategory(clearedCategoryCheck);
                    checker = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Can only accept a valid category or category number.\n");
                }
            } while (checker);
            return returnCategory;
        }





        public static List<string> buildCategoryList (string returnCategory, List<Movie> movieList)
        {
            var categoryList = new List<string>();
            foreach (var movie in movieList)
            {
                if (movie.Category == returnCategory)
                {
                    categoryList.Add(movie.Title);
                }
            }
            categoryList.Sort();
            return categoryList;
        }

        public static void returnSelectedCategoryTitles(List<string> categoryList)
        {
            foreach (var item in categoryList)
            {
                Console.WriteLine(item);
            }
        }


        public static void returnCategoryChoices()
        {
            var categoryList = Enum.GetValues(typeof(Categories));
            var counter = 1;
            foreach (var item in categoryList)
            {
                Console.WriteLine($"{counter} - {item}");
                counter += 1;
            }
        }
    }
}
