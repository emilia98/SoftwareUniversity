using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasting
{
    class SplitByWordCasting
    {
        static void Main()
        {
            var text = Console.ReadLine();
            char[] delimiters = { '.', ',', ';', ':', '!', '(', ')', '"',  '\'', '\\',
                                  '/', '[', ']', ' '};
            var words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            
            var lowercaseWords = new List<string>();
            var uppercaseWords = new List<string>();
            var mixedcaseWords = new List<string>();

            foreach(var word in words)
            {
                if(word.ToLower() == word && !HasSpecialCharacters(word))
                {
                    lowercaseWords.Add(word);
                    continue;
                }

                if(word.ToUpper() == word && !HasSpecialCharacters(word))
                {
                    uppercaseWords.Add(word);
                    continue;
                }

                mixedcaseWords.Add(word);
            }

            Console.WriteLine("Lower-case: {0}", String.Join(", ", lowercaseWords));
            Console.WriteLine("Mixed-case: {0}", String.Join(", ", mixedcaseWords));
            Console.WriteLine("Upper-case: {0}", String.Join(", ", uppercaseWords));          
        }

        static bool HasSpecialCharacters(string word)
        {
            foreach(var character in word)
            {
                if(character < 65 || character > 123 || (character > 90 && character < 97))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
