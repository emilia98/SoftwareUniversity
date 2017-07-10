using System;
using System.Collections.Generic;

namespace _01.LetterRepetition_2
{
    class LetterRepetition_2
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Dictionary<char, int> charsOccurrencies = new Dictionary<char, int>();
            GetANewDictionary(str, charsOccurrencies);
            PrintTheResult(charsOccurrencies);          
        }

        static Dictionary<char, int> GetANewDictionary(string str, Dictionary<char,int> charsOccurrencies)
        {
            for (int index = 0; index < str.Length; index++)
            {
                char currentChar = str[index];
                if (!charsOccurrencies.ContainsKey(currentChar))
                {
                    charsOccurrencies.Add(currentChar, 0);
                }
                charsOccurrencies[currentChar]++;
            }
            return charsOccurrencies;
        }

        static void PrintTheResult(Dictionary<char, int> charsOccurrencies)
        {
            foreach (KeyValuePair<char, int> character in charsOccurrencies)
            {
                Console.WriteLine("{0} -> {1}", character.Key, character.Value);
            }
        }
    }
}
