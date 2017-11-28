using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.CountNumbers_5
{
    class CountNumbers_5
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums.Sort((a, b) => a - b);

            var numbers = new List<int>();
            var occurrences = new List<int>();
            int cnt = 0;

            numbers.Add(nums[0]);
            occurrences.Add(1);
            for (int index = 1; index < nums.Count; index++)
            {
                if (nums[index - 1] == nums[index])
                {
                    occurrences[cnt]++;
                }
                else
                {
                    numbers.Add(nums[index]);
                    occurrences.Add(1);
                    cnt++;
                }
            }

            for (int index = 0; index < numbers.Count; index++)
            {
                Console.WriteLine($"{numbers[index]} -> { occurrences[index]}");
            }
        }
    }
}
