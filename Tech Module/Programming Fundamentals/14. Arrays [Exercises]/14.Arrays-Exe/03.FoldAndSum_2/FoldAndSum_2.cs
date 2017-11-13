using System;
using System.Linq;

namespace _03.FoldAndSum_2
{
    class FoldAndSum_2
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = (int)array.Length / 4;

            int[] arr1 = new int[2 * k];
            int[] arr2 = new int[2 * k];

            int[] arrPartOne = array.Skip(0).Take(k).Reverse().ToArray();
            int[] arrPartTwo = array.Skip(3 * k).Take(k).Reverse().ToArray();

            arr1 = arrPartOne.Concat(arrPartTwo).ToArray();
            arr2 = array.Skip(k).Take(2 * k).ToArray();

            var summedArray = new long[2 * k];
            for (int index = 0; index < 2 * k; index++)
            {
                summedArray[index] = arr1[index] + arr2[index];
            }

            Console.WriteLine(String.Join(" ", summedArray));

            //goto input;
        }
    }
}
