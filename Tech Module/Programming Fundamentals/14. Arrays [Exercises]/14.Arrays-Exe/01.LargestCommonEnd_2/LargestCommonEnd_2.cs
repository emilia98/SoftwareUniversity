using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.LargestCommonEnd_2
{
    class LargestCommonEnd_2
    {
        static void Main()
        {
            var array1 = Console.ReadLine().Split(' ').ToArray();
            var array2 = Console.ReadLine().Split(' ').ToArray();

            int minSize = Math.Min(array1.Length, array2.Length);
            int maxSize = Math.Max(array1.Length, array2.Length);

            var commonStart = FindCommonStart(array1, array2, minSize);
            var commonEnd = FindCommonEnd(array1, array2, minSize);

            if (commonStart.Count > commonEnd.Count)
            {
                Console.WriteLine(commonStart.Count);
            }
            else
            {
                Console.WriteLine(commonEnd.Count);
            }
        }

        static List<string> FindCommonStart(string[] array1, string[] array2, int minSize)
        {
            var commonStart = new List<string>();

            for (int index = 0; index < minSize; index++)
            {
                if (array1[index] != array2[index])
                {
                    break;
                }
                commonStart.Add(array1[index]);
            }
            return commonStart;
        }

        static List<string> FindCommonEnd(string[] array1, string[] array2, int minSize)
        {
            var commonEnd = new List<string>();
            int size1 = array1.Length;
            int size2 = array2.Length;

            int index = 0;
            while (index < minSize)
            {
                if (array1[size1 - 1 - index] != array2[size2 - 1 - index])
                {
                    break;
                }
                commonEnd.Add(array1[size1 - 1 - index]);
                index++;
            }
            commonEnd.Reverse();
            return commonEnd;
        }        
    }
}
