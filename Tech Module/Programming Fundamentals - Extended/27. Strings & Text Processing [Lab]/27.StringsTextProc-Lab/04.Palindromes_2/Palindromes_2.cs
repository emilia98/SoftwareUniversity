using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes_2
{
    class Palindromes_2
    {
        static void Main()
        {
            char[] delimiter = { '.', ',', '!', '?', ' ' };
            string[] words = Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new SortedSet<string>();
            foreach (var word in words)
            {
                int middle = (word.Length) / 2;

                var firstPart = word.Substring(0, word.Length - middle).ToList();
                var secondPart = word.Substring(middle).Reverse().ToArray().ToList();

                if (firstPart.SequenceEqual(secondPart))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(String.Join(", ", palindromes));
        }
    }
}
