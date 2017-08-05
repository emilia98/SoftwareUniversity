using System;

namespace _02.CountSubstringOccurs
{
    class CountSubstringOccurs
    {
        static void Main()
        {
            string text = Console.ReadLine().ToLower();
            string substr = Console.ReadLine().ToLower();

            int len = text.Length;
            int index = 0;
            int occurrences = 0;

            /*While the index is smaller than or equal to the length of the entered text minus 
              the length of the given substring.
             */
            while (index <= len- substr.Length)
            {
                if(text.Substring(index, substr.Length) == substr)
                {
                    occurrences++;
                }
                index++;
            }
            Console.WriteLine(occurrences);
        }
    }
}
