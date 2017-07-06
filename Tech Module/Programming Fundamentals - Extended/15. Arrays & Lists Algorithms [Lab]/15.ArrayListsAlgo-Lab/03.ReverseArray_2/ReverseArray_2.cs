using System;
using System.Linq;

namespace _03.ReverseArray_2
{
    class ReverseArray_2
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = array.Length;
            int[] resultArray = new int[n];
            int resultIndex = 0;

            for (int index = n - 1; index >= 0; index--)
            {
                resultArray[resultIndex] = array[index];
                resultIndex++;
            }
            Console.WriteLine(String.Join(" ", resultArray));
;        }
    }
}
