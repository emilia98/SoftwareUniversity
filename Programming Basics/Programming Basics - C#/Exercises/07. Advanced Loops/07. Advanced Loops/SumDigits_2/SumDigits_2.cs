using System;

namespace SumDigits_2
{
    class SumDigits_2
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum = sum + (number % 10);
                number /= 10;
            }
            while (number != 0);
            Console.WriteLine(sum);
        }
    }
}
