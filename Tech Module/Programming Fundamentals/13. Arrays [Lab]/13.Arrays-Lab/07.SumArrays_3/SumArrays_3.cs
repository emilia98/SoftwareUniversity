using System;
using System.Linq;

namespace _07.SumArrays_3
{
    class SumArrays_3
    {
        static void Main()
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int size1 = array1.Length;
            int size2 = array2.Length;
            int maxSize = size1 > size2 ? size1 : size2;

            if (size1 < size2)
            {
                array1 = modifyArray(array1, size1, maxSize);
            }
            else if (size2 < size1)
            {
                array2 = modifyArray(array2, size2, maxSize);
            }
            var summedArray = sumArrays(array1, array2);
            Console.WriteLine(String.Join(" ", summedArray));
        }

        static int[] modifyArray(int[] array, int size, int maxSize)
        {
            int[] modifiedArray = new int[maxSize];
            int cnt = size;
            array.CopyTo(modifiedArray, 0);

            for (int index = size; index < maxSize; index++)
            {
                modifiedArray[cnt] = array[index % size];
                cnt++;
            }
            return modifiedArray;
        }

        static long[] sumArrays(int[] array1, int[] array2)
        {
            long[] summedArray = new long[array1.Length];
            for (int index = 0; index < array1.Length; index++)
            {
                summedArray[index] = array1[index] + array2[index];
            }
            return summedArray;
        }
    }
}
