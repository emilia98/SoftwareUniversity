using System;
using System.Linq;

namespace _07.SumArrays_2
{
    class SumArrays_2
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
                int[] modifiedArray = modifyArray(array1, size1, maxSize);
                array1 = new int[maxSize];
                array1 = modifiedArray;
            }
            else if (size2 < size1)
            {
                int[] modifiedArray = modifyArray(array2, size2, maxSize);
                array2 = new int[maxSize];
                array2 = modifiedArray;
            }

            var summedArray = sumArrays(array1, array2);
            Console.WriteLine(String.Join(" ", summedArray));
        }

        static int[] modifyArray(int[] array, int size, int maxSize)
        {
            int countTimes = (int)Math.Ceiling((double)maxSize / size);
            int[] modifiedArray = new int[maxSize];
            int cnt = size;
            array.CopyTo(modifiedArray, 0);
            int numbersAdded = size;

            for (int counter = 0; counter <= countTimes; counter++)
            {
                for (int index = 0; index < size; index++)
                {
                    if (numbersAdded == maxSize)
                    {
                        return modifiedArray;
                    }
                    modifiedArray[cnt] = array[index];
                    cnt++;
                    numbersAdded++;
                }

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
