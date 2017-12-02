using System;
using System.Linq;

namespace _03.SearchForANumber
{
    class SearchForANumber
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

            nums = nums.Skip(0).Take(numsToTake).ToList();
            nums.RemoveRange(0, numsToDelete);

            if (nums.IndexOf(numToFind) == -1)
            {
                Console.WriteLine("NO!");
            }
            else
            {
                Console.WriteLine("YES!");
            }
            //goto input;
        }
    }
}
