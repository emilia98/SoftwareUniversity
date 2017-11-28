using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers_4
{
    class CountNumbers_4
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort((a, b) => a - b);

            var numbers = new List<int>();
            var occurrences = new List<int>();
            int cnt = 0;

            for (int index = 0; index < nums.Count; index++)
            {
                int occurrenceIndex = numbers.IndexOf(nums[index]);
                if (occurrenceIndex == -1)
                {
                    numbers.Add(nums[index]);
                    occurrences.Add(1);
                    cnt++;
                }
                else
                {
                    occurrences[occurrenceIndex]++;
                }

            }

            for (int index = 0; index < numbers.Count; index++)
            {
                Console.WriteLine($"{numbers[index]} -> { occurrences[index]}");
            }
        }
    }
}
