using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.OddOccurrences
{
    class OddOccurrences
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            Dictionary<string, int> words = new Dictionary<string, int>();

            GetANewDictionary(input, words);
            List<string> result = new List<string>();
            result = GetOddOccurrences(words, result);

            Console.WriteLine(String.Join(", ", result));
        }

        static Dictionary<string,int> GetANewDictionary(List<string> input, Dictionary<string,int> words)
        {
            for (int index = 0; index < input.Count; index++)
            {
                string currentWord = input[index].ToLower();

                if(words.ContainsKey(currentWord) == false)
                {
                    words.Add(currentWord, 1);
                }
                else
                {
                    words[currentWord]++;
                }
            }
            return words;
        }

        static List<string> GetOddOccurrences(Dictionary<string,int> words, List<string> result)
        {
           /* foreach(KeyValuePair<string, int> word in words)
            {
                if(word.Value % 2 == 1)
                {
                    result.Add(word.Key);
                }
            }*/
            
            foreach(string key in words.Keys)
            {
                if (words[key] % 2 == 1)
                {
                    result.Add(key);
                }
            }
            return result;
        }
    }
}
