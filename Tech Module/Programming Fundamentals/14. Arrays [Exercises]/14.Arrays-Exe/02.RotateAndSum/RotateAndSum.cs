using System;
using System.Linq;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int rotations = k % array.Length;
            long[] summedArray = new long[array.Length];

            for (int counter = 1; counter <= k; counter++)
            {
                if (counter == 1)
                {
                    array = RotateArray(array);
                    array.CopyTo(summedArray, 0);
                }
                else
                {
                    array = RotateArray(array);
                    summedArray = SumArrays(array, summedArray);
                }
            }

            Console.WriteLine(String.Join(" ", summedArray));
        }

        static long[] SumArrays(int[] array, long[] summedArray)
        {
            for (int index = 0; index < array.Length; index++)
            {
                summedArray[index] += array[index];
            }
            return summedArray;
        }

        static int[] RotateArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            int lastElement = array[array.Length - 1];
            newArray[0] = lastElement;

            for(int index = 0; index < array.Length - 1; index++)
            {
                newArray[index + 1] = array[index];
            }
            return newArray;
        }
    }
}
