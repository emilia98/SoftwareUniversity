using System;
using System.Linq;

namespace _02.SmallestElementArray
{
    class SmallestElementInArray
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int minValue = int.MaxValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                if(numbers[index] < minValue)
                {
                    minValue = numbers[index];
                }
            }
            Console.WriteLine(minValue);
        }
    }
}
