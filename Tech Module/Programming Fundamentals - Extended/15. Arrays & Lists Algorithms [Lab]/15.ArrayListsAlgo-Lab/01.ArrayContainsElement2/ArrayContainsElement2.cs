using System;
using System.Linq;

namespace _01.ArrayContainsElement2
{
    class ArrayContainsElement2
    {
        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int givenElement = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                if(givenElement == numbers[i])
                {
                    Console.WriteLine("yes");
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
