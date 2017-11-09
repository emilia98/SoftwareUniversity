using System;
using System.Linq;

namespace _02.ReverseArrayOfIntegers_2
{
    class ReverseArrayOfIntegers_2
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int index = 0; index < n; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(String.Join(" ", array.Reverse()));
        }
    }
}
