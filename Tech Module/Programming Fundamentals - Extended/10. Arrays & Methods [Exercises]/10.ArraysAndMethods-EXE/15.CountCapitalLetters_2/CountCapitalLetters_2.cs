using System;

namespace _15.CountCapitalLetters_2
{
    class CountCapitalLetters_2
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');

            int capitalizedStrings = CheckEachString(splitInput);
            Console.WriteLine(capitalizedStrings);

        }

        static int CheckEachString(string[] array)
        {
            int capitalizedStrings = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string currentString = array[i];
                int currentStringLength = currentString.Length;
                bool areCapitalized = true;

                areCapitalized = AreLetterCapitalizedInCurrentString(currentString, areCapitalized);

                if(areCapitalized)
                {
                    capitalizedStrings++;
                }
            }
            return capitalizedStrings;
        }

        static bool AreLetterCapitalizedInCurrentString(string currentString, bool areCapitalized)
        {
            for (int i = 0; i < currentString.Length; i++)
            {
                if(currentString[i] < 'A' || currentString[i] > 'Z')
                {
                    areCapitalized = false;
                    break;
                }
            }
            return areCapitalized;
        }
    }
}
