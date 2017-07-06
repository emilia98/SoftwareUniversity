using System;
using System.Linq;

namespace _03.ReverseArray
{
    class ReverseArray
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int start = 0, end = array.Length - 1; start < end; start++, end --)
            {
                int temp = array[start];
                array[start] = array[end];
                array[end] = temp;
            }
            Console.WriteLine(String.Join(" ", array));
        }
    }
}
