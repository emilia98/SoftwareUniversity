using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OddOccurrences_2
{
    class OddOccurrences_2
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();
            GetANewDictionary(input, words);

            List<string> result = new List<string>();
            result = GetOddOccurrences(words, result);
            Console.WriteLine(String.Join(", ",result));
        }

        static Dictionary<string,int> GetANewDictionary(string[] input, Dictionary<string,int> words)
        {
            for (int index = 0; index < input.Length; index++)
            {
                string currentWord = input[index].ToLower();

                if(!words.ContainsKey(currentWord))
                {
                    words.Add(currentWord, 0);
                }
                words[currentWord]++;
            }
            return words;
        }

        static List<string> GetOddOccurrences(Dictionary<string, int> words, List<string> result)
        {
            foreach(KeyValuePair<string,int> word in words)
            {
                if(word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }
            return result;
        }
    }
}
