using System;
using System.Collections.Generic;

namespace _01.LetterRepetition
{
    class LetterRepetition
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Dictionary<char, int> charsOccurrencies = new Dictionary<char, int>();
            GetANewDictionary(str, charsOccurrencies);
            string result = String.Empty;
            result = GetAResult(charsOccurrencies, result);
            Console.Write(result);
        }

        static Dictionary<char,int> GetANewDictionary(string str, Dictionary<char,int> charsOccurrencies)
        {
            for (int index = 0; index < str.Length; index++)
            {
                char currentChar = str[index];

                if (charsOccurrencies.ContainsKey(currentChar) == false)
                {
                    charsOccurrencies.Add(currentChar, 1);
                }
                else
                {
                    charsOccurrencies[currentChar]++;
                }
            }
            return charsOccurrencies;
        }

        static string GetAResult(Dictionary<char,int> charsOccurrencies, string result)
        {
            foreach (char character in charsOccurrencies.Keys)
            {
                result += $"{character} -> {charsOccurrencies[character]} \n";
            }
            return result;
        }
    }
}
