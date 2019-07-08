using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Week1_Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueCheck = null;
            do
            {
                Console.WriteLine("Please enter a word or sentence: ");
                string userInput = Console.ReadLine();
                userInput = CheckForEmptyString(userInput);
                string[] userInputSplit = userInput.Split(' ');
                List<string> translatedPigLatinList = new List<string>();

                for (int i = 0; i < userInputSplit.Length; i++)
                {
                    string wordInInputSplit = userInputSplit[i];
                    char firstChar = wordInInputSplit[0];

                    if (SpecialCharacterCheck(wordInInputSplit))
                    {
                        if (IsVowel(firstChar))
                        {
                            StringBuilder pigLatinMaker = new StringBuilder(wordInInputSplit);
                            pigLatinMaker.Append("way");
                            string translatedPigLatin = pigLatinMaker.ToString();
                            translatedPigLatinList.Append(translatedPigLatin);
                            userInputSplit[i] = translatedPigLatin;
                        }
                        else
                        {
                            string consonants = BuildFirstConsonants(wordInInputSplit);
                            StringBuilder pigLatinMaker = new StringBuilder(wordInInputSplit);
                            pigLatinMaker.Remove(0, consonants.Length);
                            pigLatinMaker.Append(consonants);
                            pigLatinMaker.Append("ay");
                            string translatedPigLatin = pigLatinMaker.ToString();
                            translatedPigLatinList.Append(translatedPigLatin);
                            userInputSplit[i] = translatedPigLatin;
                        }
                    }
                    else
                    {
                        translatedPigLatinList.Append(wordInInputSplit);
                    }
                }
                string completedPigLatinTranslation = string.Join(" ", translatedPigLatinList);
                Console.WriteLine($"\nYour translated text is: {string.Join(" ", userInputSplit)}\n");
                Console.WriteLine("Would you like to try again (y/n)? ");
                continueCheck = Console.ReadLine();

            } while (!continueCheck.Equals("n", StringComparison.OrdinalIgnoreCase));


            Console.ReadLine();
        }

        public static bool IsVowel(char firstCharacter)
        {
            char[] vowelArray = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O','U' };
            return vowelArray.Contains(firstCharacter);         
        }

        public static string BuildFirstConsonants(string lookForVowel)
        {
            string consonants = null;
            for (int i = 0; i < lookForVowel.Length; i++)
            {
                if (!IsVowel(lookForVowel[i]))
                {
                    consonants += lookForVowel[i];
                }
                else
                {
                    break;
                }
            }
            return consonants;
        }

        public static bool SpecialCharacterCheck(string checkForSpecial)
        {
            var regexChecker = new Regex("^[a-zA-Z]+('?)([a-zA-Z]+?)(,?)(\\.?)$");
            return regexChecker.IsMatch(checkForSpecial);
        }

        public static string CheckForEmptyString(string userInput)
        {
            string validUserInput;
            while (true)
            {
                if (!string.IsNullOrEmpty(userInput))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Cannot accept an empty string.");
                    Console.WriteLine("Please re-enter word or sentence: ");
                    userInput = Console.ReadLine();
                }
            }
            return userInput;
        }
    }
}
