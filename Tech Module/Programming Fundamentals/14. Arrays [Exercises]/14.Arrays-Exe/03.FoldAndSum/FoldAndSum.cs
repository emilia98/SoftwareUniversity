using System;
using System.Linq;

namespace _03.FoldAndSum
{
    class FoldAndSum
    {
        static void Main()
        {
            //input:
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();          
            int k = (int)array.Length / 4;
            var arr1 = new int[2 * k];
            var arr2 = new int[2 * k];

            int[] arrPartOne = GetArrayAndReverse(k, 0, array);
            int[] arrPartTwo = GetArrayAndReverse(k, 3 * k, array);

            arr1 = arrPartOne.Concat(arrPartTwo).ToArray();
            arr2 = array.Skip(k).Take(2 * k).ToArray();

            var summedArray = SumArrays(arr1, arr2);

            Console.WriteLine(String.Join(" ", summedArray));
            //goto input;
        }

        static int[] GetArrayAndReverse(int k, int startIndex, int[] array)
        {
            int[] newArray = new int[k];
            int counter = 0;
            for (int index = startIndex; index < startIndex + k; index++)
            {
                newArray[counter] = array[index];
                counter++;
            }
            return newArray.Reverse().ToArray();
        }
        
        static long[] SumArrays(int[] arr1, int[] arr2)
        {
            var newArray = new long[arr1.Length];

            for (int index = 0; index < arr1.Length; index++)
            {
                newArray[index] = arr1[index] + arr2[index];
            }
            return newArray;
        }
    }
}
