using System;

namespace _09.LargestElementArray_2
{
    class LargestElementArray_2
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int[] array = new int[n];

            InitializeArray(n, array);
            int largestElement = GetLargestElement(array);
            Console.WriteLine(largestElement);
        }

        static int InitializeArray(uint n, int[] array)
        {
            for (uint i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            return array[n - 1];
        }

        static int GetLargestElement(int[] array)
        {
            int maxElement = array[0];
            for (uint i = 1; i < array.Length; i++)
            {
                if(array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
    }
}
