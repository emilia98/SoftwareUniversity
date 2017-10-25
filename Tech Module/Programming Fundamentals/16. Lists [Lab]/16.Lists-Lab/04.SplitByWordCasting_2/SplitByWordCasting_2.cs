using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SplitByWordCasting_2
{
    class SplitByWordCasting_2
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

            foreach (var word in words)
            {
                var lowercaseLetters = 0;
                var uppercaseLetters = 0;

                foreach (var character in word)
                {
                    if(character >= 'A' && character <= 'Z')
                    {
                        uppercaseLetters++;
                    }
                    else if(character >= 'a' && character <= 'z')
                    {
                        lowercaseLetters++;
                    }                                       
                }

                if(word.Length == lowercaseLetters)
                {
                    lowercaseWords.Add(word);
                    continue;
                }

                if (word.Length == uppercaseLetters)
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
    }
}
