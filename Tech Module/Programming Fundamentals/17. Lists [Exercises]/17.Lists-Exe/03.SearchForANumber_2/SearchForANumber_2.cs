using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SearchForANumber_2
{
    class SearchForANumber_2
    {
        static void Main()
        {
            //input:
            var nums = Console.ReadLine().Split(' ').
                                          Select(int.Parse).
                                          ToList();
            var searchingParams = Console.ReadLine().Split(' ').
                                                     Select(int.Parse).
                                                     ToList();         
            int numsToTake = searchingParams[0];
            int numsToDelete = searchingParams[1];
            int numToFind = searchingParams[2];

            nums = TakeNumbers(nums, numsToTake);
            nums = DeleteNumbers(nums, numsToDelete);

            bool hasFound = FindNumber(nums, numToFind);
            Console.WriteLine((hasFound == true) ? "YES!" : "NO!");
            //goto input;
        }

        static List<int> TakeNumbers(List<int> nums, int count)
        {
            var takenNums = new List<int>();

            for (int index = 0; index < count; index++)
            {
                takenNums.Add(nums[index]);
            }
            return takenNums;
        }

        static List<int> DeleteNumbers(List<int> nums, int count)
        {
            var numsLeft = new List<int>();

            for (int index = count; index < nums.Count(); index++)
            {
                numsLeft.Add(nums[index]);
            }
            return numsLeft;
        }

        static bool FindNumber(List<int> nums, int numToFind)
        {
            foreach (var num in nums)
            {
                if (num == numToFind)
                {
                    return true;
                }
            }
            return false;
        }

        static void PrintResult(string res)
        {
            Console.WriteLine(res);
        }
    }
}
