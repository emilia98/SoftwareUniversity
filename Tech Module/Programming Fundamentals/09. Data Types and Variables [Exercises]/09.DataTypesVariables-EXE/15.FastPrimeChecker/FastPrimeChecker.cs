using System;

namespace _15.FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main()
        {
            int intervalEnd = int.Parse(Console.ReadLine());
            for (int currentNumber = 2; currentNumber <= intervalEnd; currentNumber++)
            {
                bool isPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(currentNumber); divider++)
                {
                    if (currentNumber % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNumber} -> {isPrime}");
            }

        }
    }
}
