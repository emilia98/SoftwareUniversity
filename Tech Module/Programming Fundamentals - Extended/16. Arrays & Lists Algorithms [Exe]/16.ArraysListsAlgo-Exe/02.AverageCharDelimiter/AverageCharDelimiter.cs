using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageCharDelimiter
{
    class AverageCharDelimiter
    {
        static void Main()
        {
            List<string> strings = Console.ReadLine().Split(' ').ToList();
            char delimiter = FindTheDelimiter(strings);
            Console.WriteLine(String.Join(delimiter.ToString().ToUpper(), strings));
        }

        static char FindTheDelimiter(List<string> strings)
        {
            int charCount = 0;
            int sumOfChars = 0;
            for (int counter = 0; counter < strings.Count; counter++)
            {
                string currentString = strings[counter];
                charCount += currentString.Length;
                for (int index = 0; index < currentString.Length; index++)
                {
                    char currentChar = currentString[index];
                    sumOfChars += (int)currentChar;
                }
            }

            char delimiter = (char)(sumOfChars / charCount);
            return delimiter;
        }
    }
}
