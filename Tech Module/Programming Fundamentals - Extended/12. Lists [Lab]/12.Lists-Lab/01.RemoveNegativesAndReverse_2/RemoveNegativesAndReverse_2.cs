using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.RemoveNegativesAndReverse_2
{
    class RemoveNegativesAndReverse_2
    {
        static List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        static List<int> nonNegative = new List<int>();

        static void Main()
        {
            nonNegative = FindNonNegativeNumbers(numbers, nonNegative);
            string result = GetTheResult(nonNegative);
            Console.WriteLine(result);
        }

        static List<int> FindNonNegativeNumbers(List<int> numbers, List<int> nonNegative)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] >= 0)
                {
                    nonNegative.Add(numbers[i]);
                }
            }
            return nonNegative;
        }

        static string GetTheResult(List<int> nonNegative)
        {
            string result = String.Empty;
            if(nonNegative.Count == 0)
            {
                result = "empty";
            }
            else
            {
                result = String.Join(" ", ReverseListOfNonNegatives(nonNegative));
            }
            return result;
        }

        static List<int> ReverseListOfNonNegatives(List<int> nonNegative)
        {
            nonNegative.Reverse();            
            return nonNegative;
        }
    }
}
