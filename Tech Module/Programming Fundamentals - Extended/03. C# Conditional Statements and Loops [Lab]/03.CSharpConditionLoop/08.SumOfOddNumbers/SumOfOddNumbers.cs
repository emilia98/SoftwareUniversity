using System;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int currentNumber;

            for (int i = 0; i < n; i++)
            {
                currentNumber = 2 * i + 1;
                Console.WriteLine(currentNumber);
                sum += currentNumber;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
