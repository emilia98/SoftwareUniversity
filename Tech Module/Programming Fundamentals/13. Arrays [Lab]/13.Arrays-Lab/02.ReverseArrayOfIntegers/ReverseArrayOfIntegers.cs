using System;

namespace _02.ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for(int index = 0; index < n; index++)
            {
                int number = int.Parse(Console.ReadLine());
                array[index] = number;
            }

            for(int index = n - 1; index >= 0; index--)
            {
                Console.Write(array[index]);

                if(index > 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
