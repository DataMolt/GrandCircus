using System;
using System.Collections.Generic;
using System.Text;

namespace WhatShouldIWearLab
{
    public class MakeItHappen
    {
        public void makeItHappen()
        {
            string userInput = "y";
            while (!(userInput.Equals("n")))
            {
                Console.Clear();
                var getClothing = new GetClothing();
                var categoryDict = getClothing.BuildClothingCategoryDict();
                var tempDict = getClothing.BuildClothingTempDict();
                var userSelectionCategory = getClothing.CheckReturnCategory();
                var userSelectionTemp = getClothing.CheckReturnTemp();
                var getCategory = getClothing.ChooseClothingCategory(categoryDict, userSelectionCategory);
                var getTemp = getClothing.ChooseClothingTemp(tempDict, userSelectionTemp);
                var suggestedCategory = getClothing.SelectRandomClothingCategory(getCategory);
                var suggestedTemp = getClothing.SelectRandomClothingTemp(getTemp);
                Console.WriteLine($"\nOk, you're feeling {userSelectionCategory} and it's {userSelectionTemp} you should wear {suggestedCategory} and {suggestedTemp}");
                Console.Write("\nDo you want to try again (y/n)? ");
                userInput = Console.ReadLine();
            }
        }
    }
}
