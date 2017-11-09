using System;
using System.Linq;

namespace _07.SumArrays
{
    class SumArrays
    {
        static void Main()
        {
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            int size1 = array1.Length;
            int size2 = array2.Length;           
            int maxSize = Max(size1, size2);
            int[] resultedArray = new int[maxSize];

            if(size1 > size2)
            {
                array2 = ExpandShorterArray(array2, size2, maxSize);
            }
            else if(size1 < size2)
            {
                array1 = ExpandShorterArray(array1, size1, maxSize);
            }

            for (int index = 0; index < maxSize; index++)
            {
                int sum = array1[index] + array2[index];
                resultedArray[index] = sum;
            }
            Console.WriteLine(String.Join(" ", resultedArray));
        }

        static int Max(int size1, int size2)
        {
            int max = size1;

            if(size1 < size2)
            {
                return size2;
            }
            return size1;
        }

        static int[] ExpandShorterArray(int[] array, int size, int maxSize)
        {
            int[] newArray = new int[maxSize];
            int pos = 0;
            for (int index = 0; index < maxSize; index++)
            {
                newArray[index] = array[pos];
                if (pos == size - 1)
                {
                    pos = 0;
                    continue;
                }
                pos++;                
            }
            return newArray;
        }
    }
}
