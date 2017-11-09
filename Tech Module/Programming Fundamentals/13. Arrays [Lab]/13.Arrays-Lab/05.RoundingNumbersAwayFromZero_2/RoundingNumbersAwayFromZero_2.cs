using System;
using System.Linq;

namespace _05.RoundingNumbersAwayFromZero_2
{
    class RoundingNumbersAwayFromZero_2
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (double number in numbers)
            {
                int roundedNumber = (int)Math.Round(number, 0, MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", number, roundedNumber);
            }
        }
    }
}
