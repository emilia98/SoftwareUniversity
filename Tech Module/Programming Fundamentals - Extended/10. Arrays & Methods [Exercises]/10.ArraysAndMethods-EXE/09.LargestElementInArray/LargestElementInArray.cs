using System;

namespace _09.LargestElementInArray
{
    class LargestElementInArray
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (uint i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxNumber = array[0];
            for (uint j = 1; j < n; j++)
            {
                if(array[j] > maxNumber)
                {
                    maxNumber = array[j];
                }
            }
            Console.WriteLine(maxNumber);
        }
    }
}
