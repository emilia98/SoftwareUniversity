using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main()
        {
            var array1 = Console.ReadLine().Split(' ').ToArray();
            var array2 = Console.ReadLine().Split(' ').ToArray();

            int minSize = Math.Min(array1.Length, array2.Length);
            int maxSize = Math.Max(array1.Length, array2.Length);

            int commonStartCounter = FindCommonStart(array1, array2, minSize);
            int commonEndCounter = FindCommonEnd(array1, array2, minSize);

            if (commonStartCounter > commonEndCounter)
            {
                Console.WriteLine(commonStartCounter);
            }
            else
            {
                Console.WriteLine(commonEndCounter);
            }
        }

        static int FindCommonStart(string[] array1, string[] array2, int minSize)
        {
            int countCommonStart = 0;

            for (int index = 0; index < minSize; index++)
            {
                if (array1[index] != array2[index])
                {
                    break;
                }
                countCommonStart++;
            }
            return countCommonStart;
        }

        static int FindCommonEnd(string[] array1, string[] array2, int minSize)
        {
            int countCommonEnd = 0;
            int size1 = array1.Length;
            int size2 = array2.Length;

            int index = 0;
            while (index < minSize)
            {
                if (array1[size1 - 1 - index] != array2[size2 - 1 - index])
                {
                    break;
                }
                index++;
                countCommonEnd++;
            }
            return countCommonEnd;
        }          
    }
}
