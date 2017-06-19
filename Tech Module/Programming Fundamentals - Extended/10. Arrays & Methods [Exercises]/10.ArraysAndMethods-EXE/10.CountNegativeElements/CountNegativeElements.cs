using System;

namespace _10.CountNegativeElements
{
    class CountNegativeElements
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int counter = 0;
            for (int j = 0; j < n; j++)
            {
                if (array[j] < 0)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
