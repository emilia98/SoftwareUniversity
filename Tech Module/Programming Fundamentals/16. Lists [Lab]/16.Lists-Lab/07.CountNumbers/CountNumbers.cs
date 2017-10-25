using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main()
        {
            var inputNumbers = Console.ReadLine().Split(' ').
                                             Select(int.Parse).
                                             ToList();
            var numbers = new List<int>();
            var occurrencesCount = new List<int>();

            var minNum = FindMin(inputNumbers);

            while(inputNumbers.Count != 0)
            {
                int element = minNum;
                numbers.Add(element);
                occurrencesCount.Add(CountOccurrences(inputNumbers, element));
                inputNumbers.RemoveAll(e => e == element);
                minNum = FindMin(inputNumbers);
            }

            PrintTheResult(numbers, occurrencesCount);
        }

        static int CountOccurrences(List<int> list, int element)
        {
            int counter = 0;
            for (int cnt = 0; cnt < list.Count; cnt++)
            {
                if(element == list[cnt])
                {
                    counter++;
                }
            }
            return counter;
        }

        static int FindMin(List<int> nums)
        {
            int min = int.MaxValue;
            foreach(var num in nums)
            {
                if(num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        static void PrintTheResult(List<int> numbers, List<int> occurrences)
        {
            for(int index = 0; index < numbers.Count; index++)
            {
                Console.WriteLine("{0} -> {1}", numbers[index], occurrences[index]);
            }
        }  
    }
}
