using System;
using System.Linq;

namespace _05.RoundingNumbersAwayFromZero
{
    class RoundingNumbersAwayFromZero
    {
        static void Main()
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            foreach (double number in numbers)
            {
                double diff = Math.Abs((int)number - number);
                int roundedNumber = 0;

                if(diff >= 0.5)
                {
                    if(number >= 0)
                    {
                        roundedNumber = (int)number + 1;
                    }
                    else
                    {
                        roundedNumber = (int)number - 1;
                    }
                }
                else
                {
                    roundedNumber = (int)number;
                }
                Console.WriteLine("{0} => {1}", number, roundedNumber);
            }
        }
    }
}
