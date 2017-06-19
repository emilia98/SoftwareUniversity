//Get Min of N numbers
using System;

namespace _00.Try_MinMethod
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < n - 1; j++)
            {
                if (min > GetMin(array[j], array[j + 1]))
                {
                    min = GetMin(array[j], array[j + 1]);
                }
            }
            Console.WriteLine(min);
        }

        static int GetMin(int num1, int num2)
        {
            int min;
            if (num1 <= num2)
            {
                min = num1;
            }
            else
            {
                min = num2;
            }
            return min;
        }
    }
}
