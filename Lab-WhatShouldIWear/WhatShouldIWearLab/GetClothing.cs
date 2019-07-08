using Lab_11;
using System;
using System.Collections.Generic;
using System.Text;

namespace WhatShouldIWearLab
{
    public class GetClothing
    {
        public Dictionary<string, Dictionary<int, string>> BuildClothingCategoryDict()
        {
            var clothingDict = new Dictionary<string, Dictionary<int, string>>
            {
                {"casual", new Dictionary<int, string>
                    { {1, "jamies"}, {2, "sweat pants" }, {3, "jorts" } } },
                {"semiformal", new Dictionary<int, string>
                    { {1, "a popped collar"}, {2, "a bowtie" }, {3, "black socks" } } },
                {"formal", new Dictionary<int, string>
                    { {1, "a top hat"}, {2, "a monocle" }, {3, "Mr. Peanut" } } },
                };
            return clothingDict;
        }

        public Dictionary<string, Dictionary<int, string>> BuildClothingTempDict()
        {
            var clothingDict = new Dictionary<string, Dictionary<int, string>>
            {
                {"cold", new Dictionary<int, string>
                    { {1, "a jacket"}, {2, "a big boot" }, {3, "75 t-shirts" } } },
                {"moderate", new Dictionary<int, string>
                    { {1, "chaps"}, {2, "a barrel" }, {3, "whatever" } } },
                {"hot", new Dictionary<int, string>
                    { {1, "sunglasses"}, {2, "swim trunks" }, {3, "hawaiian shirt" } } },
                };
            return clothingDict;
        }

        public void returnCategoryChoices()
        {
            var categoryList = Enum.GetValues(typeof(Categories));
            foreach (var item in categoryList)
            {
                Console.WriteLine($"{item}");
            }
        }

        public void returnTempChoices()
        {
            var tempList = Enum.GetValues(typeof(Temperature));
            foreach (var item in tempList)
            {
                Console.WriteLine($"{item}");
            }
        }

        public string GetCategory(Categories category)
        {
            string returnCategory = "default";
            switch (category)
            {
                case Categories.casual:
                    returnCategory = "casual";
                    break;
                case Categories.semiformal:
                    returnCategory = "semiformal";
                    break;
                case Categories.formal:
                    returnCategory = "formal";
                    break;
                default:
                    break;
            }
            return returnCategory;
        }

        public string GetTemp(Temperature temp)
        {
            string returnCategory = "default";
            switch (temp)
            {
                case Temperature.cold:
                    returnCategory = "cold";
                    break;
                case Temperature.moderate:
                    returnCategory = "moderate";
                    break;
                case Temperature.hot:
                    returnCategory = "hot";
                    break;
                default:
                    break;
            }
            return returnCategory;
        }

        public string CheckReturnCategory()
        {
            string returnCategory = "Defualt";
            Categories clearedCategoryCheck;
            bool checker = true;
            do
            {
                Console.Clear();
                returnCategoryChoices();
                Console.Write("\nChoose the type of clothing you'd like to wear: ");
                var response = Console.ReadLine();
                if (Enum.TryParse<Categories>(response, out clearedCategoryCheck) && Enum.IsDefined(typeof(Categories), clearedCategoryCheck))
                {
                    returnCategory = GetCategory(clearedCategoryCheck);
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

        public string CheckReturnTemp()
        {
            string returnTemp = "Defualt";
            Temperature clearedTempCheck;
            bool checker = true;
            do
            {
                Console.Clear();
                returnTempChoices();
                Console.Write("\nChoose the type of weather outside: ");
                var response = Console.ReadLine();
                if (Enum.TryParse<Temperature>(response, out clearedTempCheck) && Enum.IsDefined(typeof(Temperature), clearedTempCheck))
                {
                    returnTemp = GetTemp(clearedTempCheck);
                    checker = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Can only accept a valid category or category number.\n");
                }
            } while (checker);
            return returnTemp;
        }

        public Dictionary<int, string> ChooseClothingCategory(Dictionary<string, Dictionary<int, string>> clothingMaster, string returnCategory)
        {
            return clothingMaster[returnCategory];
        }

        public Dictionary<int, string> ChooseClothingTemp(Dictionary<string, Dictionary<int, string>> clothingMaster, string returnTemp)
        {
            return clothingMaster[returnTemp];
        }

        public string SelectRandomClothingCategory(Dictionary<int, string> clothing)
        {
            Random random = new Random();
            var randNum = random.Next(1, 4);
            return clothing[randNum];
        }

        public string SelectRandomClothingTemp(Dictionary<int, string> clothing)
        {
            Random random = new Random();
            var randNum = random.Next(1, 4);
            return clothing[randNum];
        }
    }
}
