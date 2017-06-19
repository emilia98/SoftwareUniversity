using System;

namespace _15.CountCapitalLetters
{
    class CountCapitalLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');

            int capitalizedStrings = 0;

            for (int i = 0; i < splitInput.Length; i++)
            {
                string currentString = splitInput[i];
                int currentStringLength = splitInput[i].Length;
                bool areAllCapitalized = true;
                for (int j = 0; j < currentStringLength; j++)
                {
                    if (currentString[j] < 'A' || currentString[j] > 'Z')
                    {
                        areAllCapitalized = false;
                        break;
                    }
                }

                if (areAllCapitalized)
                {
                    capitalizedStrings++;
                }
            }

            Console.WriteLine(capitalizedStrings);
        }
    }
}
